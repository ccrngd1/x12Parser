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
                if (headerSplit.Contains(lineContent[0]))
                {
                    if (!newHeaderSection)
                    {
                        retDocs.Add(tempBuildingDoc);
                        newHeaderSection = true;
                    }
                    else
                    {
                        Console.WriteLine("oops header");
                    }
                }

                if (trailerSplit.Contains(lineContent[0]))
                {
                    if (newHeaderSection)
                        newHeaderSection = false;
                    else
                    {
                        Console.WriteLine("oops trailer");
                    }
                }


                lineContent = sStream.ReadNextLine();
            }

            return retDoc;
        } 
    }
}
