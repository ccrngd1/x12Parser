using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Business.EDI.X12.v2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.EDI.X12.Format277.v5010.v2;
using Model.EDI.X12.v2.Base;

namespace UnitTestProject1
{
    [TestClass]
    public class x277_UnitTests
    {
        [TestMethod]
        public void TestSetupDefinitionsSingleMethod()
        {
            var test = new X12_277_5010();

            test.SetUpWholeDefinition();

            //Assert.IsNotNull(test.DocumentDefinition);
        }

        [TestMethod]
        public void Test277Parser()
        {
            var test = new X12_277_5010();

            test.SetUpWholeDefinition();

            var parsedTest = test.ParseFile(@"\\r90lmgla\c$\test files\x12\277\test277");
        }
    }
}
