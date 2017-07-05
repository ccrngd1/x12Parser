using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model.EDI.X12;
using Model.EDI.X12.v2.Base;

namespace Business.EDI.X12.v2
{
    public class ParserStateMachine : ICloneable
    {
        private Stack<LoopEntity> _currentLoopStack = new Stack<LoopEntity>();

        public List<ParserErrors> Errors { get; private set; }

        private LoopEntity _currentLoop = null;

        public LoopEntity CurrentLoop
        {
            get { return _currentLoop; }
            set
            {
                if(value != null){_currentLoopStack.Push(value);}

                _currentLoop = value;
            }
        }

        public IReadOnlyCollection<LoopEntity> CurrentLoopStack => _currentLoopStack.ToList().AsReadOnly();

        public ParserStateMachine()
        { 
            Errors = new List<ParserErrors>(); 
        }

        public object Clone()
        {
            var retVal = new ParserStateMachine();

            foreach (LoopEntity loopEntity in CurrentLoopStack)
            {
                retVal._currentLoopStack.Push(loopEntity);
            }

            foreach (ParserErrors parserErrors in Errors)
            {
                retVal.Errors.Add(parserErrors);
            }

            retVal.CurrentLoop = this.CurrentLoop;

            return retVal;
        }
    }

    public class ParserErrors
    {
        public string ErrorMessage;
        public X12ErrorTypes ErrorType;
        public X12ErrorLevel ErrorLevel;
        public LoopEntity CurrentLoop;
        public BaseFieldValues CurrentSegment;
    }

    public static class Parser
    { 
        private const string HeaderSegments = "ISA,GS,ST,BHT";
        private const string TrailerSegments = "IEA,GE,SE";

        private static ParserStateMachine ParseLineSegment(this X12Doc tempBuildingDoc, ParserStateMachine state, BaseFieldValues lineContent)
        {
            var retVal = (ParserStateMachine)state.Clone();

            var currentLoopProcessed = false;
            if (retVal.CurrentLoop != null)
            {
                List<BaseStdSegment> qualifiedSegments = retVal.CurrentLoop.IsQualified(lineContent, QulificationLevel.TopMost);

                if (qualifiedSegments.Count == 1) //check just the top most, so check Loop2000A to see if we have a matching def before moving to check Loop2100A and Loop2200A
                {
                    if (qualifiedSegments[0].IsLoopStarter)
                    {
                        retVal.CurrentLoop.ParentLoopCollection.Add();
                        retVal.CurrentLoop = retVal.CurrentLoop.ParentLoopCollection.LoopEntities.Last(); 
                    }

                    retVal.CurrentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                    currentLoopProcessed = true;
                }
                else //want to try first level sub loop
                {

                    qualifiedSegments = retVal.CurrentLoop.IsQualified(lineContent, QulificationLevel.FirstChild);

                    if (qualifiedSegments.Count == 1)
                    {
                        if (qualifiedSegments[0].IsLoopStarter)
                        {
                            qualifiedSegments[0].OwningLoopCollection.Add();
                        }

                        retVal.CurrentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last(); 
                        retVal.CurrentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                        currentLoopProcessed = true;
                    }

                    else if (!qualifiedSegments.Any()) //there were none
                    {
                        var currentLoopCollection = retVal.CurrentLoop.ParentLoopCollection;

                        //if the currentLoop and its subloops can't handle this, lets walk up the stack
                        while (currentLoopCollection.ParentLoopCollection != null)
                        {
                            currentLoopCollection = currentLoopCollection.ParentLoopCollection;

                            //the segment should never belong to the parent, because we ahve already dipped down to the next level...it CAN belong to a sibling, so check first child level
                            //for isntance, if we are in Loop2100B and get a segment for Loop2200B - both are children of Loop2000B, so we have to walk up 2100B->2000B then chekc all children (2100B and 2200B)
                            qualifiedSegments = currentLoopCollection.IsQualified(lineContent, QulificationLevel.FirstChild);

                            if (qualifiedSegments.Count == 1)
                            {
                                if (qualifiedSegments[0].IsLoopStarter) //should always be a starter
                                    qualifiedSegments[0].OwningLoopCollection.Add();
                                else
                                {
                                    //todo: is this an error?
                                    Console.WriteLine("new loop but not a starter segment?");
                                }

                                retVal.CurrentLoop = currentLoopCollection.LoopEntities.Last(); 
                                retVal.CurrentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                                currentLoopProcessed = true;
                            }
                            else
                            {
                                //this isn't unexpected...as we walk up the LoopCollection hierarchy, we may not find a match
                                //for instance, if we are in Loop2220D, we will walk up to Loop2200D, then to Loop2000D, before trying Loop2000E which could be our match
                                Console.Write("DEUBG - walking up the hierarchy did not find anything");
                            }
                        }
                    }
                    else //there were multiple and needs a tiebreaker 
                    {
                        //todo: something
                        Console.WriteLine("we have too many, what do we do?");
                    }
                }
            }

            //if the current loop we have saved off does not claim it, we should just interogate the whole doc again
            //this may not be efficient, we may want to walk back up our stack to make it mo' betta
            if (!currentLoopProcessed)
            {
                var qualifiedSegments = new List<BaseStdSegment>();
                foreach (LoopCollectionBase loopCollection in tempBuildingDoc.TopLevelLoops)
                {
                    qualifiedSegments.AddRange(loopCollection.IsQualified(lineContent, QulificationLevel.FirstChild));
                }

                if (qualifiedSegments.Count == 1)
                {
                    if (qualifiedSegments[0].IsLoopStarter) //should always be
                        qualifiedSegments[0].OwningLoopCollection.Add();
                    else
                    {
                        //todo how to handle this
                        Console.WriteLine("another weird ");
                    }

                    retVal.CurrentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last(); 
                    retVal.CurrentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                    currentLoopProcessed = true;
                }
                else
                {
                    //todo how to handle these
                    Console.WriteLine("nothing found");
                }
            }

            return retVal;
        }

