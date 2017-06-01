using System.IO;
using Model.EDI.X12.v2.Base;

namespace Business.EDI.X12.v2
{
    public static class Parser
    { 
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
