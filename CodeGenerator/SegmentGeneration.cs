using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class V2_Generation_SegmentCollection
    {
        public string GenerateSegmentCollections_OLD(string SegmentsFile)
        {
            List<string> segmentNameList = new List<string>();

            using (var reader = File.OpenText(SegmentsFile))
            {
                var readLine = reader.ReadLine();

                while (readLine != null)
                {
                    if (readLine.ToLower().Contains("public class"))
                    {
                        segmentNameList.Add(readLine.Trim().Split(' ').ToList()[2]);
                    }

                    readLine = reader.ReadLine();
                }
            }

            var sb = new StringBuilder();


            string classHeaderPrefix = @"public class ";
            string classHeaderSuffix = @"Collection : baseSegmentCollection {";

            string ctorPrefix = @"public ";
            string ctorSuffix = @"Collection() : base(typeof(";
            string ctorEnding = @")){ }";

            string indexPrefix = @"public ";
            string indexGetPrefix = @" this[int index]{get { return Segments[index] as ";
            string indexSetPrefix = @" ;} set{Segments[index]=value;}}}";

            foreach (string segName in segmentNameList)
            {
                sb.Append(classHeaderPrefix).Append(segName);
                sb.Append(classHeaderSuffix).Append(ctorPrefix).Append(segName);
                sb.Append(ctorSuffix).Append(segName);
                sb.Append(ctorEnding).Append(indexPrefix).Append(segName);
                sb.Append(indexGetPrefix).Append(segName).Append(indexSetPrefix);
                sb.AppendLine(" ");
            }

            return sb.ToString();
        }

        public string GenerateSegmentCollections_v2(string SegmentsFile)
        {
            var segmentNameList = new SortedDictionary < string, List< string >> ();

            var className = "";
            using (StreamReader reader = File.OpenText(SegmentsFile))
            {
                var readLine = reader.ReadLine();

                while (readLine != null)
                {
                    if (readLine.ToLower().Contains("public class"))
                    {
                        className = readLine.Trim().Split(' ').ToList()[2];
                        segmentNameList.Add(className, new List<string>());
                    }
                    else if (readLine.ToLower().Contains("public string "))
                    {
                        segmentNameList[className].Add(readLine.Trim().Split(' ').ToList()[2].Replace(';', ' ')); //save the property name
                    }
                    else if (string.IsNullOrWhiteSpace(readLine))
                    {
                        //skipping
                    }
                    else
                    {
                        Console.WriteLine("bad line?");
                    }

                    readLine = reader.ReadLine();
                }
            }

            var sb = new StringBuilder();
            
            foreach (var segName in segmentNameList)
            {  
                sb.AppendFormat("public partial class {0} : BaseStdSegment{{\r\n",segName.Key);

                int i = 1;
                foreach (var prop in segName.Value)
                {
                    var fixedProp = prop[0].ToString().ToUpper() + prop.Substring(1, prop.Length-1);
                    sb.AppendFormat(
                        "public string {0} {{get {{return GetFieldValue({1});}} set {{SetFieldValue({1}, value);}} }}\r\n", fixedProp, i);

                    i++;
                }

                sb.AppendFormat("public {0}():base(){{}}\r\n", segName.Key);
                sb.AppendFormat("public {0}(string[] splitX12Line) : this(splitX12Line.ToList()){{}}\r\n", segName.Key);
                sb.AppendFormat("public {0}(List<string> splitX12Line) :base(splitX12Line){{}}\r\n", segName.Key);
                sb.AppendLine("}");
            }

            return sb.ToString();
        }
    }
}
