using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EDI.X12.v2.Base
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
        public string LoopName;
        public string LoopDescription;

        public LoopCollection ParentLoopCollection;  

        public List<LoopDefinition> SubLoops;
        public List<SegmentDefinition> LoopSegments;

        public LoopDefinition(int repCount)
        {
            SubLoops = new List<LoopDefinition>();
            LoopSegments = new List<SegmentDefinition>();

            RepeatCount = repCount; 
        }
    }

    public class SegmentDefinition
    {
        public List<SegmentQualifiers> Qualifiers = new List<SegmentQualifiers>();
        public SegmentUsageType Usage;
        public int RepeatCount;
        private List<Func<List<string>, bool>> _addlQualifierLogic = new List<Func<List<string>, bool>>();
        private Type SegmentType;
        //private SegmentCollection _owningCollection; //might not need to know the owning collection since that is at a LoopEntity level
        public List<int> RequiredFields = new List<int>();
        public List<int> UnusedFields = new List<int>();
        public List<string> SyntaxRuleList = new List<string>();

        public SegmentDefinition(SegmentUsageType use, int reps, Type segT)
        {
            Usage = use;
            RepeatCount = reps;
            SegmentType = segT;
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
