using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EDI.X12
{
    public enum SegmentUsageType
    {
        Optional=0,
        Required=1,
        Situational=2,
        Relational=3
    }

    public enum X12ErrorTypes
    {
        Unknown = 0,
        NotDefined,
        RepeatsNotAllowed,
        RepeatLimitReached,
        MultipleDefintions,
        UnknownIntendedLoop,
        ValidationFailed,
    }

    public enum X12ErrorLevel
    {
        Document = 0,
        Loop,
        Segment,
    }

    public enum QulificationLevel
    {
        TopMost =0,
        FirstChild=1
    }
}
