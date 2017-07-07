using System.Collections.Generic;
using System.Linq;
using EDI.X12.Enums;

namespace EDI.X12.Base
{ 
    /// <summary>
    /// Segment level qualifier rules
    /// </summary>
    internal class SegmentQualifiers
    {
        internal readonly List<string> QualifierValues;
        internal readonly int FieldId;

        internal SegmentQualifiers(int fieldId, params string[] parameters)
        {
            FieldId = fieldId;
            QualifierValues = parameters.ToList();
        }

        internal bool IsQaulified(BaseFieldValues segmentFields)
        {
            return QualifierValues.Contains(segmentFields[FieldId]);
        }
    }

    /// <summary>
    /// Contract that defines what is needed for segment definition for parsing
    /// </summary>
    public abstract class SegmentDefinition
    {
        LoopCollectionBase OwningLoopCollection { get; set; }

        List<SegmentQualifiers> SegmentQualifierValues { get; set; }

        bool IsLoopStarter { get; set; }

        string SegmentDefinitionName { get; set; }

        List<string> SyntaxRules { get; set; }

        SegmentUsageTypeNames SegmentUsage { get; set; }

        List<FieldUsageTypeNames> FieldUsage { get; set; }


        internal abstract BaseStdSegment CreateBaseStdSegment(BaseFieldValues bsf);
        internal abstract void Populate(BaseFieldValues baseVals);
        internal abstract bool IsQualified(BaseFieldValues segmentFields);

        public abstract override string ToString();
        public abstract bool Validate();
    }  
}
