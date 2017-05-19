﻿using LawsonCS.Model.EDI.X12.v2.Base;
using LawsonCS.Model.EDI.X12.v2;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class X12_277_5010:X12Doc
    {
        public Loop2000ACollection InformationSourceLevelLoop = new Loop2000ACollection();
        public Loop2000B loop2000b = new Loop2000B();
        public Loop2000C loop2000c = new Loop2000C();
        public Loop2000DE loop2000d = new Loop2000DE();
        public Loop2000DE loop2000e = new Loop2000DE();

        public X12_277_5010()
        {
            var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA), InterchagneControlHeader);
            isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));

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

            InformationSourceLevelLoop.Definition = new LoopDefinition(999,null);

            HlCollection t = this.InformationSourceLevelLoop[0].InformationSourceLevel;

            HL tt = this.InformationSourceLevelLoop[0].InformationSourceLevel[0];

            LoopEntity ttt = this.InformationSourceLevelLoop[0].InformationSourceLevel.OwningLoop;
        }
    }

    public class X12_277_5010_Def : X12DocDefinition
    {
        public X12_277_5010_Def()
        {

            
        }
    }
}
