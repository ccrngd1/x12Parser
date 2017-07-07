using System.IO; 
using EDI.X12.CodeGeneration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    [TestClass]
    public class CodeGenerationTesting
    {
        [TestMethod]
        public void GenerateSegmentsV2()
        {
            var segCollectionGenny = new V2_Generation_SegmentCollection();

            var basePath = @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\Base\v2\";

            string s = segCollectionGenny.GenerateSegmentCollections_v2(basePath + "SegmentsV2_old.cs");

            using (var fs = new StreamWriter(
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\Model.EDI.X12.v2SegmentsRAWV2.cs"))
            {
                fs.Write(s);
            }
        }
    }

    [TestClass]
    public class Generate837Ps
    {

        [TestMethod]
        public void GenerateRawLoopsV2_837P()
        {
            X12_V2_Generation.CreateLoops(
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\837 Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format837.v5010.Prof.v2");
        }

        [TestMethod]
        public void GenerateRawDefinitionsV2_1_837P()
        {
            X12_V2_Generation.CreateDefinitions(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\837 Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format837.v5010.Prof.v2");
        }
    }

    [TestClass]
    public class Generate837Is
    {
        [TestMethod]
        public void GenerateRawLoopsV2_837I()
        {
            X12_V2_Generation.CreateLoops(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\837I Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format837.v5010.Inst.v2");
        }

        [TestMethod]
        public void GenerateRawDefinitionsV2_1_837I()
        {
            X12_V2_Generation.CreateDefinitions(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\837I Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format837.v5010.Inst.v2");
        }

    }


    [TestClass]
    public class Generate277
    {
        //[TestMethod]
        //public void GenerateRawLoopsV2_277()
        //{
        //    X12_V2_Generation.CreateLoops(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
        //        @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
        //        "Model.EDI.X12.Format277.v5010.v2");
        //}

        [TestMethod]
        public void GenerateRawLoopCollectionsV2_2_277()
        {
            X12_v2_2_Generation.CreateXXXLoopCollectionCSFile(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
                    @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                    "Model.EDI.X12.Format277.v5010.v2");
        }

        [TestMethod]
        public void GenerateRawLoopEntitiesV2_2_277()
        {
            X12_v2_2_Generation.CreateXXXLoopEntitiesCSFile(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format277.v5010.v2");
        }

        [TestMethod]
        public void GenerateRawValidateV2_2_277()
        {
            X12_v2_2_Generation.CreateXXXPartialValidate(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format277.v5010.v2");
        }

        [TestMethod]
        public void GenerateRawDefintionsV2_2_277()
        {
            X12_v2_2_Generation.CreateXXXPartialSetUpDef(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
                @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
                "Model.EDI.X12.Format277.v5010.v2");
        }

        //[TestMethod]
        //public void GenerateRawDefinitionsV2_1_277()
        //{
        //    X12_V2_Generation.CreateDefinitions(@"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
        //        @"C:\Users\nick.lawson\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
        //        "Model.EDI.X12.Format277.v5010.v2");
        //} 

        //[TestMethod]
        //public void GenerateRawDefinitionSingleV2_1_277()
        //{
        //    X12_V2_Generation.CreateSingleDefintion(@"C:\Users\ccrng\Google Drive\Documents\projects\x12Parser\X12.837.5010\277 Loops.txt",
        //        @"C:\Users\ccrng\Google Drive\Documents\projects\x12Parser\CodeGenerator\RAWGeneratedFiles\",
        //        "Model.EDI.X12.Format277.v5010.v2");
        //} 

    }
} 

