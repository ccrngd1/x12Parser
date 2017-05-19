﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawsonCS.Model.EDI.X12.v2.Base;

namespace LawsonCS.Model.EDI.X12.v2
{
    public class IEACollection : baseSegmentCollection { public IEACollection() : base(typeof(IEA)) { } public IEA this[int index] { get { return Segments[index] as IEA; } set { Segments[index] = value; } } }
    public class GSCollection : baseSegmentCollection { public GSCollection() : base(typeof(GS)) { } public GS this[int index] { get { return Segments[index] as GS; } set { Segments[index] = value; } } }
    public class ISACollection : baseSegmentCollection { public ISACollection() : base(typeof(ISA)) { } public ISA this[int index] { get { return Segments[index] as ISA; } set { Segments[index] = value; } } }
    public class GECollection : baseSegmentCollection { public GECollection() : base(typeof(GE)) { } public GE this[int index] { get { return Segments[index] as GE; } set { Segments[index] = value; } } }
    public class STCollection : baseSegmentCollection { public STCollection() : base(typeof(ST)) { } public ST this[int index] { get { return Segments[index] as ST; } set { Segments[index] = value; } } }
    public class BHTCollection : baseSegmentCollection { public BHTCollection() : base(typeof(BHT)) { } public BHT this[int index] { get { return Segments[index] as BHT; } set { Segments[index] = value; } } }
    public class SECollection : baseSegmentCollection { public SECollection() : base(typeof(SE)) { } public SE this[int index] { get { return Segments[index] as SE; } set { Segments[index] = value; } } }
    public class HLCollection : baseSegmentCollection { public HLCollection() : base(typeof(HL)) { } public HL this[int index] { get { return Segments[index] as HL; } set { Segments[index] = value; } } }
    public class NM1Collection : baseSegmentCollection { public NM1Collection() : base(typeof(NM1)) { } public NM1 this[int index] { get { return Segments[index] as NM1; } set { Segments[index] = value; } } }
    public class DMGCollection : baseSegmentCollection { public DMGCollection() : base(typeof(DMG)) { } public DMG this[int index] { get { return Segments[index] as DMG; } set { Segments[index] = value; } } }
    public class TRNCollection : baseSegmentCollection { public TRNCollection() : base(typeof(TRN)) { } public TRN this[int index] { get { return Segments[index] as TRN; } set { Segments[index] = value; } } }
    public class REFCollection : baseSegmentCollection { public REFCollection() : base(typeof(REF)) { } public REF this[int index] { get { return Segments[index] as REF; } set { Segments[index] = value; } } }
    public class AMTCollection : baseSegmentCollection { public AMTCollection() : base(typeof(AMT)) { } public AMT this[int index] { get { return Segments[index] as AMT; } set { Segments[index] = value; } } }
    public class DTPCollection : baseSegmentCollection { public DTPCollection() : base(typeof(DTP)) { } public DTP this[int index] { get { return Segments[index] as DTP; } set { Segments[index] = value; } } }
    public class SVCCollection : baseSegmentCollection { public SVCCollection() : base(typeof(SVC)) { } public SVC this[int index] { get { return Segments[index] as SVC; } set { Segments[index] = value; } } }
    public class STCCollection : baseSegmentCollection { public STCCollection() : base(typeof(STC)) { } public STC this[int index] { get { return Segments[index] as STC; } set { Segments[index] = value; } } }
    public class PERCollection : baseSegmentCollection { public PERCollection() : base(typeof(PER)) { } public PER this[int index] { get { return Segments[index] as PER; } set { Segments[index] = value; } } }
    public class SBRCollection : baseSegmentCollection { public SBRCollection() : base(typeof(SBR)) { } public SBR this[int index] { get { return Segments[index] as SBR; } set { Segments[index] = value; } } }
    public class PATCollection : baseSegmentCollection { public PATCollection() : base(typeof(PAT)) { } public PAT this[int index] { get { return Segments[index] as PAT; } set { Segments[index] = value; } } }
    public class N3Collection : baseSegmentCollection { public N3Collection() : base(typeof(N3)) { } public N3 this[int index] { get { return Segments[index] as N3; } set { Segments[index] = value; } } }
    public class N4Collection : baseSegmentCollection { public N4Collection() : base(typeof(N4)) { } public N4 this[int index] { get { return Segments[index] as N4; } set { Segments[index] = value; } } }
    public class CLMCollection : baseSegmentCollection { public CLMCollection() : base(typeof(CLM)) { } public CLM this[int index] { get { return Segments[index] as CLM; } set { Segments[index] = value; } } }
    public class PRVCollection : baseSegmentCollection { public PRVCollection() : base(typeof(PRV)) { } public PRV this[int index] { get { return Segments[index] as PRV; } set { Segments[index] = value; } } }
    public class CURCollection : baseSegmentCollection { public CURCollection() : base(typeof(CUR)) { } public CUR this[int index] { get { return Segments[index] as CUR; } set { Segments[index] = value; } } }
    public class PWKCollection : baseSegmentCollection { public PWKCollection() : base(typeof(PWK)) { } public PWK this[int index] { get { return Segments[index] as PWK; } set { Segments[index] = value; } } }
    public class CN1Collection : baseSegmentCollection { public CN1Collection() : base(typeof(CN1)) { } public CN1 this[int index] { get { return Segments[index] as CN1; } set { Segments[index] = value; } } }
    public class K3Collection : baseSegmentCollection { public K3Collection() : base(typeof(K3)) { } public K3 this[int index] { get { return Segments[index] as K3; } set { Segments[index] = value; } } }
    public class NTECollection : baseSegmentCollection { public NTECollection() : base(typeof(NTE)) { } public NTE this[int index] { get { return Segments[index] as NTE; } set { Segments[index] = value; } } }
    public class CR1Collection : baseSegmentCollection { public CR1Collection() : base(typeof(CR1)) { } public CR1 this[int index] { get { return Segments[index] as CR1; } set { Segments[index] = value; } } }
    public class CR2Collection : baseSegmentCollection { public CR2Collection() : base(typeof(CR2)) { } public CR2 this[int index] { get { return Segments[index] as CR2; } set { Segments[index] = value; } } }
    public class CRCCollection : baseSegmentCollection { public CRCCollection() : base(typeof(CRC)) { } public CRC this[int index] { get { return Segments[index] as CRC; } set { Segments[index] = value; } } }
    public class HICollection : baseSegmentCollection { public HICollection() : base(typeof(HI)) { } public HI this[int index] { get { return Segments[index] as HI; } set { Segments[index] = value; } } }
    public class HCPCollection : baseSegmentCollection { public HCPCollection() : base(typeof(HCP)) { } public HCP this[int index] { get { return Segments[index] as HCP; } set { Segments[index] = value; } } }
    public class CASCollection : baseSegmentCollection { public CASCollection() : base(typeof(CAS)) { } public CAS this[int index] { get { return Segments[index] as CAS; } set { Segments[index] = value; } } }
    public class OICollection : baseSegmentCollection { public OICollection() : base(typeof(OI)) { } public OI this[int index] { get { return Segments[index] as OI; } set { Segments[index] = value; } } }
    public class MOACollection : baseSegmentCollection { public MOACollection() : base(typeof(MOA)) { } public MOA this[int index] { get { return Segments[index] as MOA; } set { Segments[index] = value; } } }
    public class LXCollection : baseSegmentCollection { public LXCollection() : base(typeof(LX)) { } public LX this[int index] { get { return Segments[index] as LX; } set { Segments[index] = value; } } }
    public class SV1Collection : baseSegmentCollection { public SV1Collection() : base(typeof(SV1)) { } public SV1 this[int index] { get { return Segments[index] as SV1; } set { Segments[index] = value; } } }
    public class SV5Collection : baseSegmentCollection { public SV5Collection() : base(typeof(SV5)) { } public SV5 this[int index] { get { return Segments[index] as SV5; } set { Segments[index] = value; } } }
    public class CR3Collection : baseSegmentCollection { public CR3Collection() : base(typeof(CR3)) { } public CR3 this[int index] { get { return Segments[index] as CR3; } set { Segments[index] = value; } } }
    public class QTYCollection : baseSegmentCollection { public QTYCollection() : base(typeof(QTY)) { } public QTY this[int index] { get { return Segments[index] as QTY; } set { Segments[index] = value; } } }
    public class MEACollection : baseSegmentCollection { public MEACollection() : base(typeof(MEA)) { } public MEA this[int index] { get { return Segments[index] as MEA; } set { Segments[index] = value; } } }
    public class PS1Collection : baseSegmentCollection { public PS1Collection() : base(typeof(PS1)) { } public PS1 this[int index] { get { return Segments[index] as PS1; } set { Segments[index] = value; } } }
    public class LINCollection : baseSegmentCollection { public LINCollection() : base(typeof(LIN)) { } public LIN this[int index] { get { return Segments[index] as LIN; } set { Segments[index] = value; } } }
    public class CTPCollection : baseSegmentCollection { public CTPCollection() : base(typeof(CTP)) { } public CTP this[int index] { get { return Segments[index] as CTP; } set { Segments[index] = value; } } }
    public class SVDCollection : baseSegmentCollection { public SVDCollection() : base(typeof(SVD)) { } public SVD this[int index] { get { return Segments[index] as SVD; } set { Segments[index] = value; } } }
    public class LQCollection : baseSegmentCollection { public LQCollection() : base(typeof(LQ)) { } public LQ this[int index] { get { return Segments[index] as LQ; } set { Segments[index] = value; } } }
    public class FRMCollection : baseSegmentCollection { public FRMCollection() : base(typeof(FRM)) { } public FRM this[int index] { get { return Segments[index] as FRM; } set { Segments[index] = value; } } }

}
