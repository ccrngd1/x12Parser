using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model.EDI.X12;
using Model.EDI.X12.v2.Base;

namespace Business.EDI.X12.v2
{
    public static class Parser
    {
        

        private const string HeaderSegments = "ISA,GS,ST,BHT";
        private const string TrailerSegments = "IEA,GE,SE";
        public static List<X12Doc> ParseFile<T>(string fullFilePath) where T:X12Doc
        {
            X12Doc tempBuildingDoc = (T)Activator.CreateInstance(typeof(T), args: new object[] {true}); 

            var newHeaderSection = false;
            var newTrailerSection = false;

            var retDocs = new List<X12Doc>(); 

            var sStream = new SegmentStream(File.OpenRead(fullFilePath), ref tempBuildingDoc); 

            baseFieldValues lineContent = new baseFieldValues(sStream.ReadNextLine(tempBuildingDoc.DocDelimiters));

            List<string> headerSplit = HeaderSegments.Split(',').ToList();
            List<string> trailerSplit = TrailerSegments.Split(',').ToList();

            LoopEntity currentLoop = null; //todo : should this be a stack? it would allow me to push/pop when I was moving levels...it might help for debug purposes but most likely not in the actual parsing

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

                    var currentLoopProcessed = false;
                    if (currentLoop != null)
                    {
                        List<BaseStdSegment> qualifiedSegments = currentLoop.IsQualified(lineContent, QulificationLevel.TopMost);

                        if (qualifiedSegments.Count == 1) //check just the top most, so check Loop2000A to see if we have a matching def before moving to check Loop2100A and Loop2200A
                        {
                            if (qualifiedSegments[0].IsLoopStarter)
                            {
                                currentLoop.ParentLoopCollection.Add();
                                currentLoop = currentLoop.ParentLoopCollection.LoopEntities.Last();
                            }

                            currentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                            currentLoopProcessed = true;
                        }
                        else //want to try first level sub loop
                        {

                            qualifiedSegments = currentLoop.IsQualified(lineContent, QulificationLevel.FirstChild);

                            if (qualifiedSegments.Count == 1)
                            {
                                if (qualifiedSegments[0].IsLoopStarter)
                                {
                                    //6/27 @ 6pm - remove this to get parser to create the owningCOllection correctly
                                    //currentLoop.ParentLoopCollection.Add();
                                    //currentLoop = currentLoop.ParentLoopCollection.LoopEntities.Last();

                                    qualifiedSegments[0].OwningLoopCollection.Add();
                                }

                                currentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last();
                                currentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                                currentLoopProcessed = true;
                            }

                            else if (!qualifiedSegments.Any()) //there were none
                            {
                                var currentLoopCollection = currentLoop.ParentLoopCollection;

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
                                            currentLoopCollection.Add();
                                        else
                                        {
                                            //todo: is this an error?
                                            Console.WriteLine("new loop but not a starter segment?");
                                        }

                                        currentLoop = currentLoopCollection.LoopEntities.Last();

                                        currentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                                        currentLoopProcessed = true;
                                    }
                                    else 
                                    {
                                        //this isn't unexpected...as we walk up the LoopCollection hierarchy, we may not find a match
                                        //for instance, if we are in Loop2220D, we will walk up to Loop2200D, then to Loop2000D, before trying Loop2000E which could be our match
                                        Console.Write("some parental crap");
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
                        foreach (LoopCollection loopCollection in tempBuildingDoc.TopLevelLoops)
                        {
                            qualifiedSegments.AddRange(loopCollection.IsQualified(lineContent, QulificationLevel.Recursive));
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

                            currentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last();
                            currentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                            currentLoopProcessed = true;
                        }
                        else
                        {
                            //todo how to handle these
                            Console.WriteLine("nothing found");   
                        }
                    } 
                }

                lineContent = sStream.ReadNextLine(tempBuildingDoc.DocDelimiters);
            }

            return retDocs;
        } 
    }
}
