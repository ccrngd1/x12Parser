using System.IO; 
using CodeGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CodeGenerationTesting
    {
        [TestMethod]
        public void GenerateSegmentsV2()
        {
            V2_Generation_SegmentCollection segCollectionGenny = new V2_Generation_SegmentCollection();

            string basePath = @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\Base\v2\";

            string s = segCollectionGenny.GenerateSegmentCollections(
                basePath + "SegmentsV2.cs");

            using (var fs = new StreamWriter(basePath + "CollectionsRAWV2.cs"))
            {
                fs.Write(s);
            }
        }

        [TestMethod]
        public void GenerateRawLoopsV2( )
        {
            var gen = new X12_V2_Generation();

            X12_V2_Generation.CreateLoops(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\837 Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format837.v5010.Prof.v2");
        } 
    }
}
