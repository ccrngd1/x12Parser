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
        public static X12Doc ParseFile(this X12Doc doc, string fullFilePath)
        {


            var retDoc = doc;
            var sStream = new SegmentStream(File.OpenRead(fullFilePath));

            var lineContent = sStream.ReadNextLine();

            while (lineContent != null)
            {



                lineContent = sStream.ReadNextLine();
            }

            return retDoc;
        } 
    }
}
