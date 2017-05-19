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
        public string GenerateSegmentCollections(string SegmentsFile)
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
    }
}
