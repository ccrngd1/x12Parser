using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LawsonCS.Model.EDI.X12.v1;

namespace LawsonCS.Model.EDI.X12.v1.Base
{
    [ProtoBuf.ProtoContract]
    public class LoopList<T> : List<T>
    {
        [ProtoBuf.ProtoMember(1)]
        public int LoopRepeat;
    }

    public class SegmentDefinition
    {
        public string SegmentName;

        public List<SegmentQualifiers> Qualifiers = new List<SegmentQualifiers>();
        public SegmentUsageType Usage;
        public int RepeatCount;
        private List<Func<List<string>, bool>> _addlQualifierLogic = new List<Func<List<string>, bool>>();
        private Type SegmentType;
        private Delimiters Delimiter;

        public SegmentDefinition(List<SegmentQualifiers> quals, SegmentUsageType use, int reps, Type segT)
        {
            if (quals != null)
                Qualifiers = quals;

            Usage = use;
            RepeatCount = reps;
            SegmentType = segT;
            SegmentName = segT.GetType().Name;
        }

        public baseStdSegment CreateInstance(string value, Delimiters delims, LoopsList parentLoop)
        {
            var sg = (baseStdSegment)Activator.CreateInstance(SegmentType);

            sg.Prep(value, parentLoop, delims, this);
            //RawSegments.Add(sg.rawSegment);
            return sg;
        }

        public void AddQualifierLogic(Func<List<string>, bool> qualLogic)
        {
            _addlQualifierLogic.Add(qualLogic);
        }

