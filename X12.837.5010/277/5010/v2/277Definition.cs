using Model.EDI.X12.v2.Base;
using Model.EDI.X12.v2;
using System.Linq;

namespace Model.EDI.X12.Format277.v5010.v2
{
    public class X12_277_5010:X12Doc
    {
        public X12DocDefinition DocumentDefinition;

        public Loop2000ACollection InformationSourceLevelLoop = new Loop2000ACollection();
        public Loop2000BCollection InformationReiverDetail = new Loop2000BCollection();
        public Loop2000CCollection ServiceProviderDetail = new Loop2000CCollection();
        public Loop2000DECollection SubscriberDetail = new Loop2000DECollection();
        public Loop2000DECollection DependentDetail = new Loop2000DECollection();

        public X12_277_5010()
        {
            var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA), InterchagneControlHeader);
            isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));
            isaDef.RequiredFields.AddRange(new[] { 1, 2 }.ToList());
            isaDef.UnusedFields.AddRange(new[] { 3, 4 }.ToList());
            isaDef.SyntaxRuleList.AddRange("123,456".Split(',').ToList());

            var stDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ST), TransactionSetHeader);
            stDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "277" }));

            var ieaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(IEA), InterchangeControlTrailer);

            var gsDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GS), FunctionGroupHeader);
            gsDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "X" }));

            var geDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GE), FunctionalGroupTrailer);

            var bhtDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(BHT), BeginHierarchicalTransaction);

            var seDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(SE), TransactionSetTrailer);

            InterchagneControlHeader.Definition = isaDef;
            TransactionSetHeader.Definition = stDef;
            InterchangeControlTrailer.Definition = ieaDef;
            FunctionGroupHeader.Definition = gsDef;
            FunctionalGroupTrailer.Definition = geDef;
            BeginHierarchicalTransaction.Definition = bhtDef;
            TransactionSetTrailer.Definition = seDef;

            InformationSourceLevelLoop.Definition = new LoopDefinition(999);
            InformationReiverDetail.Definition = new LoopDefinition(999);
            ServiceProviderDetail.Definition = new LoopDefinition(999);
            SubscriberDetail.Definition = new LoopDefinition(999);
            DependentDetail.Definition = new LoopDefinition(999);

            DocumentDefinition.segments.Add(isaDef);
            DocumentDefinition.segments.Add(stDef);
            DocumentDefinition.segments.Add(ieaDef);
            DocumentDefinition.segments.Add(gsDef);
            DocumentDefinition.segments.Add(geDef);
            DocumentDefinition.segments.Add(bhtDef);
            DocumentDefinition.segments.Add(seDef);

            DocumentDefinition.loops.Add(InformationSourceLevelLoop.Definition);
            DocumentDefinition.loops.Add(InformationReiverDetail.Definition);
            DocumentDefinition.loops.Add(ServiceProviderDetail.Definition);
            DocumentDefinition.loops.Add(SubscriberDetail.Definition);
            DocumentDefinition.loops.Add(DependentDetail.Definition);
        }
    }

    public class X12_277_5010_Def : X12DocDefinition
    {
        public X12_277_5010_Def()
        {
            var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA), null);
            isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));

            var stDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ST), null);
            stDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "277" }));

            var ieaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(IEA), null);

            var gsDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GS), null);
            gsDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "X" }));

            var geDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GE), null);

            var bhtDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(BHT), null);

            var seDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(SE), null);

            base.segments.Add(isaDef);
            base.segments.Add(stDef);
            base.segments.Add(ieaDef);
            base.segments.Add(gsDef);
            base.segments.Add(geDef);
            base.segments.Add(bhtDef);
            base.segments.Add(seDef);

            var loop2000ADef = new LoopDefinition(999);
            var loop2000BDef = new 
        }
    }
}
