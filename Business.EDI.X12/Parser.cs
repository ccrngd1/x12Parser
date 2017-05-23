using System.IO;
using Model.EDI.X12.v2.Base;

namespace Business.EDI.X12.v2
{
    public class Parser
    {
        public Parser() { }

        public void ParseFile(ref X12Doc doc, string fullFilePath)
        {
            var sStream = new SegmentStream(File.OpenRead(fullFilePath));

            var lineContent = sStream.ReadNextLine();

            while (lineContent != null)
            {



                lineContent = sStream.ReadNextLine();
            }
        }
    }
}
