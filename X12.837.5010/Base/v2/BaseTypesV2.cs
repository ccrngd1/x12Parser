using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.EDI.X12.v2.Base
{
    /// <summary>
    /// This is the struct that will hold the characters that delimit particular sections of a x12 line
    /// </summary>
    public struct Delimiters
    {
        public char Segment { get; set; }
        public char Element { get; set; }
        public char SubElement { get; set; }
        public char Repetition { get; set; }
        public string Line { get; set; }
    }

    /// <summary>
    /// All versions of an X12 document will inheirt this base
    /// It sets up the header segments that are globally required
    /// It also houses the Delimiters that will be referenced during parsing of line segments and building
    /// </summary>
    public class X12Doc
    {
        private const string firstDelim = "*";
        private const string secondDelim = "#";

        public Delimiters DocDelimiters = new Delimiters();

        public X12DocDefinition DocumentDefinition = new X12DocDefinition();

        [ProtoBuf.ProtoMember(1)]
        public StCollection TransactionSetHeader= new StCollection();
        [ProtoBuf.ProtoMember(2)]
        public BhtCollection BeginHierarchicalTransaction= new  BhtCollection();

        [ProtoBuf.ProtoMember(3)]
        public GeCollection FunctionalGroupTrailer=new GeCollection();
        [ProtoBuf.ProtoMember(4)]
        public IsaCollection InterchagneControlHeader=new IsaCollection();
        [ProtoBuf.ProtoMember(5)]
        public GsCollection FunctionGroupHeader=new GsCollection();
        [ProtoBuf.ProtoMember(6)]
        public IeaCollection InterchangeControlTrailer=new IeaCollection();

        [ProtoBuf.ProtoMember(12)]
        public SeCollection TransactionSetTrailer = new SeCollection();

        public X12Doc()
        {
        }

        public virtual void SetUpWholeDefinition() { }
    }

    /// <summary>
    /// This class wraps the collection of loops, of the same type
    /// Intent is that Individual Loops would inherit from this to create a Loop####XXCollection class
    /// IE Loop2000ACollection
    /// The LoopEntities would then be of type Loop2000A, but it will up to the implementing class to cast this back
    /// This could ahve been made somewhat simpler if this was LoopCollection &lt; T &gt; but that would eliminate the ability to treat all loops as single type "/>
    /// </summary>
    [ProtoBuf.ProtoContract]
    public abstract class LoopCollection
    {
        public X12Doc OwningX12Doc;

        protected List<LoopEntity> LoopEntities;

        public LoopDefinition Definition;

        public string LoopName;
        public string LoopNameDescription;

        public LoopCollection(string loopName, string loopNameDescription)
        {
            LoopEntities = new List<LoopEntity>(); 
        }

        //going new direction with definitions
        //public LoopCollection(LoopCollection owningLoopCollection, LoopCollection parentLoopCollection,
        //    LoopEntity parentLoopEntity, int reps):this()
        //{
        //    Definition = new LoopDefinition(reps)
        //    {
        //        ParentLoop = parentLoopEntity,
        //        ParentLoopCollection = parentLoopCollection,
        //        OwningLoopCollection = owningLoopCollection,
        //        SubLoops = null,
        //        LoopSegments = null
        //    };
        //}

        public abstract bool Validate();

        public abstract void SetUpDefinition(LoopCollection parentLoopCollection);
        
    }

    /// <summary>
    /// Since LoopCollection had to be completely generic, this class allows for typing it dynamically
    /// While still retaining the ability to group all loops as a single generic type of LoopCollection
    /// Intent is that Individual Loops would inherit from this to create a Loop####XXCollection class
    /// IE Loop2000ACollection
    /// The LoopEntities would then be of type Loop2000A, but it will up to the implementing class to cast this back 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class LoopCollection<T> : LoopCollection, IList<T> where T : LoopEntity
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new InvalidCastException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LoopEntities.GetEnumerator();
        }

        public void Add(T item)
        {
            item.LoopEntityDef = Definition;
            LoopEntities.Add(item);
        }

        public void Clear()
        {
            LoopEntities.Clear();
        }

        public bool Contains(T item)
        {
            return LoopEntities.Any(c => c.LoopName == item.LoopName);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LoopEntities.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return LoopEntities.Remove(item);
        }

        public int Count { get; }
        public bool IsReadOnly { get; }
        public int IndexOf(T item)
        {
            return LoopEntities.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            item.LoopEntityDef = Definition;
            LoopEntities.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            LoopEntities.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return base.LoopEntities[index] as T; }
            set { LoopEntities[index] = value; }
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        public override void SetUpDefinition(LoopCollection parentLoopCollection)
        {
            throw new NotImplementedException();
        }

        public LoopCollection(string loopName, string loopNameDescription) : base(loopName, loopNameDescription)
        {
        }
    }

    /// <summary>
    /// The single Loop object that a LoopCollection/LoopCollection is comprised of
    /// There is very little additional data stored here, and is meant only for the Definition/Parsing overload to come later
    /// </summary>
    public abstract class LoopEntity
    { 
        public string LoopName;

        //public LoopCollection SubLoopsList;
        public List<LoopCollection> SubLoopLists;

        public LoopDefinition LoopEntityDef;
        
        public virtual bool Validate() { throw new NotImplementedException(); }
    }

    /// <summary>
    /// A single segment can be repeated, so that single segment needs to be wrapped in a List construct
    /// This will contain our repeats of a single segment
    /// Nmae/Type are elevated to allow for creation and addition of the right type directly into the Segments List
    /// </summary>
    public class SegmentCollection
    {
        protected string SegmentName;
        protected List<baseStdSegment> Segments;
        public SegmentDefinition Definition;
        protected Type BaseType;

        public LoopEntity OwningLoop;

        public SegmentCollection(Type baseType)
        {
            BaseType = baseType;
        }
    }

    /// <summary>
    /// this is the segment at its lowest, typed level
    /// it is fed by the baseFieldValues that represent the actual line of text from an X12 document
    /// when instantiating and populating a segment programatically, this baseFieldValue will not be essential
    /// but may be overriden to store data back into the array to allow for building
    /// </summary>
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

    /// <summary>
    /// this is the line of text from an x12 document
    /// this is the lowest version of the x12 that exists in this framework
    /// </summary>
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
