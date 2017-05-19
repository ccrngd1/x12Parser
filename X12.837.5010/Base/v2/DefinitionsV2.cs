using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsonCS.Model.EDI.X12.v2.Base
{
    public class X12DocDefinition
    {
        public List<LoopDefinition> loops;
        public List<SegmentDefinition> segments;

        public X12DocDefinition()
        {
            loops = new List<LoopDefinition>();
            segments = new List<SegmentDefinition>();
        }
    }

    public class SegmentQualifiers
    {
        public List<string> QualifierValues = new List<string>();
        public int FieldId;

        public SegmentQualifiers(int fieldId, params string[] parameters)
        {
            FieldId = fieldId;
            QualifierValues = parameters.ToList();
        }
    }

    public class LoopDefinition
    {
        public int RepeatCount;

        public string ParentLoopName;

        public List<LoopDefinition> SubLoops;
        public List<SegmentDefinition> LoopSegments;

        public LoopDefinition(int repCount, string parentLoop)
        {
            SubLoops = new List<LoopDefinition>();
            LoopSegments = new List<SegmentDefinition>();

            RepeatCount = repCount;
            ParentLoopName = parentLoop;
        }
    }

    public class SegmentDefinition
    {
        public List<SegmentQualifiers> Qualifiers = new List<SegmentQualifiers>();
        public SegmentUsageType Usage;
        public int RepeatCount;
        private List<Func<List<string>, bool>> _addlQualifierLogic = new List<Func<List<string>, bool>>();
        private Type SegmentType;
        private SegmentCollection _owningCollection;

        public SegmentDefinition(SegmentUsageType use, int reps, Type segT, SegmentCollection owningCollection)
        {
            Usage = use;
            RepeatCount = reps;
            SegmentType = segT;
            _owningCollection = owningCollection;
        }

        public void AddQualifierLogic(Func<List<string>, bool> qualLogic)
        {
            _addlQualifierLogic.Add(qualLogic);
        }

        public bool IsQualified(List<string> segmentValues)
        {
            if (segmentValues[0] != SegmentType.Name) return false;

            foreach (var segQualVals in Qualifiers)
            {
                if (!segQualVals.QualifierValues.Contains(segmentValues[segQualVals.FieldId]))
                    return false;
            }

            if (_addlQualifierLogic == null || !_addlQualifierLogic.Any()) return true;

            return _addlQualifierLogic.All(func => func(segmentValues));
        }

        public baseStdSegment CreateInstance(string value, LoopEntity parentLoop)
        {
            var sg = (baseStdSegment)Activator.CreateInstance(SegmentType);
            return sg;
        }
    }

}
