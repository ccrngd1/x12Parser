using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text; 

namespace EDI.X12.CodeGeneration
{
    public class V2_Generation_SegmentCollection
    {
        public string GenerateSegmentCollections_v2(string segmentsFile)
        {
            var segmentNameList = new SortedDictionary < string, List< string >> ();

            var className = "";
            using (StreamReader reader = File.OpenText(segmentsFile))
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
            
            foreach (KeyValuePair<string, List<string>> segName in segmentNameList)
            {  
                sb.AppendFormat("public partial class {0} : BaseStdSegment{{\r\n",segName.Key);

                int i = 1;
                foreach (string prop in segName.Value)
                {
                    string fixedProp = prop[0].ToString().ToUpper() + prop.Substring(1, prop.Length-1);
                    sb.AppendFormat(
                        "public string {0} {{get {{return GetFieldValue({1});}} set {{SetFieldValue({1}, value);}} }}\r\n", fixedProp, i);

                    i++;
                }

                sb.AppendFormat("public {0}():base(){{}}\r\n", segName.Key); 
                sb.AppendFormat("public {0}(IEnumerable<string> splitX12Line) :base(splitX12Line){{}}\r\n", segName.Key);
                sb.AppendLine("}");
            }

            return sb.ToString();
        }
    }
}
