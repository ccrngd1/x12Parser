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
    public abstract class X12Doc
    {
        private const string firstDelim = "*";
        private const string secondDelim = "#";

        public Delimiters DocDelimiters = new Delimiters();

        public List<LoopCollection> TopLevelLoops = new List<LoopCollection>();

        [ProtoBuf.ProtoMember(1)]
        public ISA InterchagneControlHeader = new ISA();
        [ProtoBuf.ProtoMember(2)]
        public GS FunctionGroupHeader = new GS();

        [ProtoBuf.ProtoMember(1)]
        public ST TransactionSetHeader = new ST();
        [ProtoBuf.ProtoMember(2)]
        public BHT BeginHierarchicalTransaction = new BHT();
        [ProtoBuf.ProtoMember(3)]
        public SE TransactionSetTrailer = new SE();

        [ProtoBuf.ProtoMember(3)]
        public GE FunctionalGroupTrailer = new GE();
        [ProtoBuf.ProtoMember(4)]
        public IEA InterchangeControlTrailer = new IEA();

        public X12Doc(bool includeDefinition)
        {
        }

        public abstract void SetUpDefinitions();
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
        //the doc this collection belongs to
        public X12Doc OwningX12Doc { get; set; }

        public LoopCollection ParentLoopCollection { get; set; }

        public bool SetUpChildDefinitions { get; set; }

        //remove this - it was intended for checking seg qualifiers further down the stack
        //this isnt needed tho, since at any time we have a LoopEntity in our parser state, this means that entity already has its possible LoopCollections with their own SegmentDefs
        //this does requires we keep track of how we got to our currently LoopEntity (parent loopEntity obj in parser most likely)
        //public List<LoopCollection> ChildLoopCollection;

        //the instantiated loops (loopEntity objects) of this collection (IE Loop2100A objects)
        public List<LoopEntity> LoopEntities; 

        public string LoopName;
        public string LoopNameDescription;
        public int RepitionLimit;

        public List<BaseStdSegment> SegmentDefinitions { get; set; }


        //todo: still useful?
        private LoopCollection _next;
        public LoopCollection NextCollection
        {
            get { return _next; }
            set
            {
                if (_next == null)
                    _next = null;
                else
                    throw new AccessViolationException("Next Collection already set");
            }
        }

        //todo: still useful?
        public LoopCollection _prev;
        public LoopCollection PrevCollection
        {
            get { return _prev; }
            set
            {
                if (_prev == null)
                    _prev = value;
                else 
                    throw new AccessViolationException("Previous Collection already set"); 
            }
        }

        public LoopCollection(string loopName, string loopNameDescription, X12Doc owningDoc, int repLimit, LoopCollection parent, LoopCollection prev)
        {
            SegmentDefinitions = new List<BaseStdSegment>();

            LoopEntities = new List<LoopEntity>();

            OwningX12Doc = owningDoc;

            LoopName = loopName;
            LoopNameDescription = loopNameDescription;

            RepitionLimit = repLimit;

            ParentLoopCollection = parent;
            _prev = prev;

            if(_prev != null)
                _prev.NextCollection = this;
        }
         
        public abstract bool Validate();

        public abstract void SetUpDefinition();

        public List<BaseStdSegment> IsQualified(baseFieldValues baseFieldValues, QulificationLevel recursiveCheck)
        {
            var retVal = new List<BaseStdSegment>();

            try
            {
                foreach (BaseStdSegment segmentDefinition in SegmentDefinitions)
                {
                    if(segmentDefinition.IsQualified(baseFieldValues))
                        retVal.Add(segmentDefinition);
                }

                if (recursiveCheck != QulificationLevel.TopMost)
                {
                    if(recursiveCheck==QulificationLevel.FirstChild) recursiveCheck=QulificationLevel.TopMost;

                    //we would have to search lower than our current level
                    //can only do this if we are currently working in a loop
                    //if we are, check its child loopCollections as well
                    if (LoopEntities != null && LoopEntities.Any())
                    {
                        foreach (var childLoopCollection in LoopEntities.Last().ChildLoopCollections)
                        {
                            retVal.AddRange(childLoopCollection.IsQualified(baseFieldValues,recursiveCheck));
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                //todo srsly, how are we handling these here errors
            }

            return retVal;
        }



        public abstract void Add(LoopEntity loop);

        public abstract void Add();
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

        public LoopCollection(string loopName, string loopNameDescription, X12Doc owningDoc, int repLimit, LoopCollection parent, LoopCollection prev) : base(loopName, loopNameDescription, owningDoc, repLimit, parent, prev)
        {
        }

        public override void Add(LoopEntity loop)
        {
            if(SetUpChildDefinitions)
                loop.SetUpDefinition(SegmentDefinitions);

            LoopEntities.Add(loop);
        }

        public override void Add()
        {
            var l = (T) Activator.CreateInstance(typeof(T), OwningX12Doc, LoopEntities.LastOrDefault(), this);

            if (SetUpChildDefinitions)
                l.SetUpDefinition(SegmentDefinitions);

            LoopEntities.Add(l);
        } 

    }

    /// <summary>
    /// The single Loop object that a LoopCollection/LoopCollection is comprised of
    /// There is very little additional data stored here, and is meant only for the Definition/Parsing overload to come later
    /// </summary>
    public abstract class LoopEntity
    {
        public string LoopName { get; set; }

        public int Index { get; set; }

        public X12Doc OwningDoc { get; set; }

        //todo: still useful?
        public LoopEntity PreviousLoop { get; set; }

        //todo: still useful?
        public LoopEntity NextLoop { get; set; }

        public LoopCollection ParentLoopCollection { get; set; }

        public List<LoopCollection> ChildLoopCollections { get; set; }

        public List<BaseStdSegment> SegmentDefinitions => ParentLoopCollection.SegmentDefinitions;

        public List<BaseStdSegment> IsQualified(baseFieldValues baseFieldValues, QulificationLevel recursiveCheck)
        {
            return ParentLoopCollection.IsQualified(baseFieldValues, recursiveCheck);
        }

        public List<SegmentCollection> SegmentCollections { get; set; }

        public virtual bool Validate()
        {
            throw new NotImplementedException();
        }

        private LoopEntity()
        {
            ChildLoopCollections = new List<LoopCollection>();
            SegmentCollections = new List<SegmentCollection>();
        }

        public LoopEntity(X12Doc owningDoc, LoopEntity prev, LoopCollection parent) : this()
        {
            OwningDoc = owningDoc;
            PreviousLoop = prev;
            ParentLoopCollection = parent;

            Index = ParentLoopCollection.LoopEntities.Count;
        } 

        public void SetUpDefinition(List<BaseStdSegment> segDef)
        { 
            foreach (var childLoop in ChildLoopCollections)
            {
                childLoop.SetUpDefinition();
            }
        } 

        public void Add(BaseStdSegment segment)
        { 
            List<SegmentCollection> handlers = SegmentCollections
                .Where(c => c.SegmentDefinition.SegmentDefinitionName == segment.SegmentDefinitionName).ToList();

            if (handlers.Any())
            {
                handlers[0].Add(segment);
            }
            else
            {
                //todo: what to do with these pesky errors
                Console.WriteLine("should have had somethign to handle this");
            }
        }
    }

    /// <summary>
    /// A single segment can be repeated, so that single segment needs to be wrapped in a List construct
    /// This will contain our repeats of a single segment
    /// Nmae/Type are elevated to allow for creation and addition of the right type directly into the Segments List
    /// </summary>
    public abstract class SegmentCollection
    {
        public List<BaseStdSegment> Segments { get; set; }

        //todo: do we still need this?
        public Type BaseType { get; set; }

        public BaseStdSegment SegmentDefinition { get; set; } 

        public LoopEntity OwningLoopEntity { get; set; }

        private SegmentCollection()
        {
            Segments = new List<BaseStdSegment>();
        }

        public SegmentCollection(Type baseType, LoopEntity owningLoopEntity, BaseStdSegment segmentDef):this()
        {
            BaseType = baseType;
            OwningLoopEntity = owningLoopEntity;
            SegmentDefinition = segmentDef;
        }

        public void Add(BaseStdSegment segment)
        {
            Segments.Add(segment);
        }
    }

    /// <summary>
    /// this is the segment at its lowest, typed level
    /// it is fed by the baseFieldValues that represent the actual line of text from an X12 document
    /// when instantiating and populating a segment programatically, this baseFieldValue will not be essential
    /// but may be overriden to store data back into the array to allow for building
    /// </summary>
    public abstract class BaseStdSegment : ISegmentDefinition
    { 
        public baseFieldValues FieldValues{get;set;}
        
        /// <summary>
        /// only for seg def usage
        /// </summary>
        public LoopCollection OwningLoopCollection { get; set; }

        /// <summary>
        /// only for seg def usage
        /// </summary>
        public bool IsLoopStarter { get; set; }

        public string SegmentDefinitionName { get; set; }

        public SegmentCollection OwningSegmentCollection { get; set; }

        public string SegmentName
        {
            get
            {
                if (!FieldValues.Any()) return null;
                return FieldValues[0];
            }
        }

        public BaseStdSegment()
        {
            SegmentQualifierValues = new List<SegmentQualifiers>();
        }

        //todo: probably won't need this any longer
        //public BaseStdSegment(baseFieldValues bsf)
        //{
        //    FieldValues = bsf;
        //}

        public BaseStdSegment(List<string> values):this()
        {
            FieldValues.AddRange(values);
        }

        public void Populate(baseFieldValues baseVals)
        {
            FieldValues = baseVals;
        }
        public abstract bool Validate();

        public List<SegmentQualifiers> SegmentQualifierValues { get; set; }

        public bool IsQualified(baseFieldValues segmentFields)
        {
            try
            {
                bool retVal = string.Equals(this.GetType().Name, segmentFields[0],
                    StringComparison.CurrentCultureIgnoreCase);

                foreach (var qualVal in SegmentQualifierValues)
                {
                    retVal = retVal && qualVal.IsQaulified(segmentFields);
                }

                return retVal;
            }
            catch (Exception ex)
            {
                //todo what are we doing???
            }

            return false;
        }

        public string GetFieldValue(int index)
        {
            if (FieldValues.Count > index)
            {
                return FieldValues[index];
            }

            return null;
        }

        public void SetFieldValue(int index, string value)
        {
            if (FieldValues.Count < index)
            {
                FieldValues.Capacity = index+1;
            }

            FieldValues[index] = value;
        }

        public BaseStdSegment CreateBaseStdSegment(baseFieldValues bsf)
        {
            var obj = (BaseStdSegment)this.MemberwiseClone();
            obj.Populate(bsf);

            return obj;
        }
    }

    /// <summary>
    /// this is the line of text from an x12 document
    /// this is the lowest version of the x12 that exists in this framework
    /// </summary>
    public class baseFieldValues : List<string>
    {
        public string RawValue { get; private set; }

        public baseFieldValues(List<string> values)
        {

        }

        public baseFieldValues(byte[] buffer, int offset, int length, byte elementSep, string compSep)
        {
            RawValue = System.Text.Encoding.Default.GetString(buffer, offset, length);

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
