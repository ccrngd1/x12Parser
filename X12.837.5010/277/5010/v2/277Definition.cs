using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2;
using System.Linq;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public class X12_277_5010:X12Doc
    {
        public X12DocDefinition DocumentDefinition;

        public readonly Loop2000ACollection InformationSourceLevelLoop = new Loop2000ACollection("Loop2000A", "InformationSourceLevelLoop");
        public readonly Loop2000BCollection InformationReiverDetail = new Loop2000BCollection("Loop2000B", "InformationReiverDetail");
        public readonly Loop2000CCollection ServiceProviderDetail = new Loop2000CCollection("Loop2000C", "ServiceProviderDetail");
        public readonly Loop2000DECollection SubscriberDetail = new Loop2000DECollection("Loop2000D", "SubscriberDetail");
        public readonly Loop2000DECollection DependentDetail = new Loop2000DECollection("Loop2000E", "DependentDetail");

        public X12_277_5010()
        {
        }

        public void SetUpDefinitionOLD()
        {
            DocumentDefinition = new X12DocDefinition();

            #region segment defs
            var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA));
            isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));
            isaDef.RequiredFields.AddRange(new[] { 1, 2 }.ToList());
            isaDef.UnusedFields.AddRange(new[] { 3, 4 }.ToList());
            isaDef.SyntaxRuleList.AddRange("123,456".Split(',').ToList());

            var stDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ST));
            stDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "277" }));

            var ieaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(IEA));

            var gsDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GS));
            gsDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "X" }));

            var geDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GE));

            var bhtDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(BHT));

            var seDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(SE));

            InterchagneControlHeader.Definition = isaDef;
            TransactionSetHeader.Definition = stDef;
            InterchangeControlTrailer.Definition = ieaDef;
            FunctionGroupHeader.Definition = gsDef;
            FunctionalGroupTrailer.Definition = geDef;
            BeginHierarchicalTransaction.Definition = bhtDef;
            TransactionSetTrailer.Definition = seDef;

            DocumentDefinition.segments.Add(isaDef);
            DocumentDefinition.segments.Add(stDef);
            DocumentDefinition.segments.Add(ieaDef);
            DocumentDefinition.segments.Add(gsDef);
            DocumentDefinition.segments.Add(geDef);
            DocumentDefinition.segments.Add(bhtDef);
            DocumentDefinition.segments.Add(seDef);
            #endregion

            #region loop defs
            DocumentDefinition.loops.Add(InformationSourceLevelLoop.Definition);
            DocumentDefinition.loops.Add(InformationReiverDetail.Definition);
            DocumentDefinition.loops.Add(ServiceProviderDetail.Definition);
            DocumentDefinition.loops.Add(SubscriberDetail.Definition);
            DocumentDefinition.loops.Add(DependentDetail.Definition);

            InformationSourceLevelLoop.SetUpDefinition(null);
            InformationSourceLevelLoop.OwningX12Doc = this;
            InformationReiverDetail.SetUpDefinition(null);
            InformationReiverDetail.OwningX12Doc = this;
            ServiceProviderDetail.SetUpDefinition(null);
            ServiceProviderDetail.OwningX12Doc = this;
            SubscriberDetail.SetUpDefinition(null);
            SubscriberDetail.OwningX12Doc = this;
            DependentDetail.SetUpDefinition(null);
            DependentDetail.OwningX12Doc = this;
            #endregion
        }

        public void SetUpWholeDefinition()
        {
            DocumentDefinition = new X12DocDefinition();
            //MainLoops
            var Loop2000ADefinition = new LoopDefinition(999);
            Loop2000ADefinition.LoopName = "2000A";
            Loop2000ADefinition.LoopDescription = "INFORMATIONSOURCELEVEL";
            DocumentDefinition.loops.Add(Loop2000ADefinition);
            var Loop2100ADefinition = new LoopDefinition(1);
            Loop2100ADefinition.LoopName = "2100A";
            Loop2100ADefinition.LoopDescription = "PAYERNAME";
            DocumentDefinition.loops.Add(Loop2100ADefinition);
            var Loop2000BDefinition = new LoopDefinition(999);
            Loop2000BDefinition.LoopName = "2000B";
            Loop2000BDefinition.LoopDescription = "INFORMATIONRECEIVERLEVEL";
            DocumentDefinition.loops.Add(Loop2000BDefinition);
            var Loop2100BDefinition = new LoopDefinition(1);
            Loop2100BDefinition.LoopName = "2100B";
            Loop2100BDefinition.LoopDescription = "INFORMATIONRECEIVERNAME";
            DocumentDefinition.loops.Add(Loop2100BDefinition);
            var Loop2200BDefinition = new LoopDefinition(1);
            Loop2200BDefinition.LoopName = "2200B";
            Loop2200BDefinition.LoopDescription = "INFORMATIONRECEIVERTRACEIDENTIFIER";
            DocumentDefinition.loops.Add(Loop2200BDefinition);

            //
            //subLoops
            var Loop2000CDefinition = new LoopDefinition(999);
            Loop2000CDefinition.LoopName = "2000C";
            Loop2000CDefinition.LoopDescription = "SERVICEPROVIDERLEVEL";
            Loop2200BDefinition.SubLoops.Add(Loop2000CDefinition);
            var Loop2100CDefinition = new LoopDefinition(999);
            Loop2100CDefinition.LoopName = "2100C";
            Loop2100CDefinition.LoopDescription = "PROVIDERNAME";
            Loop2200BDefinition.SubLoops.Add(Loop2100CDefinition);
            var Loop2200CDefinition = new LoopDefinition(1);
            Loop2200CDefinition.LoopName = "2200C";
            Loop2200CDefinition.LoopDescription = "PROVIDEROFSERVICETRACEIDENTIFIER";
            Loop2200BDefinition.SubLoops.Add(Loop2200CDefinition);
            var Loop2000DDefinition = new LoopDefinition(999);
            Loop2000DDefinition.LoopName = "2000D";
            Loop2000DDefinition.LoopDescription = "SUBSCRIBERLEVEL";
            Loop2200CDefinition.SubLoops.Add(Loop2000DDefinition);
            var Loop2100DDefinition = new LoopDefinition(1);
            Loop2100DDefinition.LoopName = "2100D";
            Loop2100DDefinition.LoopDescription = "SUBSCRIBERNAME";
            Loop2200CDefinition.SubLoops.Add(Loop2100DDefinition);
            var Loop2200DDefinition = new LoopDefinition(999);
            Loop2200DDefinition.LoopName = "2200D";
            Loop2200DDefinition.LoopDescription = "CLAIMSTATUSTRACKINGNUMBER";
            Loop2100DDefinition.SubLoops.Add(Loop2200DDefinition);
            var Loop2220DDefinition = new LoopDefinition(999);
            Loop2220DDefinition.LoopName = "2220D";
            Loop2220DDefinition.LoopDescription = "SERVICELINEINFORMATION";
            Loop2200DDefinition.SubLoops.Add(Loop2220DDefinition);
            var Loop2000EDefinition = new LoopDefinition(999);
            Loop2000EDefinition.LoopName = "2000E";
            Loop2000EDefinition.LoopDescription = "DEPENDENTLEVEL";
            Loop2200DDefinition.SubLoops.Add(Loop2000EDefinition);
            var Loop2100EDefinition = new LoopDefinition(1);
            Loop2100EDefinition.LoopName = "2100E";
            Loop2100EDefinition.LoopDescription = "DEPENDENTNAME";
            Loop2200DDefinition.SubLoops.Add(Loop2100EDefinition);
            var Loop2200EDefinition = new LoopDefinition(999);
            Loop2200EDefinition.LoopName = "2200E";
            Loop2200EDefinition.LoopDescription = "CLAIMSTATUSTRACKINGNUMBER";
            Loop2200DDefinition.SubLoops.Add(Loop2200EDefinition);
            var Loop2220EDefinition = new LoopDefinition(999);
            Loop2220EDefinition.LoopName = "2220E";
            Loop2220EDefinition.LoopDescription = "SERVICELINEINFORMATION";
            Loop2200EDefinition.SubLoops.Add(Loop2220EDefinition);

            //
            //segments
            var HL_InformationSourceLevel_Loop2000ADefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(HL));
            HL_InformationSourceLevel_Loop2000ADefinition.Qualifiers.Add(new SegmentQualifiers(1, "20".Split(',')));
            Loop2000ADefinition.LoopSegments.Add(HL_InformationSourceLevel_Loop2000ADefinition);
            var NM1_PayerName_Loop2100ADefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(NM1));
            NM1_PayerName_Loop2100ADefinition.Qualifiers.Add(new SegmentQualifiers(1, "PR".Split(',')));
            NM1_PayerName_Loop2100ADefinition.SyntaxRuleList.AddRange(" P0809,C1110,C1203 ".Split(','));
            Loop2100ADefinition.LoopSegments.Add(NM1_PayerName_Loop2100ADefinition);
            var PER_PayerContactInformation_Loop2100ADefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(PER));
            PER_PayerContactInformation_Loop2100ADefinition.Qualifiers.Add(new SegmentQualifiers(1, "IC".Split(',')));
            PER_PayerContactInformation_Loop2100ADefinition.SyntaxRuleList.AddRange(" P0304,P0506,P0708 ".Split(','));
            Loop2100ADefinition.LoopSegments.Add(PER_PayerContactInformation_Loop2100ADefinition);
            var HL_InformationReceiverLevel_Loop2000BDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(HL));
            HL_InformationReceiverLevel_Loop2000BDefinition.Qualifiers.Add(new SegmentQualifiers(1, "21".Split(',')));
            Loop2000BDefinition.LoopSegments.Add(HL_InformationReceiverLevel_Loop2000BDefinition);
            var NM1_InformationReceiverName_Loop2100BDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(NM1));
            NM1_InformationReceiverName_Loop2100BDefinition.Qualifiers.Add(new SegmentQualifiers(1, "41".Split(',')));
            NM1_InformationReceiverName_Loop2100BDefinition.SyntaxRuleList.AddRange(" P0809,C1110,C1203 ".Split(','));
            Loop2100BDefinition.LoopSegments.Add(NM1_InformationReceiverName_Loop2100BDefinition);
            var TRN_InformationReceiverTraceIdentifier_Loop2200BDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(TRN));
            TRN_InformationReceiverTraceIdentifier_Loop2200BDefinition.Qualifiers.Add(new SegmentQualifiers(1, "2".Split(',')));
            Loop2200BDefinition.LoopSegments.Add(TRN_InformationReceiverTraceIdentifier_Loop2200BDefinition);
            var STC_InformationReceiverStatusInformation_Loop2200BDefinition = new SegmentDefinition(SegmentUsageType.Required, 0, typeof(STC));
            STC_InformationReceiverStatusInformation_Loop2200BDefinition.Qualifiers.Add(new SegmentQualifiers(1, " 41,AY,PR ".Split(',')));
            Loop2200BDefinition.LoopSegments.Add(STC_InformationReceiverStatusInformation_Loop2200BDefinition);
            var HL_ServiceProviderLevel_Loop2000CDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(HL));
            HL_ServiceProviderLevel_Loop2000CDefinition.Qualifiers.Add(new SegmentQualifiers(1, "19".Split(',')));
            Loop2000CDefinition.LoopSegments.Add(HL_ServiceProviderLevel_Loop2000CDefinition);
            var NM1_ProviderName_Loop2100CDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(NM1));
            NM1_ProviderName_Loop2100CDefinition.Qualifiers.Add(new SegmentQualifiers(1, "1P".Split(',')));
            NM1_ProviderName_Loop2100CDefinition.SyntaxRuleList.AddRange(" P0809,C1110,C1203 ".Split(','));
            Loop2100CDefinition.LoopSegments.Add(NM1_ProviderName_Loop2100CDefinition);
            var TRN_ProviderofServiceTraceIdentifier_Loop2200CDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(TRN));
            TRN_ProviderofServiceTraceIdentifier_Loop2200CDefinition.Qualifiers.Add(new SegmentQualifiers(1, "1".Split(',')));
            Loop2200CDefinition.LoopSegments.Add(TRN_ProviderofServiceTraceIdentifier_Loop2200CDefinition);
            var STC_ProviderStatusInformation_Loop2200CDefinition = new SegmentDefinition(SegmentUsageType.Required, 0, typeof(STC));
            STC_ProviderStatusInformation_Loop2200CDefinition.Qualifiers.Add(new SegmentQualifiers(1, "1P".Split(',')));
            Loop2200CDefinition.LoopSegments.Add(STC_ProviderStatusInformation_Loop2200CDefinition);
            var HL_SubscriberLevel_Loop2000DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(HL));
            HL_SubscriberLevel_Loop2000DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "22".Split(',')));
            Loop2000DDefinition.LoopSegments.Add(HL_SubscriberLevel_Loop2000DDefinition);
            var NM1_SubscriberName_Loop2100DDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(NM1));
            NM1_SubscriberName_Loop2100DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "IL".Split(',')));
            NM1_SubscriberName_Loop2100DDefinition.SyntaxRuleList.AddRange(" P0809,C1110,C1203 ".Split(','));
            Loop2100DDefinition.LoopSegments.Add(NM1_SubscriberName_Loop2100DDefinition);
            var TRN_ClaimStatusTrackingNumber_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(TRN));
            TRN_ClaimStatusTrackingNumber_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "2".Split(',')));
            Loop2200DDefinition.LoopSegments.Add(TRN_ClaimStatusTrackingNumber_Loop2200DDefinition);
            var STC_ClaimLevelStatusInformation_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Required, 0, typeof(STC));
            STC_ClaimLevelStatusInformation_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, " 03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ ".Split(',')));
            Loop2200DDefinition.LoopSegments.Add(STC_ClaimLevelStatusInformation_Loop2200DDefinition);
            var REF_PayerClaimControlNumber_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_PayerClaimControlNumber_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "1K".Split(',')));
            REF_PayerClaimControlNumber_Loop2200DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200DDefinition.LoopSegments.Add(REF_PayerClaimControlNumber_Loop2200DDefinition);
            var REF_InstitutionalBillTypeIdentification_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_InstitutionalBillTypeIdentification_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "BLT".Split(',')));
            REF_InstitutionalBillTypeIdentification_Loop2200DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200DDefinition.LoopSegments.Add(REF_InstitutionalBillTypeIdentification_Loop2200DDefinition);
            var REF_PatientControlNumber_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_PatientControlNumber_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "EJ".Split(',')));
            REF_PatientControlNumber_Loop2200DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200DDefinition.LoopSegments.Add(REF_PatientControlNumber_Loop2200DDefinition);
            var REF_PharmacyPrescriptionNumber_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_PharmacyPrescriptionNumber_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "XZ".Split(',')));
            REF_PharmacyPrescriptionNumber_Loop2200DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200DDefinition.LoopSegments.Add(REF_PharmacyPrescriptionNumber_Loop2200DDefinition);
            var REF_VoucherIdentifier_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_VoucherIdentifier_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "VV".Split(',')));
            REF_VoucherIdentifier_Loop2200DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200DDefinition.LoopSegments.Add(REF_VoucherIdentifier_Loop2200DDefinition);
            var REF_ClaimIdentificationNumberForClearinghousesand_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 0, typeof(REF));
            REF_ClaimIdentificationNumberForClearinghousesand_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "D9".Split(',')));
            REF_ClaimIdentificationNumberForClearinghousesand_Loop2200DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200DDefinition.LoopSegments.Add(REF_ClaimIdentificationNumberForClearinghousesand_Loop2200DDefinition);
            var DTP_ClaimServiceDate_Loop2200DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(DTP));
            DTP_ClaimServiceDate_Loop2200DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(',')));
            Loop2200DDefinition.LoopSegments.Add(DTP_ClaimServiceDate_Loop2200DDefinition);
            var SVC_ServiceLineInformation_Loop2220DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(SVC));
            SVC_ServiceLineInformation_Loop2220DDefinition.Qualifiers.Add(new SegmentQualifiers(1, " AD,ER,HC,HP,IV,N4,NU,WK ".Split(',')));
            Loop2220DDefinition.LoopSegments.Add(SVC_ServiceLineInformation_Loop2220DDefinition);
            var STC_ServiceLineStatusInformation_Loop2220DDefinition = new SegmentDefinition(SegmentUsageType.Required, 0, typeof(STC));
            STC_ServiceLineStatusInformation_Loop2220DDefinition.Qualifiers.Add(new SegmentQualifiers(1, " 03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ ".Split(',')));
            Loop2220DDefinition.LoopSegments.Add(STC_ServiceLineStatusInformation_Loop2220DDefinition);
            var REF_ServiceLineItemIdentification_Loop2220DDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_ServiceLineItemIdentification_Loop2220DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "FJ".Split(',')));
            REF_ServiceLineItemIdentification_Loop2220DDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2220DDefinition.LoopSegments.Add(REF_ServiceLineItemIdentification_Loop2220DDefinition);
            var DTP_ServiceLineDate_Loop2220DDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(DTP));
            DTP_ServiceLineDate_Loop2220DDefinition.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(',')));
            Loop2220DDefinition.LoopSegments.Add(DTP_ServiceLineDate_Loop2220DDefinition);
            var HL_DependentLevel_Loop2000EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(HL));
            HL_DependentLevel_Loop2000EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "23".Split(',')));
            Loop2000EDefinition.LoopSegments.Add(HL_DependentLevel_Loop2000EDefinition);
            var NM1_DependentName_Loop2100EDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(NM1));
            NM1_DependentName_Loop2100EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "QC".Split(',')));
            NM1_DependentName_Loop2100EDefinition.SyntaxRuleList.AddRange(" P0809,C1110,C1203 ".Split(','));
            Loop2100EDefinition.LoopSegments.Add(NM1_DependentName_Loop2100EDefinition);
            var TRN_ClaimStatusTrackingNumber_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(TRN));
            TRN_ClaimStatusTrackingNumber_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "2".Split(',')));
            Loop2200EDefinition.LoopSegments.Add(TRN_ClaimStatusTrackingNumber_Loop2200EDefinition);
            var STC_ClaimLevelStatusInformation_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Required, 0, typeof(STC));
            STC_ClaimLevelStatusInformation_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, " 03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ ".Split(',')));
            Loop2200EDefinition.LoopSegments.Add(STC_ClaimLevelStatusInformation_Loop2200EDefinition);
            var REF_PayerClaimControlNumber_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_PayerClaimControlNumber_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "1K".Split(',')));
            REF_PayerClaimControlNumber_Loop2200EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200EDefinition.LoopSegments.Add(REF_PayerClaimControlNumber_Loop2200EDefinition);
            var REF_InstitutionalBillTypeIdentification_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_InstitutionalBillTypeIdentification_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "BLT".Split(',')));
            REF_InstitutionalBillTypeIdentification_Loop2200EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200EDefinition.LoopSegments.Add(REF_InstitutionalBillTypeIdentification_Loop2200EDefinition);
            var REF_PatientControlNumber_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_PatientControlNumber_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "EJ".Split(',')));
            REF_PatientControlNumber_Loop2200EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200EDefinition.LoopSegments.Add(REF_PatientControlNumber_Loop2200EDefinition);
            var REF_PharmacyPrescriptionNumber_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_PharmacyPrescriptionNumber_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "XZ".Split(',')));
            REF_PharmacyPrescriptionNumber_Loop2200EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200EDefinition.LoopSegments.Add(REF_PharmacyPrescriptionNumber_Loop2200EDefinition);
            var REF_VoucherIdentifier_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_VoucherIdentifier_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "VV".Split(',')));
            REF_VoucherIdentifier_Loop2200EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200EDefinition.LoopSegments.Add(REF_VoucherIdentifier_Loop2200EDefinition);
            var REF_ClaimIdentificationNumberForClearinghousesand_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 0, typeof(REF));
            REF_ClaimIdentificationNumberForClearinghousesand_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "D9".Split(',')));
            REF_ClaimIdentificationNumberForClearinghousesand_Loop2200EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2200EDefinition.LoopSegments.Add(REF_ClaimIdentificationNumberForClearinghousesand_Loop2200EDefinition);
            var DTP_ClaimServiceDate_Loop2200EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(DTP));
            DTP_ClaimServiceDate_Loop2200EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(',')));
            Loop2200EDefinition.LoopSegments.Add(DTP_ClaimServiceDate_Loop2200EDefinition);
            var SVC_ServiceLineInformation_Loop2220EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(SVC));
            SVC_ServiceLineInformation_Loop2220EDefinition.Qualifiers.Add(new SegmentQualifiers(1, " AD,ER,HC,HP,IV,N4,NU,WK ".Split(',')));
            Loop2220EDefinition.LoopSegments.Add(SVC_ServiceLineInformation_Loop2220EDefinition);
            var STC_ServiceLineStatusInformation_Loop2220EDefinition = new SegmentDefinition(SegmentUsageType.Required, 0, typeof(STC));
            STC_ServiceLineStatusInformation_Loop2220EDefinition.Qualifiers.Add(new SegmentQualifiers(1, " 03,13,17,1E,1G,1H,1I,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,28,2A,2B,2D,2E,2I,2K,2P,2Q,2S,2Z,30,36,3A,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3Y,3Z,40,43,44,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4L,4M,4N,4O,4P,4Q,4R,4S,4U,4V,4W,4X,4Y,4Z,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,61,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6R,6S,6U,6V,6W,6X,6Y,71,72,73,74,7C,80,82,84,85,87,95,CK,CZ,D2,DD,DJ,DK,DN,DO,DQ,E1,E2,E7,E9,FA,FD,FE,G0,G3,GB,GD,GI,GJ,GK,GM,GY,HF,HH,I3,IJ,IL,IN,LI,LR,MR,MSC,OB,OD,OX,P0,P2,P3,P4,P6,P7,PRP,PT,PV,PW,QA,QB,QC,QD,QE,QH,QK,QL,QN,QO,QS,QV,QY,RC,RW,S4,SEP,SJ,SU,T4,TL,TQ,TT,TTP,TU,UH,X3,X5,ZZ ".Split(',')));
            Loop2220EDefinition.LoopSegments.Add(STC_ServiceLineStatusInformation_Loop2220EDefinition);
            var REF_ServiceLineItemIdentification_Loop2220EDefinition = new SegmentDefinition(SegmentUsageType.Optional, 1, typeof(REF));
            REF_ServiceLineItemIdentification_Loop2220EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "FJ".Split(',')));
            REF_ServiceLineItemIdentification_Loop2220EDefinition.SyntaxRuleList.AddRange("R0203".Split(','));
            Loop2220EDefinition.LoopSegments.Add(REF_ServiceLineItemIdentification_Loop2220EDefinition);
            var DTP_ServiceLineDate_Loop2220EDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(DTP));
            DTP_ServiceLineDate_Loop2220EDefinition.Qualifiers.Add(new SegmentQualifiers(1, "472".Split(',')));
            Loop2220EDefinition.LoopSegments.Add(DTP_ServiceLineDate_Loop2220EDefinition);
            var SE_TransactionSetTrailer_Loop2220EDefinition = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(SE));
            Loop2220EDefinition.LoopSegments.Add(SE_TransactionSetTrailer_Loop2220EDefinition);

            //
        }



    }
}
