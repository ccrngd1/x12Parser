using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
//using Model.EDI.X12.Format277.v5010.v2;
using Model.EDI.X12.v2;
using Model.EDI.X12.v2.Base;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SegmentCollection testNM1 = new Nm1Collection(null, null);
            SegmentCollection testPER = new PerCollection(null, null);

            List<SegmentCollection> testColl =new List<SegmentCollection>();

            //testColl.Add(testNM1);

            Type tt = typeof(NM1);

            var test = Convert.ChangeType(((BaseStdSegment) new NM1()),tt);

        }

        [TestMethod]
        public void SetUp277()
        {
            //Model.EDI.X12.Format277.v5010.v2.X12_277_5010 doc = new X12_277_5010(true);
        }

        [TestMethod]
        public void Check277HLLevel()
        {

            //X12_277_5010 doc = new X12_277_5010(true);

            //Loop2000ACollection tempLoopCollection = doc.InformationSourceLevelLoop;

            //LoopCollection tempCastedLoopCollection = tempLoopCollection;
            //LoopCollection<Loop2000A> temp = tempLoopCollection;

            //Loop2000A tempLoop = doc.InformationSourceLevelLoop[0];
            //LoopEntity tempCastedLoopEntity = tempLoop;

            //HlCollection tempSegmentCollection = doc.InformationSourceLevelLoop[0].InformationSourceLevel;
            //SegmentCollection tempCastedSegmentCollection = tempSegmentCollection;

            //HL tempHLSegment = tempSegmentCollection[0];
            //BaseStdSegment tempCastedBaseSegment = tempHLSegment;

            //Console.WriteLine(tempHLSegment.HierarchChildCode);
            //Console.WriteLine(tempHLSegment.HierarchIdNumber);
            //Console.WriteLine(tempHLSegment.HierarchLevelCode);
            //Console.WriteLine(tempHLSegment.HierarchParentId);

        }
    }
}

