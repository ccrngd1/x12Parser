using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; 
using EDI.X12.Base;
using EDI.X12.Enums;
using EDI.X12.SegmentReader;

namespace EDI.X12.Parser
{
    /// <summary>
    /// Responsible for being given a segment line and finding a segment definition to match
    /// </summary>
    internal class ParserStateMachine : ICloneable
    {
        #region backing fields
        private readonly Stack<LoopEntity> _currentLoopStack = new Stack<LoopEntity>();

        private LoopEntity _currentLoop;
        #endregion

        internal List<ParserError> Errors { get; }

        internal LoopEntity CurrentLoop
        {
            get { return _currentLoop; }
            set
            {
                if(value != null){_currentLoopStack.Push(value);}

                _currentLoop = value;
            }
        }

        private IEnumerable<LoopEntity> CurrentLoopStack => _currentLoopStack.ToList().AsReadOnly();

        internal ParserStateMachine()
        { 
            Errors = new List<ParserError>(); 
        }

        /// <summary>
        /// Member wise close function
        /// </summary>
        /// <returns>An deep clone of the object</returns>
        public object Clone()
        {
            var retVal = new ParserStateMachine();

            foreach (LoopEntity loopEntity in CurrentLoopStack)
            {
                retVal._currentLoopStack.Push(loopEntity);
            }

            foreach (ParserError parserErrors in Errors)
            {
                retVal.Errors.Add(parserErrors);
            }

            retVal.CurrentLoop = CurrentLoop;

            return retVal;
        }
    }

    /// <summary>
    /// Static parser that keeps state data contained in the ParseFile function to avoid any possible threading issues
    /// </summary>
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
                                {
                                    qualifiedSegments[0].OwningLoopCollection.Add();
                                    retVal.CurrentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last();
                                }
                                else
                                {
                                    Console.WriteLine("new loop but not a starter segment?");
                                    retVal.Errors.Add(
                                        new ParserError(
                                            "Parser found a handler, but this handler is in a new Loop and this handler is not marked as a IsLoopStarter-this could be an issue with the coded definition",
                                            X12ErrorTypes.UnknownIntendedLoop, X12ErrorLevel.Loop, retVal.CurrentLoop,
                                            lineContent));
                                }

                                //retVal.CurrentLoop = currentLoopCollection.LoopEntities.Last(); 
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
                        retVal.Errors.Add(
                            new ParserError("There were multiple handlers found, no way to determine correct state",
                                X12ErrorTypes.MultipleDefintions, X12ErrorLevel.Loop, retVal.CurrentLoop, lineContent));
                    }
                }
            }

            //if the current loop we have saved off can not handle it, we should just interogate the whole doc again
            //this may not be efficient, we may want to walk back up our stack to make it mo' betta
            if (currentLoopProcessed) return retVal;
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
                        retVal.Errors.Add(
                            new ParserError("Parser found a handler (at TopLevelLoop), but this handler is in a new Loop and this handler is not marked as a IsLoopStarter-this could be an issue with the coded definition",
                                X12ErrorTypes.UnknownIntendedLoop, X12ErrorLevel.Loop, retVal.CurrentLoop, lineContent));
                    }

                    retVal.CurrentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last(); 
                    retVal.CurrentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent)); 
                }
                else if(qualifiedSegments.Count==0)
                { 
                    retVal.Errors.Add(
                        new ParserError("We found no handlers for this segment",
                            X12ErrorTypes.NotDefined, X12ErrorLevel.Loop, retVal.CurrentLoop, lineContent));
                }
                else if (qualifiedSegments.Count > 1)
                {
                    retVal.Errors.Add(
                        new ParserError("There were multiple handlers found, no way to determine correct state",
                            X12ErrorTypes.MultipleDefintions, X12ErrorLevel.Loop, retVal.CurrentLoop, lineContent));
                }
                else
                {
                    retVal.Errors.Add(
                        new ParserError("The parse failed to find a good handler and you should never see this message",
                            X12ErrorTypes.Unknown, X12ErrorLevel.Unknown, retVal.CurrentLoop, lineContent));
                }
            }

            return retVal;
        }

        /// <summary>
        /// Given a file, parse the x12 into the hard coded defintion of a specific format T
        /// </summary>
        /// <typeparam name="T">specific format type to parse into</typeparam>
        /// <param name="fullFilePath">location of the x12 file</param>
        /// <returns>A list of X12 documents, each of which has a unique group of ISA/GS/ST/BHT, if a file has multiple of any of these, they will be rendered as a seperate X12Document</returns>
        public static IEnumerable<X12Doc> ParseFile<T>(string fullFilePath) where T:X12Doc
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

            while (lineContent != null)
            {
                //is a head segment
                if (headerSplit.Contains(lineContent[0]))
                {
                    if (!newHeaderSection)
                    {
                        //copy the errors to date into the tempBuildingDoc so we can see if there are any errors
                        tempBuildingDoc.AddParsingErrors(parserState.Errors);
                        parserState.Errors.Clear();

                        //if we just had a trailer section, then we need to create a new tempBuildingDoc to start a new X12 document
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
                    else //should never happen, but defensive
                    {
                        parserState.Errors.Add(
                            new ParserError("Header segment found no IsQualified handlers and failed to parse",
                                X12ErrorTypes.NotDefined, X12ErrorLevel.Segment, parserState.CurrentLoop, lineContent));
                    }
                }
                else if (trailerSplit.Contains(lineContent[0]))//is a trailer segment
                {
                    newTrailerSection = true;  
                    newHeaderSection = false;

                    if(tempBuildingDoc.TransactionSetTrailer.IsQualified(lineContent))
                        tempBuildingDoc.TransactionSetTrailer.Populate(lineContent);
                    else if (tempBuildingDoc.FunctionalGroupTrailer.IsQualified(lineContent))
                        tempBuildingDoc.FunctionalGroupTrailer.Populate(lineContent);
                    else if (tempBuildingDoc.InterchangeControlTrailer.IsQualified(lineContent))
                        tempBuildingDoc.InterchangeControlTrailer.Populate(lineContent);
                    else//should never happen, but defensive
                    {
                        parserState.Errors.Add(
                            new ParserError("Trailer segment found no IsQualified handlers and failed to parse",
                                X12ErrorTypes.NotDefined, X12ErrorLevel.Segment, parserState.CurrentLoop, lineContent));
                    }
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
