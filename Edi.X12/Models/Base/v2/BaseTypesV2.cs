using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDI.X12.Enums;
using EDI.X12.Segments;

namespace EDI.X12.Base
{
    /// <summary>
    /// Details about a specific parsing error.  These should be issues when trying to find something to handle a segment and qualification errors.  No other errors should be reported here.
    /// </summary>
    public class ParserError
    {
        /// <summary>
        /// Human friendly erorr message
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Type of error (as enum)
        /// </summary>
        public X12ErrorTypes ErrorType { get; private set; }

        /// <summary>
        /// Where the error occurred (as enum)
        /// </summary>
        public X12ErrorLevel ErrorLevel { get; private set; }

        /// <summary>
        /// What loop was currently being evaluated when the error occurred 
        /// </summary>
        public LoopEntity CurrentLoop { get; private set; }

        /// <summary>
        /// The segment that caused the error
        /// </summary>
        public BaseFieldValues CurrentSegment { get; private set; }

        /// <summary>
        /// Default Ctor - all values must be set here as setters are marked private
        /// </summary>
        /// <param name="errMsg">Human friendly error message</param>
        /// <param name="errType">Type of the error encountered (as enum)</param>
        /// <param name="errLevel">Where the error occurred (as enum)</param>
        /// <param name="currLoop">The current loop being evaluated at time of error</param>
        /// <param name="currentSegmentValues">The segment that caused the error</param>
        public ParserError(string errMsg, X12ErrorTypes errType, X12ErrorLevel errLevel, LoopEntity currLoop, BaseFieldValues currentSegmentValues)
        {
            ErrorMessage = errMsg;
            ErrorType = errType;
            ErrorLevel = errLevel;
            CurrentLoop = currLoop;
            CurrentSegment = currentSegmentValues;
        }
    }

    /// <summary>
    /// This is the class that will hold the characters that delimit particular sections of a x12 line
    /// </summary>
    public class Delimiters
    {
        internal bool isISASet { get; set; }

        public char Segment { get; set; }
        public char Element { get; set; }
        public char Component { get; set; }
        public char Repetition { get; set; } 
    }

    /// <summary>
    /// All versions of an X12 document will inheirt this base
    /// It sets up the header segments that are globally required
    /// It also houses the Delimiters that will be referenced during parsing of line segments and building
    /// </summary>
    public abstract class X12Doc
    {
        private Delimiters _docDelims;

        /// <summary>
        /// Exposes the delimiters for the document.  These are either set by the ISA or forced by the parser
        /// </summary>
        public Delimiters DocDelimiters {
            get
            {
                if (_docDelims!=null && !_docDelims.isISASet && InterchagneControlHeader!=null)
                {
                    if (!string.IsNullOrWhiteSpace(InterchagneControlHeader.ElementSeperator))
                    {
                        _docDelims.Element = InterchagneControlHeader.ElementSeperator[0];
                    }

                    if (!string.IsNullOrWhiteSpace(InterchagneControlHeader.ComponentElementSeparator))
                    {
                        _docDelims.Component = InterchagneControlHeader.ComponentElementSeparator[0];
                    }

                    if (!string.IsNullOrWhiteSpace(InterchagneControlHeader.RepetitionSeparator))
                    {
                        _docDelims.Repetition = InterchagneControlHeader.RepetitionSeparator[0];
                    }

                    if (!string.IsNullOrWhiteSpace(InterchagneControlHeader.LineSeperator))
                    {
                        _docDelims.Segment = InterchagneControlHeader.LineSeperator[0];
                    }
                }

                return _docDelims;
            }
            internal set { _docDelims = value; }
        }

        internal readonly List<LoopCollectionBase> TopLevelLoops = new List<LoopCollectionBase>();
        private readonly List<ParserError> _parsingErrors = new List<ParserError>();

        /// <summary>
        /// Access to the parser errors in the current state
        /// </summary>
        public IReadOnlyCollection<ParserError> ParsingErrors => _parsingErrors.AsReadOnly();

        internal void AddParsingErrors(IEnumerable<ParserError> errors)
        {
            _parsingErrors.AddRange(errors);
        }

        /// <summary>
        /// Single ISA segment as a document is defined by a unique grouping of ISA/GS/ST/BHT
        /// </summary>
        public ISA InterchagneControlHeader { get; set; }

        /// <summary>
        /// Single GS segment as a document is defined by a unique grouping of ISA/GS/ST/BHT
        /// </summary>
        public GS FunctionGroupHeader { get; set; }