        public static List<X12Doc> ParseFile<T>(string fullFilePath) where T:X12Doc
        {
            X12Doc tempBuildingDoc = (T)Activator.CreateInstance(typeof(T), args: new object[] {true}); 

            var newHeaderSection = false;
            var newTrailerSection = false;
            var parserState = new ParserStateMachine();

            var retDocs = new List<X12Doc>(); 

            var sStream = new SegmentStream(File.OpenRead(fullFilePath), ref tempBuildingDoc); 

            var lineContent = new BaseFieldValues(sStream.ReadNextLine(tempBuildingDoc.DocDelimiters));

            List<string> headerSplit = HeaderSegments.Split(',').ToList();
            List<string> trailerSplit = TrailerSegments.Split(',').ToList();

            //6-28 @ 840am moving this into the parser state object
            //LoopEntity currentLoop = null; //todo : should this be a stack? it would allow me to push/pop when I was moving levels...it might help for debug purposes but most likely not in the actual parsing

            while (lineContent != null)
            {
                //is a head segment
                if (headerSplit.Contains(lineContent[0]))
                {
                    if (!newHeaderSection)
                    {
                        if(newTrailerSection)
                            tempBuildingDoc = (T)Activator.CreateInstance(typeof(T), args: new object[] { true });

                        retDocs.Add(tempBuildingDoc);

                        newHeaderSection = true;
                        newTrailerSection = false;
                    } 

                    if (tempBuildingDoc.BeginHierarchicalTransaction.IsQualified(lineContent))
                        tempBuildingDoc.BeginHierarchicalTransaction.Populate(lineContent);
                    else if (tempBuildingDoc.TransactionSetHeader.IsQualified(lineContent))
                        tempBuildingDoc.TransactionSetHeader.Populate(lineContent);
                    else if (tempBuildingDoc.InterchagneControlHeader.IsQualified(lineContent))
                        tempBuildingDoc.InterchagneControlHeader.Populate(lineContent);
                    else if (tempBuildingDoc.FunctionGroupHeader.IsQualified(lineContent))
                        tempBuildingDoc.FunctionGroupHeader.Populate(lineContent);
                    else 
                        Console.WriteLine("nothing for header segment qual"); 
                }
                //is a trailer segment
                else if (trailerSplit.Contains(lineContent[0]))
                {
                    newTrailerSection = true;  
                    newHeaderSection = false;

                    if(tempBuildingDoc.TransactionSetTrailer.IsQualified(lineContent))
                        tempBuildingDoc.TransactionSetTrailer.Populate(lineContent);
                    else if (tempBuildingDoc.FunctionalGroupTrailer.IsQualified(lineContent))
                        tempBuildingDoc.FunctionalGroupTrailer.Populate(lineContent);
                    else if(tempBuildingDoc.InterchangeControlTrailer.IsQualified(lineContent))
                        tempBuildingDoc.InterchangeControlTrailer.Populate(lineContent);
                    else
                        Console.WriteLine("oops");
                }
                else //has to be in the doc def
                { 
                    newHeaderSection = false;
                    newTrailerSection = false;

                    parserState = tempBuildingDoc.ParseLineSegment(parserState, lineContent);
                }

                lineContent = sStream.ReadNextLine(tempBuildingDoc.DocDelimiters);
            }

            return retDocs;
        } 
    }
}