        public bool IsQualified(List<string> segmentValues)
        {
            if (segmentValues[0] != SegmentName) return false;

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

    public class RawSegment
    {
        protected string ParsedValue;
        private Delimiters delimiters;
        public LoopsList ParentLoopsList;
        public baseLoop ParentLoop;

        public SegmentDefinition DefiningSegment;

        public List<List<string>> FieldValues { get; private set; }

        public RawSegment(string value, Delimiters delims, LoopsList parentLoop, SegmentDefinition def)
        {
            FieldValues = new List<List<string>>();
            ParsedValue = value;
            delimiters = delims;
            ParentLoopsList = parentLoop;
            ParentLoop = parentLoop?.Last();
            DefiningSegment = def;

            var firstSplit = value.Split(delims.Element);

            foreach (string s in firstSplit)
            {
                var subs = new List<string>();
                if (s.Contains(delims.SubElement))
                {
                    subs = s.Split(delims.SubElement).ToList();
                }
                else
                {
                    subs.Add(s);
                }

                FieldValues.Add(subs);
            }
        }

    }

    public abstract class baseStdSegment
    {
        public RawSegment rawSegment;
        public LoopsList ParentLoops;
        public baseLoop ParentLoop;
        private Delimiters Delimiter;
        public SegmentDefinition DefinedSeg;

        public baseStdSegment()
        {
        }

        public baseStdSegment(string value, LoopsList parentLoop, Delimiters delims, SegmentDefinition def)
        {
            Prep(value, parentLoop, delims, def);
        }

        public void Prep(string value, LoopsList parentLoop, Delimiters delims, SegmentDefinition def)
        {
            ParentLoops = parentLoop;
            Delimiter = delims;
            DefinedSeg = def;
            ParentLoop = ParentLoops?.Last();

            rawSegment = new RawSegment(value, Delimiter, ParentLoops, DefinedSeg);
        }

        //public baseStdSegment(string value, Delimiters delims, LoopsList parentLoop)
        //{ 
        //    delimiters = delims;
        //    SetValue(value);
        //    ParentLoopsList = parentLoop;
        //    ParentLoop = parentLoop.Last();
        //} 

        //public void Prep(string value, Delimiters delims, LoopsList parentLoop)
        //{
        //    delimiters = delims;
        //    SetValue(value);
        //    ParentLoopsList = parentLoop;
        //    ParentLoop = parentLoop.Last();
        //}

        //public void SetValue(string value)
        //{
        //    ParsedValue = value; 
        //    FieldValues = ParsedValue.Split(delimiters.Element).ToList();
        //    Populate();
        //}

        public abstract void Populate();

        public abstract bool Validate();

        public abstract string ToString();
    }

    public class Delimiters
    {
        public char Segment { get; set; }
        public char Element { get; set; }
        public char SubElement { get; set; }
        public char Repetition { get; set; }
        public string Line { get; set; }
    }

    public abstract class SegList<T> : List<baseStdSegment>
    {

    }

    public abstract class LoopsList : List<baseLoop>
    {
        public int LoopRepeat;
        public string LoopName;
        public LoopsList Parent;
        public List<LoopsList> SubLoops = new List<LoopsList>();
        public List<SegmentDefinition> SegmentDefinitions = new List<SegmentDefinition>();
        public List<baseStdSegment> Segments = new List<baseStdSegment>();

        public LoopsList(LoopsList parent, int repeats, string name)
        {
            Parent = parent;
            LoopRepeat = repeats;
            LoopName = name;
            DefineSegmentDefinition();
        }

        public SegmentDefinition StartingSegment
        {
            get { return SegmentDefinitions[0]; }
        }

        public abstract void DefineSegmentDefinition();

        //public virtual void DefineSegments();
    }

    public class baseLoop
    {
        public List<baseStdSegment> Segments = new List<baseStdSegment>();
        public LoopsList Parent;

        public baseStdSegment StartingSegment
        {
            get { return Segments.FirstOrDefault(); }
        }

        public baseLoop(LoopsList parent)
        {
            Parent = parent;
        }
    }


    public class X12Error
    {
        public X12ErrorTypes ErrorType;
        public X12ErrorLevel ErrorLevel;
        public string SegmentText;
        public int DocumentLine;
        public string CurrentLoopName;
    }

    [ProtoBuf.ProtoContract]
    public class X12DocumentBase
    {
        protected Delimiters delimiters = new Delimiters();

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

        [ProtoBuf.ProtoMember(7)]
        public SE transactionSetTrailer;

        [ProtoBuf.ProtoMember(8)]
        protected List<LoopsList> Loops = new List<LoopsList>();

        private List<SegmentDefinition> EnvelopseDefinitions = new List<SegmentDefinition>(7);

        public List<X12Error> Errors = new List<X12Error>();

        public X12DocumentBase()
        {
            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers>(),
                                                        SegmentUsageType.Required,
                                                        1, typeof(ISA)));

            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers>(),
                                                        SegmentUsageType.Required,
                                                        1, typeof(GS)));

            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "0019") },
                                                        SegmentUsageType.Required,
                                                        1, typeof(BHT)));

            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> { new SegmentQualifiers(1, "837") },
                                                        SegmentUsageType.Required,
                                                        1, typeof(ST)));

            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers>(),
                                                        SegmentUsageType.Required,
                                                        1, typeof(GE)));

            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers>(),
                                                        SegmentUsageType.Required,
                                                        1, typeof(SE)));

            EnvelopseDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers>(),
                                                        SegmentUsageType.Required,
                                                        1, typeof(IEA)));
        }

        private LoopSegment FindSingleDefMatch(LoopsList currentLoopList, List<string> segSplit,
            string segText, ref int docLine)
        {
            LoopSegment retVal = null;

            List<LoopSegment> possibleSegmentMatches = new List<LoopSegment>();

            if (currentLoopList == null) //this should be envelope segments
            {
                var segMatch = new LoopSegment
                {
                    OwningLoop = null,
                    QualifiedSegments = EnvelopseDefinitions.Where(c => c.IsQualified(segSplit)).ToList()
                };

                if (segMatch.QualifiedSegments.Any())
                {
                    retVal = segMatch;
                    return retVal;
                }
            }

            possibleSegmentMatches.AddRange(FindQualifiedSegments(segSplit));


            if (possibleSegmentMatches == null || !possibleSegmentMatches.Any())
            {
                Errors.Add(new X12Error
                {
                    DocumentLine = docLine,
                    ErrorLevel = X12ErrorLevel.Loop,
                    ErrorType = X12ErrorTypes.NotDefined,
                    SegmentText = segText,
                    CurrentLoopName = currentLoopList?.LoopName,
                });
            }

            List<LoopSegment> thisLoopMatches = null;

            if (currentLoopList != null && possibleSegmentMatches.Count() != 1)
            {
                //first find segments that are in the same loop
                thisLoopMatches =
                    possibleSegmentMatches.Where(c => c.OwningLoop.LoopName == currentLoopList.LoopName).ToList();

                if (thisLoopMatches.Count != 1)
                {
                    thisLoopMatches =
                        possibleSegmentMatches.Where(c => c.OwningLoop.StartingSegment.SegmentName == segSplit[0])
                            .ToList();

                    //see if the parent of one of our matches is the same as the loop we are in now
                    if (thisLoopMatches.Count != 1)
                    {
                        thisLoopMatches =
                            thisLoopMatches.Where(
                                c => c.OwningLoop.Parent.LoopName == currentLoopList.LoopName).ToList();
                    }

                    //maybe this is the start of another sub loop within the same parent loop
                    if (thisLoopMatches.Count != 1 && currentLoopList.Parent != null)
                    {
                        thisLoopMatches =
                            possibleSegmentMatches.Where(c => c.OwningLoop.StartingSegment.SegmentName == segSplit[0])
                                .ToList();

                        thisLoopMatches = thisLoopMatches.Where(c =>
                                    currentLoopList.Parent[0].Parent.LoopName ==
                                    c.OwningLoop.Parent.LoopName).ToList();
                    }

                    //it could be that this loop exists in 2 subloops that defined the same (IE 837.2000B.2300-ClmInfo and 837.2000C.2300-ClmInfo)
                    if (thisLoopMatches.Count != 1 && currentLoopList.Parent != null)
                    {
                        thisLoopMatches =
                            possibleSegmentMatches.Where(
                                c => c.OwningLoop.Parent.LoopName == currentLoopList.Parent.LoopName).ToList();
                    }
                }
            }
            //if the current loop is null but we have possibleSegment out of the Find function
            //this should a start segment for our first loop
            else if (currentLoopList == null && possibleSegmentMatches.Count == 1
                && possibleSegmentMatches[0].OwningLoop.StartingSegment.SegmentName == segSplit[0])
            {
                thisLoopMatches = possibleSegmentMatches;
            }
            else if (currentLoopList != null && possibleSegmentMatches.Count == 1)
            {
                thisLoopMatches = possibleSegmentMatches;
            }

            if (thisLoopMatches != null && thisLoopMatches.Count == 1)
                retVal = thisLoopMatches[0];

            if (possibleSegmentMatches.Count > 1 && (thisLoopMatches == null || thisLoopMatches.Count != 1))
            {
                Errors.Add(new X12Error
                {
                    DocumentLine = docLine,
                    ErrorLevel = X12ErrorLevel.Loop,
                    ErrorType = X12ErrorTypes.MultipleDefintions,
                    SegmentText = segText,
                    CurrentLoopName = currentLoopList?.LoopName,
                });
            }

            return retVal;
        }

        public void FromStream(Stream s)
        {
            ExtractDelimiterInfo(s);

            head = tail = 0;
            buffer = new byte[BufferSize];
            EndOfFile = false;

            int docLine = 1;

            var segText = ReadNextLine(s);

            LoopsList currentLoopList = null;
            LoopsList previousLoopList = null;

            while (segText != null)
            {
                List<string> segSplit = segText.Split(delimiters.Element).ToList();

                LoopSegment foundDef = FindSingleDefMatch(currentLoopList, segSplit, segText, ref docLine);

                if (foundDef != null)
                {
                    if (currentLoopList != null && foundDef.OwningLoop != null &&
                        currentLoopList.LoopName != foundDef.OwningLoop.LoopName)
                    {
                        previousLoopList = currentLoopList;
                    }

                    if ((currentLoopList == null && foundDef.OwningLoop != null) ||
                        (currentLoopList != null && foundDef.OwningLoop != null &&
                        currentLoopList.LoopName != foundDef.OwningLoop.LoopName))
                    {
                        currentLoopList = foundDef.OwningLoop;
                        currentLoopList.Add(new baseLoop(currentLoopList));
                    }

                    //if (thisLoopMatches == null || !thisLoopMatches.Any() || thisLoopMatches.Count() > 1)
                    //    thisLoopMatches = possibleSegmentMatches;

                    baseStdSegment newSegInst = foundDef.QualifiedSegments[0].CreateInstance
                        (segText, delimiters, foundDef.OwningLoop);

                    if (!newSegInst.Validate())
                    {
                        Errors.Add(new X12Error
                        {
                            DocumentLine = docLine,
                            ErrorLevel = X12ErrorLevel.Segment,
                            ErrorType = X12ErrorTypes.ValidationFailed,
                            SegmentText = segText,
                            CurrentLoopName = currentLoopList?.LoopName,
                        });
                    }
                }

                segText = ReadNextLine(s);
                docLine++;
            }
        }

        private class LoopSegment
        {
            public LoopsList OwningLoop;
            public List<SegmentDefinition> QualifiedSegments;
        }

        private List<LoopSegment> FindQualifiedSegments(List<string> segSplit)
        {
            return FindQualifiedSegmentsRecursive(segSplit, Loops);
        }

        private List<LoopSegment> FindQualifiedSegmentsRecursive(List<string> segSplit, List<LoopsList> loopsList)
        {
            List<LoopSegment> retVal = new List<LoopSegment>();

            foreach (var lls in loopsList)
            {
                List<SegmentDefinition> possibleSegs = lls.SegmentDefinitions.Where(c => c.IsQualified(segSplit)).ToList();

                if (possibleSegs.Any())
                    retVal.Add(new LoopSegment { OwningLoop = lls, QualifiedSegments = possibleSegs });

                retVal.AddRange(FindQualifiedSegmentsRecursive(segSplit, lls.SubLoops));
            }

            return retVal;
        }

        private void ExtractDelimiterInfo(Stream s)
        {
            var original = s.Position;
            if (s.Length - s.Position < 106)
                return;// throw new Exception("Invalid ISA");
            byte[] valueBuffer = new byte[107];
            s.Read(valueBuffer, 0, 107);
            //  s.Read(valueBuffer, 0, 4);
            if (valueBuffer[0] == (byte)'I' &&
                valueBuffer[1] == (byte)'S' &&
                valueBuffer[2] == (byte)'A')
            {
                delimiters.Element = (char)valueBuffer[3];
                delimiters.Line = Encoding.ASCII.GetString(valueBuffer, 105, 1);//Issue, spec says its character length of 1, but some files have \r\n some files do not have fixed isa correct
                //so many invalid files, really sucks
                if (char.IsLetterOrDigit(delimiters.Line[0]) ||
                    valueBuffer[103] != delimiters.Element ||
                    valueBuffer[106] != 'G')
                {
                    s.Position = original + 4;
                    var bigBuffer = new byte[1024];
                    s.Read(bigBuffer, 0, 1024);

                    var field = Encoding.ASCII.GetString(bigBuffer);

                    var indexE = field.IndexOf("GS" + delimiters.Element);
                    if (indexE == -1)
                    {
                        delimiters.SubElement = '~';
                        return;
                    }
                    var indexS = field.LastIndexOf(delimiters.Element, indexE - 1);
                    delimiters.SubElement = field[indexS + 1];
                    delimiters.Line = field[indexS + 2].ToString();
                    s.Position = original + indexE + 5;
                }

                s.Position = original;
            }
            else
                throw new ArgumentException("Invalid ISA");
        }

        private long head;
        private long tail;
        private static long BufferSize = 2048;//4096;
        private byte[] buffer = null;
        private bool EndOfFile = false;

        private string ReadNextLine(Stream BaseStream)
        {
            var index = tail;
            var exitbyte = delimiters.Line[0];
            var sb = new MemoryStream();
            if (head == 0 || tail == BufferSize || tail == head)
            {
                head = BaseStream.Read(buffer, (int)0, (int)(BufferSize));
                tail = 0;
                index = 0;
                if (head == 0)
                {
                    EndOfFile = true;
                    return null;
                }
            }

            //while(buffer[index] ==13 || buffer[index] == 10)
            //{ 
            //    index++;
            //}

            while (buffer[index] != exitbyte)
            {
                index++;
                if (index >= BufferSize || index >= head)
                {
                    if (BaseStream.Position == BaseStream.Length)
                    {
                        EndOfFile = true;
                        return null;
                    }
                    if ((buffer[tail] == 10) ||
                     (buffer[tail] == 13))
                        tail++;//since some incorrectly set line ending to \r\n

                    sb.Write(buffer, (int)tail, (int)(BufferSize - tail));
                    head = BaseStream.Read(buffer, (int)0, (int)(BufferSize));
                    index = 0;
                    tail = 0;
                }
            }
            var oldtail = tail;
            tail = index + 1;
            if (index >= head && BaseStream.Position == BaseStream.Length)
                EndOfFile = true;

            if (sb.Length == 0)
            {
                if ((buffer[oldtail] == 10 && buffer[oldtail + 1] == 13) ||
                    (buffer[oldtail] == 13 && buffer[oldtail + 1] == 10))
                    oldtail += 2;//since some incorrectly set line ending to \r\n and yet someone also did \n\r
                if ((int)(index - oldtail) == 0)
                {
                    return null;
                }
                return Encoding.ASCII.GetString(buffer, (int)oldtail, (int)(index - oldtail));
            }
            else
            {
                sb.Write(buffer, 0, (int)(index));
                return Encoding.ASCII.GetString(sb.ToArray(), (int)oldtail, (int)(sb.Length - oldtail));
            }

        }
    }

}
