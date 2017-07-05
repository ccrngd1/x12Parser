using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EDI.X12.v1;
using Model.EDI.X12.v1.Base;

namespace Model.EDI.X12.Format277.v5010.v1
{ 
    public class X12_277_5010
    {

        public ST transactionSetHeader;
        public BHT beginHierarchicalTransaction;

        public GE functionalGroupTrailer;
        public ISA interchagneControlHeader;
        public GS functionGroupHeader;
        public IEA interchangeControlTrailer;

        public LoopList<Loop2000A> loop2000A = new LoopList<Loop2000A> { LoopRepeat = 999 };
        public LoopList<Loop2000B> loop2000B = new LoopList<Loop2000B> { LoopRepeat = 999 };
        public LoopList<Loop2000C> loop2000C = new LoopList<Loop2000C> { LoopRepeat = 999 };
        public LoopList<Loop2000D> loop2000D = new LoopList<Loop2000D> { LoopRepeat = 999 };
        public LoopList<Loop2000E> loop2000E = new LoopList<Loop2000E> { LoopRepeat = 999 };

        public SE transactionSetTrailer;

        public X12_277_5010()
        {
        }
    }
}
