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
    public class LoopList<T> : List<T> where T: LoopEntity;
    {
        [ProtoBuf.ProtoMember(1)]
        public int LoopRepeatCapacity;

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
    }    

    public class baseSegmentCollection<T> where T:baseStdSegment
    {
        public List<baseStdSegment> Instance = new List<baseStdSegment>();
    }

    public abstract class baseStdSegment
    {
        public string _rawValue = null;
        public baseFieldValues _fieldValues;

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
        public List<string> _subValues;

        public baseFieldValues(List<string> values)
        {

        }
    }
}
