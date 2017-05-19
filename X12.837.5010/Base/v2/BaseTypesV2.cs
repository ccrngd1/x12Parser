using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LawsonCS.Model.EDI.X12.v2.Base
{

    public class x12Doc
    {

        public const string firstDelim = "*";
        public const string secondDelim = "#";

        [ProtoBuf.ProtoMember(1)]
        public STCollection transactionSetHeader;
        [ProtoBuf.ProtoMember(2)]
        public BHTCollection beginHierarchicalTransaction;

        [ProtoBuf.ProtoMember(3)]
        public GECollection functionalGroupTrailer;
        [ProtoBuf.ProtoMember(4)]
        public ISACollection interchagneControlHeader;
        [ProtoBuf.ProtoMember(5)]
        public GSCollection functionGroupHeader;
        [ProtoBuf.ProtoMember(6)]
        public IEACollection interchangeControlTrailer;

        [ProtoBuf.ProtoMember(12)]
        public SECollection transactionSetTrailer;

        public x12Doc()
        {
        }
    }

    [ProtoBuf.ProtoContract]
    public abstract class LoopList
    {
        public x12Doc OwningX12Doc;

        protected List<LoopEntity> LoopEntities;

        public LoopDefinition Definition;

        public LoopList()
        {
            LoopEntities = new List<LoopEntity>();
        }

        public abstract bool Validate();

        public abstract void SetUpDefinition();
        
    }

    public abstract class LoopEntity
    {
        public string LoopName;

        public LoopList SubLoopsList;
        public List<baseSegmentCollection> Segments;
        
        public virtual bool Validate() { throw new NotImplementedException(); }
    }

    public class baseSegmentCollection
    {
        public string SegmentName;
        public List<baseStdSegment> Segments;
        public SegmentDefinition Definition;
        public Type BaseType;

        public LoopEntity OwningLoop;

        public baseSegmentCollection(Type baseType)
        {
            BaseType = baseType;
        }
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

        public baseFieldValues(List<string> values)
        {

        }

        public baseFieldValues(byte[] buffer, int offset, int length, byte elementSep, string compSep)
        {
            var sb = new StringBuilder();

            for (int i = offset; i < offset + length; i++)
            {
                if (buffer[i] == elementSep)
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