        /// <summary>
        /// Single ST segment as a document is defined by a unique grouping of ISA/GS/ST/BHT
        /// </summary>
        public ST TransactionSetHeader { get; set; }

        /// <summary>
        /// Single BHT segment as a document is defined by a unique grouping of ISA/GS/ST/BHT
        /// </summary>
        public BHT BeginHierarchicalTransaction { get; set; }

        /// <summary>
        /// Sinlge SE segment to match the single ST
        /// </summary>
        public SE TransactionSetTrailer { get; set; }

        /// <summary>
        /// Single GE segment to match the single GS
        /// </summary>
        public GE FunctionalGroupTrailer { get; set; }

        /// <summary>
        /// Single IEA segment to match the single ISA
        /// </summary>
        public IEA InterchangeControlTrailer { get; set; }

        internal X12Doc(bool includeDefinition)
        {
            DocDelimiters = new Delimiters
            {
                Element = '*',
                Component = ':',
                Repetition = '^',
                Segment = '~'
            }; 
        }

        internal X12Doc() : this(false) { }

        /// <summary>
        /// How to trigger the definition setup on derived types
        /// </summary>
        internal abstract void SetUpDefinitions();
    }

    /// <summary>
    /// This class wraps the collection of loops, of the same type
    /// Intent is that Individual Loops would inherit from this to create a Loop####XXCollection class
    /// IE Loop2000ACollectionBase
    /// The LoopEntities would then be of type Loop2000A, but it will up to the implementing class to cast this back
    /// This could ahve been made somewhat simpler if this was LoopCollection &lt; T &gt; but that would eliminate the ability to treat all loops as single type "/>
    /// </summary>
    public abstract class LoopCollectionBase
    {
        /// <summary>
        /// the doc this collection belongs to
        /// </summary>
        internal X12Doc OwningX12Doc { get; set; }

        internal LoopCollectionBase ParentLoopCollection { get; set; }

        internal bool SetUpChildDefinitions { get; set; }

        //the instantiated loops (loopEntity objects) of this collection (IE Loop2100A objects)
        internal readonly List<LoopEntity> LoopEntities; 

        /// <summary>
        /// The name of the Loop (IE "Loop2000A")
        /// </summary>
        public string LoopName { get; internal set; }

        /// <summary>
        /// The context specific description of the loop (IE "Infomration Source Level")
        /// </summary>
        public string LoopNameDescription { get; internal set; }

        /// <summary>
        /// Number of times this Loop can repeat - used for validation
        /// </summary>
        public int RepitionLimit { get; internal set; }

        internal List<BaseStdSegment> SegmentDefinitions { get; set; }
        
        internal LoopCollectionBase(string loopName, string loopNameDescription, X12Doc owningDoc, LoopCollectionBase parent)
        {
            SegmentDefinitions = new List<BaseStdSegment>();

            LoopEntities = new List<LoopEntity>();

            OwningX12Doc = owningDoc;

            LoopName = loopName;
            LoopNameDescription = loopNameDescription;

            ParentLoopCollection = parent;

        }

