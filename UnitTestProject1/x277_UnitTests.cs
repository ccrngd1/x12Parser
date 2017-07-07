using System.Collections.Generic;
using EDI.X12.Base;
using EDI.X12.Format277.v5010;
using EDI.X12.Parser;
using EDI.X12.Segments; 
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace UnitTestProject1
{
    [TestClass]
    public class X277UnitTests
    {
        [TestMethod]
        public void TestSetupDefinitionsSingleMethod()
        {
            var test = new X12_277_5010(true);
            var test2 = new X12_277_5010();


        }

        [TestMethod]
        public void Test277Parser()
        {
            IEnumerable<X12Doc> parsedTest = Parser.ParseFile<X12_277_5010>(@"\\r90lmgla\c$\test files\x12\277\test277");
        }

        [TestMethod]
        public void Manual277Parsing()
        {
            
            var new277File = new X12_277_5010();
            new277File.InterchagneControlHeader = new ISA(); 

            //new277File.InformationSourceLevelLoop.cl

            new277File.InterchagneControlHeader.AuthInformationQualifier = "00";
            new277File.InterchagneControlHeader.AuthorizationInformation = "          ";
            new277File.InterchagneControlHeader.SecurityInformation = "00";
            new277File.InterchagneControlHeader.SecurityInformation = "          ";
            new277File.InterchagneControlHeader.InterchangeIDQualifier = "ZZ";
            new277File.InterchagneControlHeader.InterchangeSenderID = "204202692      ";
            new277File.InterchagneControlHeader.InterchangeIDQualifier_2 = "ZZ";
            new277File.InterchagneControlHeader.InterchangeReceiverID = "4000036        ";
            new277File.InterchagneControlHeader.InterchangeDate = "170530";
            new277File.InterchagneControlHeader.InterchangeTime = "1218";
            new277File.InterchagneControlHeader.RepetitionSeparator = "}";
            new277File.InterchagneControlHeader.InterchangeControlVersion = "00501";
            new277File.InterchagneControlHeader.InterchangeControlNo = "427901684";
            new277File.InterchagneControlHeader.AcknowledgmentRequested = "0";
            new277File.InterchagneControlHeader.UsageIndicator = "P";
            new277File.InterchagneControlHeader.ComponentElementSeparator = ":";

            new277File.FunctionGroupHeader = new GS(); // Functional

            new277File.FunctionGroupHeader.FunctionalIdCode = "HN";
            new277File.FunctionGroupHeader.ApplicaitonSendsCode = "204202692"; // applicationSendersCode 
            new277File.FunctionGroupHeader.ApplicationRecsCode = "4000036";
            new277File.FunctionGroupHeader.Date = "20170530";
            new277File.FunctionGroupHeader.Time = "121811";
            new277File.FunctionGroupHeader.GroupCtrlNumber = "1";
            new277File.FunctionGroupHeader.ResponsibleAgencyCode = "X";
            new277File.FunctionGroupHeader.VerReleaseIdCode = "005010X212";

            new277File.TransactionSetHeader = new ST();

            new277File.TransactionSetHeader.TransactionSetId = "277";
            new277File.TransactionSetHeader.TransactionSetControlNum = "0001";
            new277File.TransactionSetHeader.ImplementationConvRef = "005010X212";

            new277File.BeginHierarchicalTransaction = new BHT();

            new277File.BeginHierarchicalTransaction.StructureCode = "0010";
            new277File.BeginHierarchicalTransaction.TransactionSetPurposeCode = "08";
            new277File.BeginHierarchicalTransaction.RefId = "138248032";
            new277File.BeginHierarchicalTransaction.Date = "20170530";
            new277File.BeginHierarchicalTransaction.Time = "1218111";
            new277File.BeginHierarchicalTransaction.TransactionTypeCode = "DG";

            new277File.InformationSourceLevelLoop.Add();
            new277File.InformationSourceLevelLoop[0].InformationSourceLevel.Add(new HL());
            new277File.InformationSourceLevelLoop[0].InformationSourceLevel[0].HierarchIdNumber = "1";
            new277File.InformationSourceLevelLoop[0].InformationSourceLevel[0].HierarchLevelCode = "20";
            new277File.InformationSourceLevelLoop[0].InformationSourceLevel[0].HierarchChildCode = "1";

            new277File.InformationSourceLevelLoop[0].PayerNameLoop.Add();
            new277File.InformationSourceLevelLoop[0].PayerNameLoop[0].PayerName[0].EntityIdCode = "PR";
            new277File.InformationSourceLevelLoop[0].PayerNameLoop[0].PayerName[0].EntityTypeQualifier = "2";
            new277File.InformationSourceLevelLoop[0].PayerNameLoop[0].PayerName[0].LastNameOrgName = "BCBSF";
            new277File.InformationSourceLevelLoop[0].PayerNameLoop[0].PayerName[0].IdCodeQualifier = "PI";
            new277File.InformationSourceLevelLoop[0].PayerNameLoop[0].PayerName[0].IdCode = "10031";
            new277File.InformationSourceLevelLoop[0].PayerNameLoop[0].PayerContactInformation[0].CommNumber = "";

            //PER new277File.InformationSourceLevelLoop[0].PayerName[0].InformationSourceName[0].

            new277File.InformationReiverDetailLoop.Add(); //Reiver = Receiver ?why not RecieverDetailLoop?

            new277File.InformationReiverDetailLoop[0].InformationReceiverLevel[0].HierarchIdNumber = "2";
            new277File.InformationReiverDetailLoop[0].InformationReceiverLevel[0].HierarchParentId = "1";
            new277File.InformationReiverDetailLoop[0].InformationReceiverLevel[0].HierarchLevelCode = "21";
            new277File.InformationReiverDetailLoop[0].InformationReceiverLevel[0].HierarchChildCode = "1";

            //new277File.InformationReiverDetail.Add(new Objects.Transactions.X12.Alt._5010.Loop2100BCollection()); 

            new277File.InformationReiverDetailLoop.Add();
            new277File.InformationReiverDetailLoop[0].InformationRecieverNameLoop.Add();
            new277File.InformationReiverDetailLoop[0].InformationRecieverNameLoop[0].InformationReceiverName[0].EntityIdCode = "41";
            new277File.InformationReiverDetailLoop[0].InformationRecieverNameLoop[0].InformationReceiverName[0].EntityTypeQualifier = "2";
            new277File.InformationReiverDetailLoop[0].InformationRecieverNameLoop[0].InformationReceiverName[0].LastNameOrgName = "Company INC";
            new277File.InformationReiverDetailLoop[0].InformationRecieverNameLoop[0].InformationReceiverName[0].LastNameOrgName = "46";
            new277File.InformationReiverDetailLoop[0].InformationRecieverNameLoop[0].InformationReceiverName[0].IdCode = "611340767";

            new277File.ServiceProviderDetailLoop.Add();
            new277File.ServiceProviderDetailLoop[0].ServiceProviderLevel[0].HierarchIdNumber = "3";
            new277File.ServiceProviderDetailLoop[0].ServiceProviderLevel[0].HierarchParentId = "2";
            new277File.ServiceProviderDetailLoop[0].ServiceProviderLevel[0].HierarchLevelCode = "19";
            new277File.ServiceProviderDetailLoop[0].ServiceProviderLevel[0].HierarchChildCode = "1";

            //new277File.ServiceProviderDetail.Add(new Objects.Transactions.X12.Alt._5010.Loop2100C());
            new277File.ServiceProviderDetailLoop.Add();
            new277File.ServiceProviderDetailLoop[0].ProviderNameLoop.Add();
            new277File.ServiceProviderDetailLoop[0].ProviderNameLoop[0].ProviderName[0].EntityIdCode = "1P";
            new277File.ServiceProviderDetailLoop[0].ProviderNameLoop[0].ProviderName[0].EntityTypeQualifier = "2";
            new277File.ServiceProviderDetailLoop[0].ProviderNameLoop[0].ProviderName[0].LastNameOrgName = "LABORATORY TESTING INC";
            new277File.ServiceProviderDetailLoop[0].ProviderNameLoop[0].ProviderName[0].IdCodeQualifier = "XX";
            new277File.ServiceProviderDetailLoop[0].ProviderNameLoop[0].ProviderName[0].IdCode = "1003222605";

            new277File.SubscriberDetailLoop.Add();
            new277File.SubscriberDetailLoop[0].SubscriberLevel[0].HierarchIdNumber = "4";
            new277File.SubscriberDetailLoop[0].SubscriberLevel[0].HierarchParentId = "3";
            new277File.SubscriberDetailLoop[0].SubscriberLevel[0].HierarchLevelCode = "22";
            new277File.SubscriberDetailLoop[0].SubscriberLevel[0].HierarchChildCode = "0";

            //new277File.DependentDetailLoop.Add(new Objects.Transactions.X12.Alt._5010.Loop2100DE());
            new277File.DependentDetailLoop.Add();
            new277File.DependentDetailLoop[0].DependentNameLoop.Add();
            new277File.DependentDetailLoop[0].DependentNameLoop[0].DependentName[0].EntityIdCode = "IL";
            new277File.DependentDetailLoop[0].DependentNameLoop[0].DependentName[0].EntityTypeQualifier = "1";
            new277File.DependentDetailLoop[0].DependentNameLoop[0].DependentName[0].LastNameOrgName = "SMITH";
            new277File.DependentDetailLoop[0].DependentNameLoop[0].DependentName[0].FirstName = "JOHN";
            new277File.DependentDetailLoop[0].DependentNameLoop[0].DependentName[0].IdCodeQualifier = "MI";
            new277File.DependentDetailLoop[0].DependentNameLoop[0].DependentName[0].IdCode = "ADM842956140"; 
        }
    }
}
