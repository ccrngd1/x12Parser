using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using LawsonCS.Model.EDI.X12.Format277.v5010.v2;
using LawsonCS.Model.EDI.X12.v2;
using LawsonCS.Model.EDI.X12.v2.Base;

namespace UnitTestProject1
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SegmentCollection testNM1 = new SegmentCollection(typeof(NM1));
            SegmentCollection testPER = new SegmentCollection(typeof(PER));

            List<SegmentCollection> testColl =new List<SegmentCollection>();

            //testColl.Add(testNM1);

            Type tt = typeof(NM1);

            var test = Convert.ChangeType(((baseStdSegment) new NM1()),tt);

        }

        [TestMethod]
        public void SetUp277()
        {
            LawsonCS.Model.EDI.X12.Format277.v5010.v2.X12_277_5010 doc = new X12_277_5010();
        }

        [TestMethod]
        public void Check277HLLevel()
        {

            X12_277_5010 doc = new X12_277_5010();

            Loop2000ACollection tempLoopCollection = doc.InformationSourceLevelLoop;

            LoopCollection tempCastedLoopCollection = tempLoopCollection;
            LoopCollection<Loop2000A> temp = tempLoopCollection;

            Loop2000A tempLoop = doc.InformationSourceLevelLoop[0];
            LoopEntity tempCastedLoopEntity = tempLoop;

            HlCollection tempSegmentCollection = doc.InformationSourceLevelLoop[0].InformationSourceLevel;
            SegmentCollection tempCastedSegmentCollection = tempSegmentCollection;

            HL tempHLSegment = tempSegmentCollection[0];
            baseStdSegment tempCastedBaseSegment = tempHLSegment;

            Console.WriteLine(tempHLSegment.HierarchChildCode);
            Console.WriteLine(tempHLSegment.HierarchIdNumber);
            Console.WriteLine(tempHLSegment.HierarchLevelCode);
            Console.WriteLine(tempHLSegment.HierarchParentId);

        }
    }
}