        internal List<BaseStdSegment> IsQualified(BaseFieldValues baseFieldValues, QulificationLevel recursiveCheck)
        {
            var retVal = new List<BaseStdSegment>();

            try
            {
                foreach (BaseStdSegment segmentDefinition in SegmentDefinitions)
                {
                    if(segmentDefinition.IsQualified(baseFieldValues))
                        retVal.Add(segmentDefinition);
                }

                if (recursiveCheck != QulificationLevel.TopMost) //was originally written this way because there was a .Recursive option that was removed.  Leaving like this because more could be added and this would break, seems less likely to break this way
                {
                    if(recursiveCheck==QulificationLevel.FirstChild) recursiveCheck=QulificationLevel.TopMost;

                    //would have to search lower than our current level
                    //can only do this if we are currently working in a loop
                    //if we are, check its child loopCollections as well
                    if (LoopEntities != null && LoopEntities.Any())
                    {
                        foreach (LoopCollectionBase childLoopCollection in LoopEntities.Last().ChildLoopCollections)
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

        internal void Add(LoopEntity loop)
        {
            if (SetUpChildDefinitions)
                loop.SetUpDefinition();

            LoopEntities.Add(loop);
        }

        /// <summary>
        /// Validate all loops in this collection, all segments of those loops, and all child loops associated with these
        /// </summary>
        /// <returns></returns>
        public virtual bool Validate()
        {
            return LoopEntities.All(c => c.Validate());
        }

        /// <summary>
        /// Can't define here because it will rely on the type being passed in T and will just plop a brand new instance in for us
        /// </summary>
        public abstract void Add();

        /// <summary>
        /// Way to trigger definition setup on derived types
        /// </summary>
        internal abstract void SetUpDefinition();
    }

    /// <summary>
    /// Since LoopCollection had to be completely generic, this class allows for typing it dynamically
    /// While still retaining the ability to group all loops as a single generic type of LoopCollection
    /// Intent is that Individual Loops would inherit from this to create a Loop####XXCollection class
    /// IE Loop2000ACollectionBase
    /// The LoopEntities would then be of type Loop2000A, but it will up to the implementing class to cast this back 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class LoopCollection<T> : LoopCollectionBase, IList<T> where T : LoopEntity
    {
        /// <summary>
        /// Default GetEnumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            var retVal = new List<T>(LoopEntities.Count);
            retVal.AddRange(LoopEntities.Select(loopEntity => loopEntity as T));

            return retVal.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return LoopEntities.GetEnumerator();
        }

        void ICollection<T>.Add(T item)
        { 
            LoopEntities.Add(item);
        }

        void ICollection<T>.Clear()
        {
            LoopEntities.Clear();
        }

        /// <summary>
        /// Default contains - checks soley based on LoopEntity.LoopName
        /// </summary>
        /// <param name="item">LoopEntity type to check for in the collection - specifically uses LoopName to determine existance</param>
        /// <returns>True if this collection contains a LoopName that matches</returns>
        bool ICollection<T>.Contains(T item)
        {
            return (item.GetType().Name == LoopName);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            LoopEntities.CopyTo(array.Cast<LoopEntity>().ToArray(), arrayIndex);
        }

        bool ICollection<T>.Remove(T item)
        {
            return LoopEntities.Remove(item);
        }

        public int Count => LoopEntities.Count;
        public bool IsReadOnly => false;
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

        internal LoopCollection(string loopName, string loopNameDescription, X12Doc owningDoc, LoopCollectionBase parent) 
            : base(loopName, loopNameDescription, owningDoc, parent)
        {
        } 

        /// <summary>
        /// Insert a new instance of LoopEntity of derived type T into the collection
        /// </summary>
        public override void Add()
        {
            var l = (T) Activator.CreateInstance(typeof(T), OwningX12Doc, LoopEntities.LastOrDefault(), this);

            if (SetUpChildDefinitions)
                l.SetUpDefinition();

            LoopEntities.Add(l);
        } 

    }

    /// <summary>
    /// The single Loop object that a LoopCollection/LoopCollectionBase is comprised of
    /// There is very little additional data stored here, and is meant only for the Definition/Parsing overload  
    /// </summary>
    public abstract class LoopEntity
    { 
        /// <summary>
        /// Reference to X12 Doc this LoopEntity belongs to, just a re-direct to ParentLoopColleciton.OwningX12Doc
        /// </summary>
        internal X12Doc OwningDoc => ParentLoopCollection.OwningX12Doc;

        /// <summary>
        /// The collection that owns this specific loop instance
        /// </summary>
        internal LoopCollectionBase ParentLoopCollection { get; set; }

        /// <summary>
        /// All child loop collection contained in this specific loop instance (IE Loop2100ACollection that is part of a given Loop2000A)
        /// </summary>
        internal List<LoopCollectionBase> ChildLoopCollections { get; set; }

        /// <summary>
        /// Checks to see this loop contains a definition to handle a given BaseFieldValue (segment line)
        /// </summary>
        /// <param name="baseFieldValues">segment line from the segment stream class</param>
        /// <param name="recursiveCheck">how far down the heirarchy to look (only segments in this loop, or include first level of children loops)</param>
        /// <returns>Any handlers that qualify for the given segment line.  Should only be one, but needs to be checked and Count!=1 instances should be hanlded accordingly</returns>
        internal List<BaseStdSegment> IsQualified(BaseFieldValues baseFieldValues, QulificationLevel recursiveCheck)
        {
            return ParentLoopCollection.IsQualified(baseFieldValues, recursiveCheck);
        }

        /// <summary>
        /// Consolidated list of all SegmentCollections, any child SegmentCollections have to be added here so they can be accessed programatically without reflection
        /// </summary>
        internal List<SegmentCollection> SegmentCollections { get; set; }

        /// <summary>
        /// Validate all instances of this loop, all segments in each loop, all child loops and subsequent segments within them
        /// </summary>
        /// <returns></returns>
        public virtual bool Validate()
        {
            //todo finish this validation code
            bool retVal = ChildLoopCollections.All(c => c.Validate());  

            retVal = retVal && SegmentCollections.All(c => c.Segments.All(d => d.Validate()));

            return retVal;
        }

        private LoopEntity()
        {
            ChildLoopCollections = new List<LoopCollectionBase>();
            SegmentCollections = new List<SegmentCollection>();
        }

        /// <summary>
        /// Default Ctor
        /// </summary>
        /// <param name="parent">What LoopCollection owns this</param>
        internal LoopEntity(LoopCollectionBase parent) : this()
        { 
            ParentLoopCollection = parent; 
        } 

        /// <summary>
        /// Mechanism to setup the definition for this loop, its segments, and its children
        /// </summary>
        internal virtual void SetUpDefinition()
        { 
            foreach (LoopCollectionBase childLoop in ChildLoopCollections)
            {
                childLoop.SetUpDefinition();
            }

            foreach (SegmentCollection segmentCollection in SegmentCollections)
            {
                segmentCollection.SegmentDefinition =ParentLoopCollection.SegmentDefinitions.First(c => c.SegmentDefinitionName == segmentCollection.SegmentDefinitionName);
            }
        } 

        /// <summary>
        /// Add a segment its specific collection based on IsQualified handler
        /// </summary>
        /// <param name="segment"></param>
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
        /// <summary>
        /// All of the segments in this collection
        /// </summary>
        public List<BaseStdSegment> Segments { get; set; } 

        /// <summary>
        /// Internally used for determining if a segment collection is the right home for a segment line
        /// </summary>
        internal BaseStdSegment SegmentDefinition { get; set; }

        /// <summary>
        /// What loop entity does this collection belong to.
        /// </summary>
        internal LoopEntity OwningLoopEntity { get; set; }

        /// <summary>
        /// Name of the loop (IE Loop2000A)
        /// </summary>
        internal string SegmentDefinitionName { get; set; }

        /// <summary>
        /// How many instance of the derived segment can we have - used for validation
        /// </summary>
        internal int RepititionLimit { get; set; }

        private SegmentCollection()
        {
            Segments = new List<BaseStdSegment>();
        }


        /// <summary>
        /// Default Ctor 
        /// </summary>
        /// <param name="owningLoopEntity">the LoopEntity that holds this collection of segments</param>
        /// <param name="segDefName">the name of the loop (IE Loop2000A) usually passed down from the owning loop entity</param>
        internal SegmentCollection(LoopEntity owningLoopEntity, string segDefName):this()
        { 
            OwningLoopEntity = owningLoopEntity;
            SegmentDefinitionName = segDefName;
        }

        /// <summary>
        /// Add a specific instance of a the derived type to the collection
        /// </summary>
        /// <param name="segment">base segment</param>
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
    public abstract class BaseStdSegment : SegmentDefinition
    {
        #region SegDef
        /// <summary>
        /// What loop collection owns this.  While it may make more sense to keep track of the SegmentCollection instead, those collections would not yet be initialized
        /// </summary>
        internal LoopCollectionBase OwningLoopCollection { get; set; }

        /// <summary>
        /// Determine whether this can be the imputus to start a new loop.  
        /// If this segment is chosen and lives in a child loop that is not yet started, there will be a parse erorr generated.  
        /// It is possilbe to have multiple segments within a loop be designated "LoopStarter"
        /// </summary>
        internal bool IsLoopStarter { get; set; }

        /// <summary>
        /// Name of this segment
        /// </summary>
        internal string SegmentDefinitionName { get; set; }

        /// <summary>
        /// Qualifiers to determine if this segment instance can handle a given segment line
        /// </summary>
        internal List<SegmentQualifiers> SegmentQualifierValues { get; set; }

        /// <summary>
        /// Populate the backing field for the actual values of the segment.
        /// This is necessary as we will clone a copy of the segment definintion to insert it during pasing
        /// </summary>
        /// <param name="baseVals"></param>
        internal override void Populate(BaseFieldValues baseVals)
        {
            FieldValues = baseVals;
        }

        /// <summary>
        /// Determine whether this specific segment type could handle a given segment line
        /// </summary>
        /// <param name="segmentFields">extraced segment line value</param>
        /// <returns>True if this definition matches the given segment line</returns>
        internal override bool IsQualified(BaseFieldValues segmentFields)
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

        /// <summary>
        /// Factory to create an instance of this segment and populate it with the given segment line data
        /// </summary>
        /// <param name="bsf">segment line data</param>
        /// <returns>newly created segment instance</returns>
        internal override BaseStdSegment CreateBaseStdSegment(BaseFieldValues bsf)
        {
            var obj = (BaseStdSegment)this.MemberwiseClone();
            obj.Populate(bsf);

            return obj;
        }

        #endregion 

        #region SegDefANDBase
        /// <summary>
        /// Syntax rules that have to be run against the completed segment - used for valdiation
        /// </summary>
        internal List<string> SyntaxRules { get; set; }

        /// <summary>
        /// Segment Required/option/mandatory - used for validation
        /// </summary>
        internal SegmentUsageTypeNames SegmentUsage { get; set; }

        /// <summary>
        /// How is each field used in the segment - used for validation
        /// </summary>
        internal List<FieldUsageTypeNames> FieldUsage { get; set; }
        
        /// <summary>
        /// Trigger validation for this segment
        /// </summary>
        /// <returns></returns>
        public override bool Validate()
        {
            var retVal = true;

            foreach (var qualVal in SegmentQualifierValues)
            {
                retVal = retVal && qualVal.IsQaulified(FieldValues);
            }

            //todo add moar

            return retVal;
        }
        #endregion

        private BaseFieldValues FieldValues { get; set; } 

        /// <summary>
        /// Preps backing fields without needing the segment line to populate it
        /// Should only be called by derived members inside this project
        /// </summary>
        internal BaseStdSegment()
        {
            SegmentQualifierValues = new List<SegmentQualifiers>();
            SyntaxRules = new List<string>();

            FieldValues = new BaseFieldValues(new List<string>() { this.GetType().Name });
            FieldUsage = new List<FieldUsageTypeNames>();
        }

        /// <summary>
        /// Must pass values to populate the fields of the segment
        /// </summary>
        /// <param name="values">field values, in order</param>
        internal BaseStdSegment(IEnumerable<string> values):this()
        {
            IEnumerable<string> enumerable = values as IList<string> ?? values.ToList();

            if(values==null || !enumerable.Any()) throw new NullReferenceException("field values can't be null or empty");

            FieldValues = new BaseFieldValues(enumerable.ToList());
            FieldUsage= new List<FieldUsageTypeNames>(enumerable.Count());
        }

        /// <summary>
        /// Must use this to grab values from the backing field, so if there is nothing there, we can fill the list with null references because it is possible we get too few entries in our segment line
        /// </summary>
        /// <param name="index">which field index to return</param>
        /// <returns>the value at the specific index of this backing field of the segment line</returns>
        internal string GetFieldValue(int index)
        {
            if (FieldValues.Count > index)
            {
                return FieldValues[index];
            }

            return null;
        }

        /// <summary>
        /// Set a specific value for the backing field, must use this incase the index is outside the array we have, because it is possible to have only gotten a subset of the total fields available
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        internal void SetFieldValue(int index, string value)
        {
            if (FieldValues.Count < index+1)
            {
                FieldValues.Capacity = index+5;

                while (FieldValues.Count < index+1)
                {
                    FieldValues.Add(null);
                }
            }

            FieldValues[index] = value;
        }

        /// <summary>
        /// Write this out as a string
        /// Will attempt to use the delimiters contained in the owning X12Doc but will 
        /// </summary>
        /// <returns>The properly formatted segment line that can be written to an x12 file directly</returns>
        public override string ToString()
        {
            if (OwningLoopCollection != null && OwningLoopCollection.OwningX12Doc != null && OwningLoopCollection.OwningX12Doc.DocDelimiters.Element > 0)
                return string.Join(OwningLoopCollection.OwningX12Doc.DocDelimiters.Element.ToString(), FieldValues);

            return string.Join("*", FieldValues);
        } 
    }

    /// <summary>
    /// this is the line of text from an x12 document
    /// this is the lowest version of the x12 that exists in this framework
    /// </summary>
    public class BaseFieldValues : List<string>
    {
        /// <summary>
        /// The original segment line text
        /// </summary>
        public string RawValue { get; private set; } 


        /// <summary>
        /// Create by passing an already split list of values to populate the backing field
        /// </summary>
        /// <param name="values"></param>
        internal BaseFieldValues(IEnumerable<string> values)
        {
            this.AddRange(values);
        }


        /// <summary>
        /// for use only by the parser when reading in the start of a file
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <param name="elementSep"></param>
        /// <param name="compSep"></param>
        internal BaseFieldValues(byte[] buffer, int offset, int length, byte elementSep, string compSep)
        {
            RawValue = Encoding.Default.GetString(buffer, offset, length);

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
