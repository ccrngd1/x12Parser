using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EDI.X12.v1;
using Model.EDI.X12.v1.Base;

namespace Model.EDI.X12.Format277.v5010.v1
{
    [ProtoBuf.ProtoContract]
    public class X12_277_5010
    {

        [ProtoBuf.ProtoMember(1)]
        public ST transactionSetHeader;
        [ProtoBuf.ProtoMember(2)]
        public BHT beginHierarchicalTransaction;

        [ProtoBuf.ProtoMember(3)]
        public GE functionalGroupTrailer;
        [ProtoBuf.ProtoMember(4)]
        public ISA interchagneControlHeader;
        [ProtoBuf.ProtoMember(5)]
        public GS functionGroupHeader;
        [ProtoBuf.ProtoMember(6)]
        public IEA interchangeControlTrailer;

        [ProtoBuf.ProtoMember(7)]
        public LoopList<Loop2000A> loop2000A = new LoopList<Loop2000A> { LoopRepeat = 999 };
        [ProtoBuf.ProtoMember(8)]
        public LoopList<Loop2000B> loop2000B = new LoopList<Loop2000B> { LoopRepeat = 999 };
        [ProtoBuf.ProtoMember(9)]
        public LoopList<Loop2000C> loop2000C = new LoopList<Loop2000C> { LoopRepeat = 999 };
        [ProtoBuf.ProtoMember(10)]
        public LoopList<Loop2000D> loop2000D = new LoopList<Loop2000D> { LoopRepeat = 999 };
        [ProtoBuf.ProtoMember(11)]
        public LoopList<Loop2000E> loop2000E = new LoopList<Loop2000E> { LoopRepeat = 999 };

        [ProtoBuf.ProtoMember(12)]
        public SE transactionSetTrailer;

        public X12_277_5010()
        {
        }
    }
}
