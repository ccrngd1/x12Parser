using System;
using System.Collections.Generic;
using System.Linq; 

namespace Model.EDI.X12.v2.Base
{
    public struct SegmentErrorDetails
    {
        public string SegmentValue; 

        public SegmentErrorDetails(string segValue )
        {
            SegmentValue = segValue; 
        }
    } 

    public class SegmentQualifiers
    {
        public List<string> QualifierValues;
        public int FieldId;

        public SegmentQualifiers(int fieldId, params string[] parameters)
        {
            FieldId = fieldId;
            QualifierValues = parameters.ToList();
        }
    }

    public interface ISegmentDefinition
    {
        List<SegmentQualifiers> SegmentQualifierValues { get; set; }
    }

    public interface ISegmentValidator
    {
        List<Func<List<string>, bool>> AddlQualifierLogic { get; set; }
    }
}
