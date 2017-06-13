using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model.EDI.X12.v2.Base;

namespace Business.EDI.X12.v2
{
    public static class Parser
    {
        private const string HeaderSegments = "ISA,GS,ST,BHT";
        private const string TrailerSegments = "IEA,GE,SE";
        public static List<X12Doc> ParseFile(this X12Doc doc, string fullFilePath)
        {
            bool newHeaderSection = false;

            List<X12Doc> retDocs = new List<X12Doc>();
            X12Doc tempBuildingDoc = doc;

            var sStream = new SegmentStream(File.OpenRead(fullFilePath));

            var lineContent = sStream.ReadNextLine();

            var headerSplit = HeaderSegments.Split(',').ToList();
            var trailerSplit = TrailerSegments.Split(',').ToList();

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
                    else
                    {
                        //nothing to do, we have a few header segments
                        //this just means we are reading through all of them
                        Console.WriteLine("oops header");
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
                }

                //tempBuildingDoc.DocumentDefinition.IsQualified(lineContent);

                lineContent = sStream.ReadNextLine();
            }

            return retDocs;
        } 
    }
}
