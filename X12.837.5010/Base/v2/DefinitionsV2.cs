using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EDI.X12.v2.Base
{
    public struct SegmentErrorDetails
    {
        public string SegmentValue;
        public List<SegmentDefinition> MatchingDefinitions; 

        public SegmentErrorDetails(string segValue, List<SegmentDefinition> segDefMatches)
        {
            SegmentValue = segValue;
            MatchingDefinitions = new List<SegmentDefinition>(segDefMatches);
        }
    }
    public class X12DocDefinition
    {
        public List<LoopDefinition> loops;
        public List<SegmentDefinition> segments;

        public List<SegmentErrorDetails> erroredSegments;

        public X12DocDefinition()
        {
            loops = new List<LoopDefinition>();
            segments = new List<SegmentDefinition>();
            erroredSegments = new List<SegmentErrorDetails>();
        }

        public void IsQualified(List<string> lineSegmentFields)
        {
            List<SegmentDefinition> segMatches = segments.Where(c => c.IsQualified(lineSegmentFields)).ToList();

            segMatches.AddRange(loops.SelectMany(c => c.IsQualified(lineSegmentFields)).ToList());

            if (segMatches.Count() == 1)
            {
                //segMatches[0].CreateInstance(lineSegmentFields, )
            }
            else
            {
                erroredSegments.Add(new SegmentErrorDetails(string.Join(((char)(255)).ToString(),lineSegmentFields), segMatches));
            }
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

        public LoopCollection OwningLoopCollection;  

        public List<LoopDefinition> SubLoops;
        public List<SegmentDefinition> LoopSegments;

        public LoopDefinition(int repCount, LoopCollection owner)
        {
            SubLoops = new List<LoopDefinition>();
            LoopSegments = new List<SegmentDefinition>();

            RepeatCount = repCount;
            OwningLoopCollection = owner;
        }


        public List<SegmentDefinition> IsQualified(List<string> lineSegmentsFields)
        {
            List<SegmentDefinition> segmentMatches = LoopSegments.Where(c => c.IsQualified(lineSegmentsFields)).ToList();
            segmentMatches.AddRange(SubLoops.SelectMany(d => d.IsQualified(lineSegmentsFields)).ToList());

            return segmentMatches;
        }
    }

    public class SegmentDefinition
    {
        public List<SegmentQualifiers> Qualifiers = new List<SegmentQualifiers>();
        public SegmentUsageType Usage;
        public int RepeatCount;
        private List<Func<List<string>, bool>> _addlQualifierLogic = new List<Func<List<string>, bool>>();
        private Type SegmentType; 
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

        public baseStdSegment CreateInstance(List<string> value, LoopEntity parentLoop)
        {
            var sg = (baseStdSegment)Activator.CreateInstance(SegmentType);
            return sg;
        }
    }

}
