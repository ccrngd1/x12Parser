using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.EDI.X12.Format277.v5010.v2;

namespace UnitTestProject1
{
    [TestClass]
    public class x277_UnitTests
    {
        [TestMethod]
        public void TestSetupDefinitionsSingleMethod()
        {
            X12_277_5010 test = new X12_277_5010();

            //test.SetUpWholeDefinition();

            Assert.IsNotNull(test.DocumentDefinition);
        }
    }
}
