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

        public void SetUpDefinition()
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





    } 
}
