using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EDI.X12.v2.Base;

namespace Model.EDI.X12.v2
{
    public class IeaCollection : SegmentCollection { public IeaCollection(LoopEntity owningLoop) : base(typeof(IEA), owningLoop) { } public IEA this[int index] { get { return Segments[index] as IEA; } set { Segments[index] = value; } } }
    public class GsCollection : SegmentCollection { public GsCollection(LoopEntity owningLoop) : base(typeof(GS), owningLoop) { } public GS this[int index] { get { return Segments[index] as GS; } set { Segments[index] = value; } } }
    public class IsaCollection : SegmentCollection { public IsaCollection(LoopEntity owningLoop) : base(typeof(ISA), owningLoop) { } public ISA this[int index] { get { return Segments[index] as ISA; } set { Segments[index] = value; } } }
    public class GeCollection : SegmentCollection { public GeCollection(LoopEntity owningLoop) : base(typeof(GE), owningLoop) { } public GE this[int index] { get { return Segments[index] as GE; } set { Segments[index] = value; } } }
    public class StCollection : SegmentCollection { public StCollection(LoopEntity owningLoop) : base(typeof(ST), owningLoop) { } public ST this[int index] { get { return Segments[index] as ST; } set { Segments[index] = value; } } }
    public class BhtCollection : SegmentCollection { public BhtCollection(LoopEntity owningLoop) : base(typeof(BHT), owningLoop) { } public BHT this[int index] { get { return Segments[index] as BHT; } set { Segments[index] = value; } } }
    public class SeCollection : SegmentCollection { public SeCollection(LoopEntity owningLoop) : base(typeof(SE), owningLoop) { } public SE this[int index] { get { return Segments[index] as SE; } set { Segments[index] = value; } } }
    public class HlCollection : SegmentCollection { public HlCollection(LoopEntity owningLoop) : base(typeof(HL), owningLoop) { } public HL this[int index] { get { return Segments[index] as HL; } set { Segments[index] = value; } } }
    public class Nm1Collection : SegmentCollection { public Nm1Collection(LoopEntity owningLoop) : base(typeof(NM1), owningLoop) { } public NM1 this[int index] { get { return Segments[index] as NM1; } set { Segments[index] = value; } } }
    public class DmgCollection : SegmentCollection { public DmgCollection(LoopEntity owningLoop) : base(typeof(DMG), owningLoop) { } public DMG this[int index] { get { return Segments[index] as DMG; } set { Segments[index] = value; } } }
    public class TrnCollection : SegmentCollection { public TrnCollection(LoopEntity owningLoop) : base(typeof(TRN), owningLoop) { } public TRN this[int index] { get { return Segments[index] as TRN; } set { Segments[index] = value; } } }
    public class RefCollection : SegmentCollection { public RefCollection(LoopEntity owningLoop) : base(typeof(REF), owningLoop) { } public REF this[int index] { get { return Segments[index] as REF; } set { Segments[index] = value; } } }
    public class AmtCollection : SegmentCollection { public AmtCollection(LoopEntity owningLoop) : base(typeof(AMT), owningLoop) { } public AMT this[int index] { get { return Segments[index] as AMT; } set { Segments[index] = value; } } }
    public class DtpCollection : SegmentCollection { public DtpCollection(LoopEntity owningLoop) : base(typeof(DTP), owningLoop) { } public DTP this[int index] { get { return Segments[index] as DTP; } set { Segments[index] = value; } } }
    public class SvcCollection : SegmentCollection { public SvcCollection(LoopEntity owningLoop) : base(typeof(SVC), owningLoop) { } public SVC this[int index] { get { return Segments[index] as SVC; } set { Segments[index] = value; } } }
    public class StcCollection : SegmentCollection { public StcCollection(LoopEntity owningLoop) : base(typeof(STC), owningLoop) { } public STC this[int index] { get { return Segments[index] as STC; } set { Segments[index] = value; } } }
    public class PerCollection : SegmentCollection { public PerCollection(LoopEntity owningLoop) : base(typeof(PER), owningLoop) { } public PER this[int index] { get { return Segments[index] as PER; } set { Segments[index] = value; } } }
    public class SbrCollection : SegmentCollection { public SbrCollection(LoopEntity owningLoop) : base(typeof(SBR), owningLoop) { } public SBR this[int index] { get { return Segments[index] as SBR; } set { Segments[index] = value; } } }
    public class PatCollection : SegmentCollection { public PatCollection(LoopEntity owningLoop) : base(typeof(PAT), owningLoop) { } public PAT this[int index] { get { return Segments[index] as PAT; } set { Segments[index] = value; } } }
    public class N3Collection : SegmentCollection { public N3Collection(LoopEntity owningLoop) : base(typeof(N3), owningLoop) { } public N3 this[int index] { get { return Segments[index] as N3; } set { Segments[index] = value; } } }
    public class N4Collection : SegmentCollection { public N4Collection(LoopEntity owningLoop) : base(typeof(N4), owningLoop) { } public N4 this[int index] { get { return Segments[index] as N4; } set { Segments[index] = value; } } }
    public class ClmCollection : SegmentCollection { public ClmCollection(LoopEntity owningLoop) : base(typeof(CLM), owningLoop) { } public CLM this[int index] { get { return Segments[index] as CLM; } set { Segments[index] = value; } } }
    public class PrvCollection : SegmentCollection { public PrvCollection(LoopEntity owningLoop) : base(typeof(PRV), owningLoop) { } public PRV this[int index] { get { return Segments[index] as PRV; } set { Segments[index] = value; } } }
    public class CurCollection : SegmentCollection { public CurCollection(LoopEntity owningLoop) : base(typeof(CUR), owningLoop) { } public CUR this[int index] { get { return Segments[index] as CUR; } set { Segments[index] = value; } } }
    public class PwkCollection : SegmentCollection { public PwkCollection(LoopEntity owningLoop) : base(typeof(PWK), owningLoop) { } public PWK this[int index] { get { return Segments[index] as PWK; } set { Segments[index] = value; } } }
    public class Cn1Collection : SegmentCollection { public Cn1Collection(LoopEntity owningLoop) : base(typeof(CN1), owningLoop) { } public CN1 this[int index] { get { return Segments[index] as CN1; } set { Segments[index] = value; } } }
    public class K3Collection : SegmentCollection { public K3Collection(LoopEntity owningLoop) : base(typeof(K3), owningLoop) { } public K3 this[int index] { get { return Segments[index] as K3; } set { Segments[index] = value; } } }
    public class NteCollection : SegmentCollection { public NteCollection(LoopEntity owningLoop) : base(typeof(NTE), owningLoop) { } public NTE this[int index] { get { return Segments[index] as NTE; } set { Segments[index] = value; } } }
    public class Cr1Collection : SegmentCollection { public Cr1Collection(LoopEntity owningLoop) : base(typeof(CR1), owningLoop) { } public CR1 this[int index] { get { return Segments[index] as CR1; } set { Segments[index] = value; } } }
    public class Cr2Collection : SegmentCollection { public Cr2Collection(LoopEntity owningLoop) : base(typeof(CR2), owningLoop) { } public CR2 this[int index] { get { return Segments[index] as CR2; } set { Segments[index] = value; } } }
    public class CrcCollection : SegmentCollection { public CrcCollection(LoopEntity owningLoop) : base(typeof(CRC), owningLoop) { } public CRC this[int index] { get { return Segments[index] as CRC; } set { Segments[index] = value; } } }
    public class HiCollection : SegmentCollection { public HiCollection(LoopEntity owningLoop) : base(typeof(HI), owningLoop) { } public HI this[int index] { get { return Segments[index] as HI; } set { Segments[index] = value; } } }
    public class HcpCollection : SegmentCollection { public HcpCollection(LoopEntity owningLoop) : base(typeof(HCP), owningLoop) { } public HCP this[int index] { get { return Segments[index] as HCP; } set { Segments[index] = value; } } }
    public class CasCollection : SegmentCollection { public CasCollection(LoopEntity owningLoop) : base(typeof(CAS), owningLoop) { } public CAS this[int index] { get { return Segments[index] as CAS; } set { Segments[index] = value; } } }
    public class OiCollection : SegmentCollection { public OiCollection(LoopEntity owningLoop) : base(typeof(OI), owningLoop) { } public OI this[int index] { get { return Segments[index] as OI; } set { Segments[index] = value; } } }
    public class MoaCollection : SegmentCollection { public MoaCollection(LoopEntity owningLoop) : base(typeof(MOA), owningLoop) { } public MOA this[int index] { get { return Segments[index] as MOA; } set { Segments[index] = value; } } }
    public class LxCollection : SegmentCollection { public LxCollection(LoopEntity owningLoop) : base(typeof(LX), owningLoop) { } public LX this[int index] { get { return Segments[index] as LX; } set { Segments[index] = value; } } }
    public class Sv1Collection : SegmentCollection { public Sv1Collection(LoopEntity owningLoop) : base(typeof(SV1), owningLoop) { } public SV1 this[int index] { get { return Segments[index] as SV1; } set { Segments[index] = value; } } }
    public class Sv5Collection : SegmentCollection { public Sv5Collection(LoopEntity owningLoop) : base(typeof(SV5), owningLoop) { } public SV5 this[int index] { get { return Segments[index] as SV5; } set { Segments[index] = value; } } }
    public class Cr3Collection : SegmentCollection { public Cr3Collection(LoopEntity owningLoop) : base(typeof(CR3), owningLoop) { } public CR3 this[int index] { get { return Segments[index] as CR3; } set { Segments[index] = value; } } }
    public class QtyCollection : SegmentCollection { public QtyCollection(LoopEntity owningLoop) : base(typeof(QTY), owningLoop) { } public QTY this[int index] { get { return Segments[index] as QTY; } set { Segments[index] = value; } } }
    public class MeaCollection : SegmentCollection { public MeaCollection(LoopEntity owningLoop) : base(typeof(MEA), owningLoop) { } public MEA this[int index] { get { return Segments[index] as MEA; } set { Segments[index] = value; } } }
    public class Ps1Collection : SegmentCollection { public Ps1Collection(LoopEntity owningLoop) : base(typeof(PS1), owningLoop) { } public PS1 this[int index] { get { return Segments[index] as PS1; } set { Segments[index] = value; } } }
    public class LinCollection : SegmentCollection { public LinCollection(LoopEntity owningLoop) : base(typeof(LIN), owningLoop) { } public LIN this[int index] { get { return Segments[index] as LIN; } set { Segments[index] = value; } } }
    public class CtpCollection : SegmentCollection { public CtpCollection(LoopEntity owningLoop) : base(typeof(CTP), owningLoop) { } public CTP this[int index] { get { return Segments[index] as CTP; } set { Segments[index] = value; } } }
    public class SvdCollection : SegmentCollection { public SvdCollection(LoopEntity owningLoop) : base(typeof(SVD), owningLoop) { } public SVD this[int index] { get { return Segments[index] as SVD; } set { Segments[index] = value; } } }
    public class LqCollection : SegmentCollection { public LqCollection(LoopEntity owningLoop) : base(typeof(LQ), owningLoop) { } public LQ this[int index] { get { return Segments[index] as LQ; } set { Segments[index] = value; } } }
    public class FrmCollection : SegmentCollection { public FrmCollection(LoopEntity owningLoop) : base(typeof(FRM), owningLoop) { } public FRM this[int index] { get { return Segments[index] as FRM; } set { Segments[index] = value; } } }

}
