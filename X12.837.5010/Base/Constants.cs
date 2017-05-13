using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsonCS.Model.EDI.X12
{
    public enum SegmentUsageType
    {
        Optional,
        Required,
        Situational,
        Relational
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
}
