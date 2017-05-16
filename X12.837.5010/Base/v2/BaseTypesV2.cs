using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawsonCS.Model.EDI.X12.v2.Base
{
    public class x12Doc
    {
        public const string firstDelim = "*";
        public const string secondDelim = "#";

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

        [ProtoBuf.ProtoMember(12)]
        public SE transactionSetTrailer;

        public x12Doc()
        {
        }
    }

    [ProtoBuf.ProtoContract]
    public class LoopList<T> : List<T> where T: LoopEntity
    {
        public int LoopRepeatCapacity;
        public LoopDefinition LoopDef;

        public x12Doc OwningX12Doc;

        private LoopList() { }

        public LoopList(int capacity)
        {
            LoopRepeatCapacity = capacity;
        }

        public virtual bool Validate() { throw new NotImplementedException(); } 
    }

    public class LoopEntity
    {
        public string LoopName;

        public LoopList<LoopEntity> OwningList;

        public virtual bool Validate() { throw new NotImplementedException(); }
    }    

    public class LoopDefinition { }

    public class SegmentDefinition
    {
        public List<SegmentQualifiers> Qualifiers = new List<SegmentQualifiers>();
        public SegmentUsageType Usage;
        public int RepeatCount;
        private List<Func<List<string>, bool>> _addlQualifierLogic = new List<Func<List<string>, bool>>();
        private Type SegmentType;

        public SegmentDefinition(SegmentUsageType use, int reps, Type segT)
        {
            Usage = use;
            RepeatCount = reps;
            SegmentType = segT;
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

    public class baseSegmentCollection<T> where T:baseStdSegment
    {
        public string SegmentName;
        public List<T> Instance = new List<T>();

        public SegmentDefinition SegmentDef;
    }

    public abstract class baseStdSegment
    {
        public string _rawValue = null;
        public baseFieldValues _fieldValues;

        public baseSegmentCollection<baseStdSegment> OwningCollection;

        public baseStdSegment() { }

        public baseStdSegment(string value)
        {
            _rawValue = value;
            _fieldValues = new baseFieldValues(_rawValue.Split(new[] { " " }, StringSplitOptions.None).ToList());
        }

        public abstract void Populate();
        public abstract bool Validate();
    }

    public class baseFieldValues : List<string>
    {
        public string _rawValue;

        public baseFieldValues(List<string> values)
        {

        }

        public baseFieldValues(byte[] buffer, int offset, int length, byte elementSep, string compSep)
        {
            var sb = new StringBuilder();

            for (int i = offset; i < offset + length; i++)
            {
                if (buffer[i] == d)
                {
                    if (sb.Length == 0)
                        this.Add(null);
                    else
                    {
                        if (char.IsLetterOrDigit(sb[0]))
                            this.AddRange(sb.ToString().Split(new[] { compSep }, StringSplitOptions.None));
                        else
                            this.AddRange(sb.ToString().TrimStart().Split(new[] { compSep }, StringSplitOptions.None));
                        sb.Length = 0;
                    }
                }
                else
                    sb.Append((char)buffer[i]);
            }
            if (sb.Length > 0)
                this.Add(sb.ToString());
            if (this.Count == 0) Console.WriteLine("Bad Segment: " + Encoding.ASCII.GetString(buffer, offset, length));

        }
    }
}
