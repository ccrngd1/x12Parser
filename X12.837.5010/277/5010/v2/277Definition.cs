using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2;
using System.Linq;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public class X12_277_5010:X12Doc
    {
        public readonly Loop2000ACollection InformationSourceLevelLoop = new Loop2000ACollection("Loop2000A", "InformationSourceLevelLoop");
        public readonly Loop2000BCollection InformationReiverDetail = new Loop2000BCollection("Loop2000B", "InformationReiverDetail");
        public readonly Loop2000CCollection ServiceProviderDetail = new Loop2000CCollection("Loop2000C", "ServiceProviderDetail");
        public readonly Loop2000DECollection SubscriberDetail = new Loop2000DECollection("Loop2000D", "SubscriberDetail");
        public readonly Loop2000DECollection DependentDetail = new Loop2000DECollection("Loop2000E", "DependentDetail");

        public X12_277_5010()
        {
        }

        //public void SetUpDefinitionOLD()
        //{ 

        //    #region segment defs
        //    var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA));
        //    isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));
        //    isaDef.RequiredFields.AddRange(new[] { 1, 2 }.ToList());
        //    isaDef.UnusedFields.AddRange(new[] { 3, 4 }.ToList());
        //    isaDef.SyntaxRuleList.AddRange("123,456".Split(',').ToList());

        //    var stDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ST));
        //    stDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "277" }));

        //    var ieaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(IEA));

        //    var gsDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GS));
        //    gsDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "X" }));

        //    var geDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GE));

        //    var bhtDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(BHT));

        //    var seDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(SE));

        //    InterchagneControlHeader.Definition = isaDef;
        //    TransactionSetHeader.Definition = stDef;
        //    InterchangeControlTrailer.Definition = ieaDef;
        //    FunctionGroupHeader.Definition = gsDef;
        //    FunctionalGroupTrailer.Definition = geDef;
        //    BeginHierarchicalTransaction.Definition = bhtDef;
        //    TransactionSetTrailer.Definition = seDef;

        //    DocumentDefinition.segments.Add(isaDef);
        //    DocumentDefinition.segments.Add(stDef);
        //    DocumentDefinition.segments.Add(ieaDef);
        //    DocumentDefinition.segments.Add(gsDef);
        //    DocumentDefinition.segments.Add(geDef);
        //    DocumentDefinition.segments.Add(bhtDef);
        //    DocumentDefinition.segments.Add(seDef);
        //    #endregion

        //    #region loop defs
        //    DocumentDefinition.loops.Add(InformationSourceLevelLoop.Definition);
        //    DocumentDefinition.loops.Add(InformationReiverDetail.Definition);
        //    DocumentDefinition.loops.Add(ServiceProviderDetail.Definition);
        //    DocumentDefinition.loops.Add(SubscriberDetail.Definition);
        //    DocumentDefinition.loops.Add(DependentDetail.Definition);

        //    InformationSourceLevelLoop.SetUpDefinition(null);
        //    InformationSourceLevelLoop.OwningX12Doc = this;
        //    InformationReiverDetail.SetUpDefinition(null);
        //    InformationReiverDetail.OwningX12Doc = this;
        //    ServiceProviderDetail.SetUpDefinition(null);
        //    ServiceProviderDetail.OwningX12Doc = this;
        //    SubscriberDetail.SetUpDefinition(null);
        //    SubscriberDetail.OwningX12Doc = this;
        //    DependentDetail.SetUpDefinition(null);
        //    DependentDetail.OwningX12Doc = this;
        //    #endregion
        //}


        public void SetUpWholeDefinition()
        {
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
            gsDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "HN" }));

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

            //MainLoops
            var Loop2000ADefinition = new LoopDefinition(999, InformationSourceLevelLoop);
            Loop2000ADefinition.LoopName = "2000A";
            Loop2000ADefinition.LoopDescription = "INFORMATIONSOURCELEVEL";
            DocumentDefinition.loops.Add(Loop2000ADefinition);
            var Loop2100ADefinition = new LoopDefinition(1, InformationReiverDetail);
            Loop2100ADefinition.LoopName = "2100A";
            Loop2100ADefinition.LoopDescription = "PAYERNAME";
            DocumentDefinition.loops.Add(Loop2100ADefinition); 
            
            //
            //segments
            var HL_InformationSourceLevel_Loop2000ADefinition = new SegmentDefinition(SegmentUsageType.Required, 1,  typeof(HL));
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

        }
        public void CallSetUpDefMethods()
        {
            InformationSourceLevelLoop.SetUpDefinition(null, TODO);
        }
    }
}
