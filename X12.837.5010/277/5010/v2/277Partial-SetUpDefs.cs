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
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "41", "AY", "PR") },
                RequiredFileds = new List<int>() { 1, 2, 3, 6, 15, 16, 20, 21 },
                UnUsedFields = new List<int>() { 5, 7, 8, 9, 10, 11, 12, 13, 18, 23, 24 },
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
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "1P") },
                RequiredFileds = new List<int>() { 1, 2, 3, 6, 15, 16, 20, 21 },
                UnUsedFields = new List<int>() { 5, 7, 8, 9, 10, 11, 12, 13, 18, 22, 23 },
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
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "03", "13", "17", "1E", "1G", "1H", "1I", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "28", "2A", "2B", "2D", "2E", "2I", "2K", "2P", "2Q", "2S", "2Z", "30", "36", "3A", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3Y", "3Z", "40", "43", "44", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4U", "4V", "4W", "4X", "4Y", "4Z", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "61", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6U", "6V", "6W", "6X", "6Y", "71", "72", "73", "74", "7C", "80", "82", "84", "85", "87", "95", "CK", "CZ", "D2", "DD", "DJ", "DK", "DN", "DO", "DQ", "E1", "E2", "E7", "E9", "FA", "FD", "FE", "G0", "G3", "GB", "GD", "GI", "GJ", "GK", "GM", "GY", "HF", "HH", "I3", "IJ", "IL", "IN", "LI", "LR", "MR", "MSC", "OB", "OD", "OX", "P0", "P2", "P3", "P4", "P6", "P7", "PRP", "PT", "PV", "PW", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QL", "QN", "QO", "QS", "QV", "QY", "RC", "RW", "S4", "SEP", "SJ", "SU", "T4", "TL", "TQ", "TT", "TTP", "TU", "UH", "X3", "X5", "ZZ") },
                RequiredFileds = new List<int>() { 1, 2, 3, 6, 15, 19, 20 },
                UnUsedFields = new List<int>() { 7, 11, 23 },
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
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "03", "13", "17", "1E", "1G", "1H", "1I", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "28", "2A", "2B", "2D", "2E", "2I", "2K", "2P", "2Q", "2S", "2Z", "30", "36", "3A", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3Y", "3Z", "40", "43", "44", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4U", "4V", "4W", "4X", "4Y", "4Z", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "61", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6U", "6V", "6W", "6X", "6Y", "71", "72", "73", "74", "7C", "80", "82", "84", "85", "87", "95", "CK", "CZ", "D2", "DD", "DJ", "DK", "DN", "DO", "DQ", "E1", "E2", "E7", "E9", "FA", "FD", "FE", "G0", "G3", "GB", "GD", "GI", "GJ", "GK", "GM", "GY", "HF", "HH", "I3", "IJ", "IL", "IN", "LI", "LR", "MR", "MSC", "OB", "OD", "OX", "P0", "P2", "P3", "P4", "P6", "P7", "PRP", "PT", "PV", "PW", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QL", "QN", "QO", "QS", "QV", "QY", "RC", "RW", "S4", "SEP", "SJ", "SU", "T4", "TL", "TQ", "TT", "TTP", "TU", "UH", "X3", "X5", "ZZ") },
                RequiredFileds = new List<int>() { 1, 2, 3, 6, 15, 16, 20, 21 },
                UnUsedFields = new List<int>() { 7, 8, 9, 10, 11, 12, 13, 24 },
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
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "03", "13", "17", "1E", "1G", "1H", "1I", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "28", "2A", "2B", "2D", "2E", "2I", "2K", "2P", "2Q", "2S", "2Z", "30", "36", "3A", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3Y", "3Z", "40", "43", "44", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4U", "4V", "4W", "4X", "4Y", "4Z", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "61", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6U", "6V", "6W", "6X", "6Y", "71", "72", "73", "74", "7C", "80", "82", "84", "85", "87", "95", "CK", "CZ", "D2", "DD", "DJ", "DK", "DN", "DO", "DQ", "E1", "E2", "E7", "E9", "FA", "FD", "FE", "G0", "G3", "GB", "GD", "GI", "GJ", "GK", "GM", "GY", "HF", "HH", "I3", "IJ", "IL", "IN", "LI", "LR", "MR", "MSC", "OB", "OD", "OX", "P0", "P2", "P3", "P4", "P6", "P7", "PRP", "PT", "PV", "PW", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QL", "QN", "QO", "QS", "QV", "QY", "RC", "RW", "S4", "SEP", "SJ", "SU", "T4", "TL", "TQ", "TT", "TTP", "TU", "UH", "X3", "X5", "ZZ") },
                RequiredFileds = new List<int>() { 1, 2, 3, 6, 15, 19, 20 },
                UnUsedFields = new List<int>() { 7, 11, 23 },
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
                SegmentQualifierValues = new List<SegmentQualifiers>() { new SegmentQualifiers(1, "03", "13", "17", "1E", "1G", "1H", "1I", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "28", "2A", "2B", "2D", "2E", "2I", "2K", "2P", "2Q", "2S", "2Z", "30", "36", "3A", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3Y", "3Z", "40", "43", "44", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4U", "4V", "4W", "4X", "4Y", "4Z", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "61", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6U", "6V", "6W", "6X", "6Y", "71", "72", "73", "74", "7C", "80", "82", "84", "85", "87", "95", "CK", "CZ", "D2", "DD", "DJ", "DK", "DN", "DO", "DQ", "E1", "E2", "E7", "E9", "FA", "FD", "FE", "G0", "G3", "GB", "GD", "GI", "GJ", "GK", "GM", "GY", "HF", "HH", "I3", "IJ", "IL", "IN", "LI", "LR", "MR", "MSC", "OB", "OD", "OX", "P0", "P2", "P3", "P4", "P6", "P7", "PRP", "PT", "PV", "PW", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QL", "QN", "QO", "QS", "QV", "QY", "RC", "RW", "S4", "SEP", "SJ", "SU", "T4", "TL", "TQ", "TT", "TTP", "TU", "UH", "X3", "X5", "ZZ") },
                RequiredFileds = new List<int>() { 1, 2, 3, 6, 15, 16, 20, 21 },
                UnUsedFields = new List<int>() { 7, 8, 9, 10, 11, 12, 13, 24 },
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