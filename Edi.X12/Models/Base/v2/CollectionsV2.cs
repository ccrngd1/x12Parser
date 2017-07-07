﻿using EDI.X12.Base;

namespace EDI.X12.Segments.Collections
{
    public class IeaCollection : SegmentCollection { public IeaCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public IEA this[int index] { get { return Segments[index] as IEA; } set { Segments[index] = value; } } }
    public class GsCollection : SegmentCollection { public GsCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public GS this[int index] { get { return Segments[index] as GS; } set { Segments[index] = value; } } }
    public class IsaCollection : SegmentCollection { public IsaCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public ISA this[int index] { get { return Segments[index] as ISA; } set { Segments[index] = value; } } }
    public class GeCollection : SegmentCollection { public GeCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public GE this[int index] { get { return Segments[index] as GE; } set { Segments[index] = value; } } }
    public class StCollection : SegmentCollection { public StCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public ST this[int index] { get { return Segments[index] as ST; } set { Segments[index] = value; } } }
    public class BhtCollection : SegmentCollection { public BhtCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public BHT this[int index] { get { return Segments[index] as BHT; } set { Segments[index] = value; } } }
    public class SeCollection : SegmentCollection { public SeCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public SE this[int index] { get { return Segments[index] as SE; } set { Segments[index] = value; } } }
    public class HlCollection : SegmentCollection { public HlCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public HL this[int index] { get { return Segments[index] as HL; } set { Segments[index] = value; } } }
    public class Nm1Collection : SegmentCollection { public Nm1Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public NM1 this[int index] { get { return Segments[index] as NM1; } set { Segments[index] = value; } } }
    public class DmgCollection : SegmentCollection { public DmgCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public DMG this[int index] { get { return Segments[index] as DMG; } set { Segments[index] = value; } } }
    public class TrnCollection : SegmentCollection { public TrnCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public TRN this[int index] { get { return Segments[index] as TRN; } set { Segments[index] = value; } } }
    public class RefCollection : SegmentCollection { public RefCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public REF this[int index] { get { return Segments[index] as REF; } set { Segments[index] = value; } } }
    public class AmtCollection : SegmentCollection { public AmtCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public AMT this[int index] { get { return Segments[index] as AMT; } set { Segments[index] = value; } } }
    public class DtpCollection : SegmentCollection { public DtpCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public DTP this[int index] { get { return Segments[index] as DTP; } set { Segments[index] = value; } } }
    public class SvcCollection : SegmentCollection { public SvcCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public SVC this[int index] { get { return Segments[index] as SVC; } set { Segments[index] = value; } } }
    public class StcCollection : SegmentCollection { public StcCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public STC this[int index] { get { return Segments[index] as STC; } set { Segments[index] = value; } } }
    public class PerCollection : SegmentCollection { public PerCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public PER this[int index] { get { return Segments[index] as PER; } set { Segments[index] = value; } } }
    public class SbrCollection : SegmentCollection { public SbrCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public SBR this[int index] { get { return Segments[index] as SBR; } set { Segments[index] = value; } } }
    public class PatCollection : SegmentCollection { public PatCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public PAT this[int index] { get { return Segments[index] as PAT; } set { Segments[index] = value; } } }
    public class N3Collection : SegmentCollection { public N3Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public N3 this[int index] { get { return Segments[index] as N3; } set { Segments[index] = value; } } }
    public class N4Collection : SegmentCollection { public N4Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public N4 this[int index] { get { return Segments[index] as N4; } set { Segments[index] = value; } } }
    public class ClmCollection : SegmentCollection { public ClmCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CLM this[int index] { get { return Segments[index] as CLM; } set { Segments[index] = value; } } }
    public class PrvCollection : SegmentCollection { public PrvCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public PRV this[int index] { get { return Segments[index] as PRV; } set { Segments[index] = value; } } }
    public class CurCollection : SegmentCollection { public CurCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CUR this[int index] { get { return Segments[index] as CUR; } set { Segments[index] = value; } } }
    public class PwkCollection : SegmentCollection { public PwkCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public PWK this[int index] { get { return Segments[index] as PWK; } set { Segments[index] = value; } } }
    public class Cn1Collection : SegmentCollection { public Cn1Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CN1 this[int index] { get { return Segments[index] as CN1; } set { Segments[index] = value; } } }
    public class K3Collection : SegmentCollection { public K3Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public K3 this[int index] { get { return Segments[index] as K3; } set { Segments[index] = value; } } }
    public class NteCollection : SegmentCollection { public NteCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public NTE this[int index] { get { return Segments[index] as NTE; } set { Segments[index] = value; } } }
    public class Cr1Collection : SegmentCollection { public Cr1Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CR1 this[int index] { get { return Segments[index] as CR1; } set { Segments[index] = value; } } }
    public class Cr2Collection : SegmentCollection { public Cr2Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CR2 this[int index] { get { return Segments[index] as CR2; } set { Segments[index] = value; } } }
    public class CrcCollection : SegmentCollection { public CrcCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CRC this[int index] { get { return Segments[index] as CRC; } set { Segments[index] = value; } } }
    public class HiCollection : SegmentCollection { public HiCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public HI this[int index] { get { return Segments[index] as HI; } set { Segments[index] = value; } } }
    public class HcpCollection : SegmentCollection { public HcpCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public HCP this[int index] { get { return Segments[index] as HCP; } set { Segments[index] = value; } } }
    public class CasCollection : SegmentCollection { public CasCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CAS this[int index] { get { return Segments[index] as CAS; } set { Segments[index] = value; } } }
    public class OiCollection : SegmentCollection { public OiCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public OI this[int index] { get { return Segments[index] as OI; } set { Segments[index] = value; } } }
    public class MoaCollection : SegmentCollection { public MoaCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public MOA this[int index] { get { return Segments[index] as MOA; } set { Segments[index] = value; } } }
    public class LxCollection : SegmentCollection { public LxCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public LX this[int index] { get { return Segments[index] as LX; } set { Segments[index] = value; } } }
    public class Sv1Collection : SegmentCollection { public Sv1Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public SV1 this[int index] { get { return Segments[index] as SV1; } set { Segments[index] = value; } } }
    public class Sv5Collection : SegmentCollection { public Sv5Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public SV5 this[int index] { get { return Segments[index] as SV5; } set { Segments[index] = value; } } }
    public class Cr3Collection : SegmentCollection { public Cr3Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CR3 this[int index] { get { return Segments[index] as CR3; } set { Segments[index] = value; } } }
    public class QtyCollection : SegmentCollection { public QtyCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public QTY this[int index] { get { return Segments[index] as QTY; } set { Segments[index] = value; } } }
    public class MeaCollection : SegmentCollection { public MeaCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public MEA this[int index] { get { return Segments[index] as MEA; } set { Segments[index] = value; } } }
    public class Ps1Collection : SegmentCollection { public Ps1Collection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public PS1 this[int index] { get { return Segments[index] as PS1; } set { Segments[index] = value; } } }
    public class LinCollection : SegmentCollection { public LinCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public LIN this[int index] { get { return Segments[index] as LIN; } set { Segments[index] = value; } } }
    public class CtpCollection : SegmentCollection { public CtpCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public CTP this[int index] { get { return Segments[index] as CTP; } set { Segments[index] = value; } } }
    public class SvdCollection : SegmentCollection { public SvdCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public SVD this[int index] { get { return Segments[index] as SVD; } set { Segments[index] = value; } } }
    public class LqCollection : SegmentCollection { public LqCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public LQ this[int index] { get { return Segments[index] as LQ; } set { Segments[index] = value; } } }
    public class FrmCollection : SegmentCollection { public FrmCollection(LoopEntity owningLoopEntity, string segDefName) : base(owningLoopEntity, segDefName) { } public FRM this[int index] { get { return Segments[index] as FRM; } set { Segments[index] = value; } } }

}