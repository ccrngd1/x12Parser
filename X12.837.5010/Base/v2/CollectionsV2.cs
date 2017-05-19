using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawsonCS.Model.EDI.X12.v2.Base;

namespace LawsonCS.Model.EDI.X12.v2
{
    public class IeaCollection : SegmentCollection { public IeaCollection() : base(typeof(IEA)) { } public IEA this[int index] { get { return Segments[index] as IEA; } set { Segments[index] = value; } } }
    public class GsCollection : SegmentCollection { public GsCollection() : base(typeof(GS)) { } public GS this[int index] { get { return Segments[index] as GS; } set { Segments[index] = value; } } }
    public class IsaCollection : SegmentCollection { public IsaCollection() : base(typeof(ISA)) { } public ISA this[int index] { get { return Segments[index] as ISA; } set { Segments[index] = value; } } }
    public class GeCollection : SegmentCollection { public GeCollection() : base(typeof(GE)) { } public GE this[int index] { get { return Segments[index] as GE; } set { Segments[index] = value; } } }
    public class StCollection : SegmentCollection { public StCollection() : base(typeof(ST)) { } public ST this[int index] { get { return Segments[index] as ST; } set { Segments[index] = value; } } }
    public class BhtCollection : SegmentCollection { public BhtCollection() : base(typeof(BHT)) { } public BHT this[int index] { get { return Segments[index] as BHT; } set { Segments[index] = value; } } }
    public class SeCollection : SegmentCollection { public SeCollection() : base(typeof(SE)) { } public SE this[int index] { get { return Segments[index] as SE; } set { Segments[index] = value; } } }
    public class HlCollection : SegmentCollection { public HlCollection() : base(typeof(HL)) { } public HL this[int index] { get { return Segments[index] as HL; } set { Segments[index] = value; } } }
    public class Nm1Collection : SegmentCollection { public Nm1Collection() : base(typeof(NM1)) { } public NM1 this[int index] { get { return Segments[index] as NM1; } set { Segments[index] = value; } } }
    public class DmgCollection : SegmentCollection { public DmgCollection() : base(typeof(DMG)) { } public DMG this[int index] { get { return Segments[index] as DMG; } set { Segments[index] = value; } } }
    public class TrnCollection : SegmentCollection { public TrnCollection() : base(typeof(TRN)) { } public TRN this[int index] { get { return Segments[index] as TRN; } set { Segments[index] = value; } } }
    public class RefCollection : SegmentCollection { public RefCollection() : base(typeof(REF)) { } public REF this[int index] { get { return Segments[index] as REF; } set { Segments[index] = value; } } }
    public class AmtCollection : SegmentCollection { public AmtCollection() : base(typeof(AMT)) { } public AMT this[int index] { get { return Segments[index] as AMT; } set { Segments[index] = value; } } }
    public class DtpCollection : SegmentCollection { public DtpCollection() : base(typeof(DTP)) { } public DTP this[int index] { get { return Segments[index] as DTP; } set { Segments[index] = value; } } }
    public class SvcCollection : SegmentCollection { public SvcCollection() : base(typeof(SVC)) { } public SVC this[int index] { get { return Segments[index] as SVC; } set { Segments[index] = value; } } }
    public class StcCollection : SegmentCollection { public StcCollection() : base(typeof(STC)) { } public STC this[int index] { get { return Segments[index] as STC; } set { Segments[index] = value; } } }
    public class PerCollection : SegmentCollection { public PerCollection() : base(typeof(PER)) { } public PER this[int index] { get { return Segments[index] as PER; } set { Segments[index] = value; } } }
    public class SbrCollection : SegmentCollection { public SbrCollection() : base(typeof(SBR)) { } public SBR this[int index] { get { return Segments[index] as SBR; } set { Segments[index] = value; } } }
    public class PatCollection : SegmentCollection { public PatCollection() : base(typeof(PAT)) { } public PAT this[int index] { get { return Segments[index] as PAT; } set { Segments[index] = value; } } }
    public class N3Collection : SegmentCollection { public N3Collection() : base(typeof(N3)) { } public N3 this[int index] { get { return Segments[index] as N3; } set { Segments[index] = value; } } }
    public class N4Collection : SegmentCollection { public N4Collection() : base(typeof(N4)) { } public N4 this[int index] { get { return Segments[index] as N4; } set { Segments[index] = value; } } }
    public class ClmCollection : SegmentCollection { public ClmCollection() : base(typeof(CLM)) { } public CLM this[int index] { get { return Segments[index] as CLM; } set { Segments[index] = value; } } }
    public class PrvCollection : SegmentCollection { public PrvCollection() : base(typeof(PRV)) { } public PRV this[int index] { get { return Segments[index] as PRV; } set { Segments[index] = value; } } }
    public class CurCollection : SegmentCollection { public CurCollection() : base(typeof(CUR)) { } public CUR this[int index] { get { return Segments[index] as CUR; } set { Segments[index] = value; } } }
    public class PwkCollection : SegmentCollection { public PwkCollection() : base(typeof(PWK)) { } public PWK this[int index] { get { return Segments[index] as PWK; } set { Segments[index] = value; } } }
    public class Cn1Collection : SegmentCollection { public Cn1Collection() : base(typeof(CN1)) { } public CN1 this[int index] { get { return Segments[index] as CN1; } set { Segments[index] = value; } } }
    public class K3Collection : SegmentCollection { public K3Collection() : base(typeof(K3)) { } public K3 this[int index] { get { return Segments[index] as K3; } set { Segments[index] = value; } } }
    public class NteCollection : SegmentCollection { public NteCollection() : base(typeof(NTE)) { } public NTE this[int index] { get { return Segments[index] as NTE; } set { Segments[index] = value; } } }
    public class Cr1Collection : SegmentCollection { public Cr1Collection() : base(typeof(CR1)) { } public CR1 this[int index] { get { return Segments[index] as CR1; } set { Segments[index] = value; } } }
    public class Cr2Collection : SegmentCollection { public Cr2Collection() : base(typeof(CR2)) { } public CR2 this[int index] { get { return Segments[index] as CR2; } set { Segments[index] = value; } } }
    public class CrcCollection : SegmentCollection { public CrcCollection() : base(typeof(CRC)) { } public CRC this[int index] { get { return Segments[index] as CRC; } set { Segments[index] = value; } } }
    public class HiCollection : SegmentCollection { public HiCollection() : base(typeof(HI)) { } public HI this[int index] { get { return Segments[index] as HI; } set { Segments[index] = value; } } }
    public class HcpCollection : SegmentCollection { public HcpCollection() : base(typeof(HCP)) { } public HCP this[int index] { get { return Segments[index] as HCP; } set { Segments[index] = value; } } }
    public class CasCollection : SegmentCollection { public CasCollection() : base(typeof(CAS)) { } public CAS this[int index] { get { return Segments[index] as CAS; } set { Segments[index] = value; } } }
    public class OiCollection : SegmentCollection { public OiCollection() : base(typeof(OI)) { } public OI this[int index] { get { return Segments[index] as OI; } set { Segments[index] = value; } } }
    public class MoaCollection : SegmentCollection { public MoaCollection() : base(typeof(MOA)) { } public MOA this[int index] { get { return Segments[index] as MOA; } set { Segments[index] = value; } } }
    public class LxCollection : SegmentCollection { public LxCollection() : base(typeof(LX)) { } public LX this[int index] { get { return Segments[index] as LX; } set { Segments[index] = value; } } }
    public class Sv1Collection : SegmentCollection { public Sv1Collection() : base(typeof(SV1)) { } public SV1 this[int index] { get { return Segments[index] as SV1; } set { Segments[index] = value; } } }
    public class Sv5Collection : SegmentCollection { public Sv5Collection() : base(typeof(SV5)) { } public SV5 this[int index] { get { return Segments[index] as SV5; } set { Segments[index] = value; } } }
    public class Cr3Collection : SegmentCollection { public Cr3Collection() : base(typeof(CR3)) { } public CR3 this[int index] { get { return Segments[index] as CR3; } set { Segments[index] = value; } } }
    public class QtyCollection : SegmentCollection { public QtyCollection() : base(typeof(QTY)) { } public QTY this[int index] { get { return Segments[index] as QTY; } set { Segments[index] = value; } } }
    public class MeaCollection : SegmentCollection { public MeaCollection() : base(typeof(MEA)) { } public MEA this[int index] { get { return Segments[index] as MEA; } set { Segments[index] = value; } } }
    public class Ps1Collection : SegmentCollection { public Ps1Collection() : base(typeof(PS1)) { } public PS1 this[int index] { get { return Segments[index] as PS1; } set { Segments[index] = value; } } }
    public class LinCollection : SegmentCollection { public LinCollection() : base(typeof(LIN)) { } public LIN this[int index] { get { return Segments[index] as LIN; } set { Segments[index] = value; } } }
    public class CtpCollection : SegmentCollection { public CtpCollection() : base(typeof(CTP)) { } public CTP this[int index] { get { return Segments[index] as CTP; } set { Segments[index] = value; } } }
    public class SvdCollection : SegmentCollection { public SvdCollection() : base(typeof(SVD)) { } public SVD this[int index] { get { return Segments[index] as SVD; } set { Segments[index] = value; } } }
    public class LqCollection : SegmentCollection { public LqCollection() : base(typeof(LQ)) { } public LQ this[int index] { get { return Segments[index] as LQ; } set { Segments[index] = value; } } }
    public class FrmCollection : SegmentCollection { public FrmCollection() : base(typeof(FRM)) { } public FRM this[int index] { get { return Segments[index] as FRM; } set { Segments[index] = value; } } }

}
