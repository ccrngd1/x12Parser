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
            baseSegmentCollection testNM1 = new baseSegmentCollection(typeof(NM1));
            baseSegmentCollection testPER = new baseSegmentCollection(typeof(PER));

            List<baseSegmentCollection> testColl =new List<baseSegmentCollection>();

            //testColl.Add(testNM1);

            Type tt = typeof(NM1);

            var test = Convert.ChangeType(((baseStdSegment) new NM1()),tt);

        }

        [TestMethod]
        public void SetUp277()
        {
            LawsonCS.Model.EDI.X12.Format277.v5010.v2.X12_277_5010 doc = new X12_277_5010();
        }
    }
}

