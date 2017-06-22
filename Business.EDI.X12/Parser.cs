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
            X12Doc tempBuildingDoc = default(T);

            var newHeaderSection = false;

            var retDocs = new List<X12Doc>(); 

            var sStream = new SegmentStream(File.OpenRead(fullFilePath));

            baseFieldValues lineContent = sStream.ReadNextLine();

            List<string> headerSplit = HeaderSegments.Split(',').ToList();
            List<string> trailerSplit = TrailerSegments.Split(',').ToList();

            LoopEntity currentLoop = null;

            while (lineContent != null)
            {
                //is a head segment
                if (headerSplit.Contains(lineContent[0]))
                {
                    if (!newHeaderSection)
                    {
                        retDocs.Add(tempBuildingDoc);
                        newHeaderSection = true;
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
                    {
                        Console.WriteLine("nothing for header segment qual");
                    }
                }
                //is a trailer segment
                else if (trailerSplit.Contains(lineContent[0]))
                {
                    if (newHeaderSection)
                        newHeaderSection = false;
                    else
                    {
                        Console.WriteLine("oops trailer");
                    }
                }
                else //has to be in the doc def
                {
                    if (newHeaderSection)
                        newHeaderSection = false;

                    var currentLoopProcessed = false;
                    if (currentLoop != null)
                    {
                        List<BaseStdSegment> qualifiedSegments = currentLoop.IsQualified(lineContent, QulificationLevel.Recursive);

                        if (qualifiedSegments.Count == 1)
                        {
                            if (qualifiedSegments[0].IsLoopStarter)
                            {
                                currentLoop.ParentLoopCollection.Add();
                                currentLoop = currentLoop.ParentLoopCollection.LoopEntities.Last();
                            }

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

                                qualifiedSegments = currentLoopCollection.IsQualified(lineContent, QulificationLevel.TopMost);

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
                                    //todo: something?
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
                                Console.WriteLine("another weird ");
                            }

                            currentLoop = qualifiedSegments[0].OwningLoopCollection.LoopEntities.Last();
                            currentLoop.Add(qualifiedSegments[0].CreateBaseStdSegment(lineContent));
                            currentLoopProcessed = true;
                        }
                    }

                    //tempBuildingDoc.DocumentDefinition.IsQualified(lineContent);

                    //doc.
                }

                lineContent = sStream.ReadNextLine();
            }

            return retDocs;
        } 
    }
}
