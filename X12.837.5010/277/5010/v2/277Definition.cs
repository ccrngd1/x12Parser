using LawsonCS.Model.EDI.X12.v2.Base;
using LawsonCS.Model.EDI.X12.v2;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class X12_277_5010:x12Doc
    {
        public Loop2000ACollection InformationSourceLevel = new Loop2000ACollection();
        public Loop2000B loop2000b = new Loop2000B();
        public Loop2000C loop2000c = new Loop2000C();
        public Loop2000DE loop2000d = new Loop2000DE();
        public Loop2000DE loop2000e = new Loop2000DE();

        public X12_277_5010()
        {
            var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA), interchagneControlHeader);
            isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));

            var stDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ST), transactionSetHeader);
            stDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "277" }));

            var ieaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(IEA), interchangeControlTrailer);

            var gsDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GS), functionGroupHeader);
            gsDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "X" }));

            var geDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(GE), functionalGroupTrailer);

            var bhtDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(BHT), beginHierarchicalTransaction);

            var seDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(SE), transactionSetTrailer);

            interchagneControlHeader.Definition = isaDef;
            transactionSetHeader.Definition = stDef;
            interchangeControlTrailer.Definition = ieaDef;
            functionGroupHeader.Definition = gsDef;
            functionalGroupTrailer.Definition = geDef;
            beginHierarchicalTransaction.Definition = bhtDef;
            transactionSetTrailer.Definition = seDef;

            InformationSourceLevel.Definition = new LoopDefinition(999,null);
        }
    }

    public class X12_277_5010_Def : X12DocDefinition
    {
        public X12_277_5010_Def()
        {

            
        }
    }
}
