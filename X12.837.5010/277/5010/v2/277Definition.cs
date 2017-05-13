using LawsonCS.Model.EDI.X12.v2.Base;

namespace LawsonCS.Model.EDI.X12.Format277.v5010.v2
{
    public class X12_277_5010:x12Doc
    {
        public LoopList<Loop2000A> loop2000a = new LoopList<Loop2000A>(999);
        public LoopList<Loop2200B> loop2000b = new LoopList<Loop2200B>(999);
        public LoopList<Loop2000C> loop2000c = new LoopList<Loop2000C>(999);
        public LoopList<Loop2000DE> loop2000d = new LoopList<Loop2000DE>(999);
        public LoopList<Loop2000DE> loop2000e = new LoopList<Loop2000DE>(999);

        public X12_277_5010()
        {

        }
    }
}
