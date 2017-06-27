using System.Collections.Generic; 
using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2; 

namespace Model.EDI.X12.Format277.v5010.v2
{


    public partial class Loop2000ACollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new HL()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "InformationSourceLevel",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(3, "20") },
                RequiredFileds = new List<int>() { 1, 3, 4 },
                UnUsedFields = new List<int>() { 2 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2100ACollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 1;
            SegmentDefinitions.Add(new NM1()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "PayerName",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "PR") },
                SyntaxRules = new List<string>() { "P0809", "C1110", "C1203" },
                RequiredFileds = new List<int>() { 1, 2, 3, 8, 9 },
                UnUsedFields = new List<int>() { 4, 5, 6, 7, 10, 11, 12 },
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new PER()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PayerContactInformation",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "IC") },
                SyntaxRules = new List<string>() { "P0304", "P0506", "P0708" },
                RequiredFileds = new List<int>() { 1, 3, 4 },
                UnUsedFields = new List<int>() { 9 },
                Usage = SegmentUsageType.Optional
            });
        }
    }
    public partial class Loop2000BCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new HL()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "InformationReceiverLevel",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(3, "21") },
                RequiredFileds = new List<int>() { 1, 2, 3, 4 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2100BCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 1;
            SegmentDefinitions.Add(new NM1()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "InformationReceiverName",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "41") },
                SyntaxRules = new List<string>() { "P0809", "C1110", "C1203" },
                RequiredFileds = new List<int>() { 1, 2, 8, 9 },
                UnUsedFields = new List<int>() { 6, 7, 10, 11, 12 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2200BCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 1;
            SegmentDefinitions.Add(new TRN()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "InformationReceiverTraceIdentifier",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "2") },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new STC()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "InformationReceiverStatusInformation",
                RequiredFileds = new List<int>() { 1 },
                UnUsedFields = new List<int>() { 3,4,5,6,7,8,9,12 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2000CCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new HL()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ServiceProviderLevel",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(3, "19") },
                RequiredFileds = new List<int>() { 1, 2, 3, 4 },
                Usage = SegmentUsageType.Optional
            });
        }
    }
    public partial class Loop2100CCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 2;
            SegmentDefinitions.Add(new NM1()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ProviderName",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "1P") },
                SyntaxRules = new List<string>() { "P0809", "C1110", "C1203" },
                RequiredFileds = new List<int>() { 1, 2, 8, 9 },
                UnUsedFields = new List<int>() { 6, 10, 11, 12 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2200CCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 1;
            SegmentDefinitions.Add(new TRN()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ProviderOfServiceTraceIdentifier",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "1") },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new STC()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ProviderStatusInformation",
                RequiredFileds = new List<int>() { 1 },
                UnUsedFields = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 12 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2000DCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new HL()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "SubscriberLevel",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(3, "22") },
                RequiredFileds = new List<int>() { 1, 2, 3, 4 },
                Usage = SegmentUsageType.Optional
            });
        }
    }
    public partial class Loop2100DCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 1;
            SegmentDefinitions.Add(new NM1()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "SubscriberName",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "IL") },
                SyntaxRules = new List<string>() { "P0809", "C1110", "C1203" },
                RequiredFileds = new List<int>() { 1, 2, 3, 8, 9 },
                UnUsedFields = new List<int>() { 6, 10, 11, 12 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2200DCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new TRN()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ClaimStatusTrackingNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "2") },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new STC()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ClaimLevelStatusInformation",
                RequiredFileds = new List<int>() { 1  },
                UnUsedFields = new List<int>() { 3,4,12},
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PayerClaimControlNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "1K") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "InstitutionalBillTypeIdentification",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "BLT") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PatientControlNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "EJ") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PharmacyPrescriptionNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "XZ") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "VoucherIdentifier",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "VV") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ClaimIdentificationNumberForClearinghousesAnd",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "D9") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new DTP()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ClaimServiceDate",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "472") },
                RequiredFileds = new List<int>() { 1, 2, 3 },
                Usage = SegmentUsageType.Optional
            });
        }
    }
    public partial class Loop2220DCollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new SVC()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ServiceLineInformation",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "AD", "ER", "HC", "HP", "IV", "N4", "NU", "WK") },
                RequiredFileds = new List<int>() { 1, 2, 3, 10, 11, 15 },
                UnUsedFields = new List<int>() { 8, 9, 13, 14 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new STC()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ServiceLineStatusInformation",
                RequiredFileds = new List<int>() { 1  },
                UnUsedFields = new List<int>() {3,4,5,6,7,8,9,12},
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ServiceLineItemIdentification",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "FJ") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new DTP()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ServiceLineDate",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "472") },
                RequiredFileds = new List<int>() { 1, 2, 3 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2000ECollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new HL()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "DependentLevel",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(3, "23") },
                RequiredFileds = new List<int>() { 1, 2, 3 },
                UnUsedFields = new List<int>() { 4 },
                Usage = SegmentUsageType.Optional
            });
        }
    }
    public partial class Loop2100ECollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 1;
            SegmentDefinitions.Add(new NM1()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "DependentName",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "QC") },
                SyntaxRules = new List<string>() { "P0809", "C1110", "C1203" },
                RequiredFileds = new List<int>() { 1, 2, 3 },
                UnUsedFields = new List<int>() { 6, 8, 9, 10, 11, 12 },
                Usage = SegmentUsageType.Required
            });
        }
    }
    public partial class Loop2200ECollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new TRN()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ClaimStatusTrackingNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "2") },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new STC()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ClaimLevelStatusInformation",
                RequiredFileds = new List<int>() { 1  },
                UnUsedFields = new List<int>() { 3,4,12 },
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PayerClaimControlNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "1K") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "InstitutionalBillTypeIdentification",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "BLT") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PatientControlNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "EJ") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "PharmacyPrescriptionNumber",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "XZ") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "VoucherIdentifier",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "VV") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ClaimIdentificationNumberForClearinghousesAnd",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "D9") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new DTP()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ClaimServiceDate",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "472") },
                RequiredFileds = new List<int>() { 1, 2, 3 },
                Usage = SegmentUsageType.Optional
            });
        }
    }
    public partial class Loop2220ECollection
    {
        public override void SetUpDefinition()
        {
            SetUpChildDefinitions = true;
            RepitionLimit = 999;
            SegmentDefinitions.Add(new SVC()
            {
                OwningLoopCollection = this,
                IsLoopStarter = true,
                SegmentDefinitionName = "ServiceLineInformation",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "AD", "ER", "HC", "HP", "IV", "N4", "NU", "WK") },
                RequiredFileds = new List<int>() { 1, 2, 3, 10, 11, 15 },
                UnUsedFields = new List<int>() { 8, 9, 13, 14 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new STC()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ServiceLineStatusInformation",
                RequiredFileds = new List<int>() { 1 },
                UnUsedFields = new List<int>() { 3,4,5,6,7,8,9,12},
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new REF()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ServiceLineItemIdentification",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "FJ") },
                SyntaxRules = new List<string>() { "R0203" },
                RequiredFileds = new List<int>() { 1, 2 },
                UnUsedFields = new List<int>() { 3, 4 },
                Usage = SegmentUsageType.Optional
            });
            SegmentDefinitions.Add(new DTP()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "ServiceLineDate",
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "472") },
                RequiredFileds = new List<int>() { 1, 2, 3 },
                Usage = SegmentUsageType.Required
            });
            SegmentDefinitions.Add(new SE()
            {
                OwningLoopCollection = this,
                SegmentDefinitionName = "TransactionSetTrailer",
                RequiredFileds = new List<int>() { 1, 2 },
                Usage = SegmentUsageType.Required
            });
        }
    }


}