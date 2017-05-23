using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    class LoopsCSVHolder
    {
        public string LoopName;
        public string FieldName;
        public string Name;
        public string Repeat;
        public string Qualifiers;
        public string Required;
        public string RequiredGroupSegs;
        public string RequiredFields;
        public string UnusedFields;
        public string RequiredGroupFields;
    }

    public class X12_V2_Generation
    {
        public static void CreateLoops(string sourceFile, string destinationFolder, string namespaces)
        {
            string header =
                string.Format("using Model.EDI.X12.v2.Base;\r\nusing Model.EDI.X12.v2;\r\nnamespace {0} \r\n{{\r\n", namespaces);

            var footer = "}\r\n";


            //read in the definition file
            List<LoopsCSVHolder> csvLines = new List<LoopsCSVHolder>();

            using (var reader = new System.IO.StreamReader(sourceFile))
            {
                var line = reader.ReadLine(); //comment line    
                line = reader.ReadLine(); //col headers

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine(); //start of real values

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var columns = line.Split('\t');
                        columns[0] = columns[0].ToUpper();

                        var t = new LoopsCSVHolder();

                        if(!string.IsNullOrWhiteSpace(columns[0]))
                            t.LoopName = columns[0].Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[1]))
                            t.FieldName = columns[1]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[2]))
                            t.Name = columns[2]?.Trim().Replace(" ", "");

                        t.Repeat = string.IsNullOrWhiteSpace(columns[3]) ? "1" : columns[3].Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[4]))
                            t.Qualifiers = columns[4]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[5]))
                            t.Required = columns[5]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[6]))
                            t.RequiredGroupSegs = columns[6]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[7]))
                            t.RequiredFields = columns[7]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[8]))
                            t.UnusedFields = columns[8]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[9]))
                            t.RequiredGroupFields = columns[9]?.Trim().Replace(" ", "");
                         
                        csvLines.Add(t);
                    }
                }
            }

            //start writing the loop def file, which contains all the loops with their segments
            //does not do subloops
            using (var writer = new System.IO.StreamWriter(System.IO.Path.Combine(destinationFolder, namespaces + ".RAWLoops.cs")))
            {
                for(int i=0; i<csvLines.Count; i++) { 
                //foreach (var csvLine in csvLines) {
                    if (string.IsNullOrWhiteSpace(csvLines[i].LoopName)) continue;
                    writer.WriteLine("public partial class Loop{0}Collection : LoopCollection<Loop{0}> {{", csvLines[i].LoopName);

                    writer.WriteLine("public Loop{0}Collection(){{}}", csvLines[i].LoopName);
                    writer.WriteLine("public override bool Validate(){ throw new System.NotImplementedException();}");
                    writer.WriteLine("public override void SetUpDefinition(){throw new System.NotImplementedException();}");

                    writer.WriteLine("}"); //LoopCollection

                    writer.WriteLine("public partial class Loop{0} : LoopEntity{{", csvLines[i].LoopName);

                    writer.WriteLine("public Loop{0}(){{}}", csvLines[i].LoopName);//ctor

                    while (true)
                    {
                        if (i + 1 < csvLines.Count()
                            && string.IsNullOrWhiteSpace(csvLines[i + 1].LoopName)
                            && !string.IsNullOrWhiteSpace(csvLines[i + 1].FieldName))
                        {
                            i++; 
                            csvLines[i].FieldName = csvLines[i].FieldName[0] + csvLines[i].FieldName.ToLower().Substring(1);
                            writer.WriteLine("public {0}Collection {1} = new {0}Collection();", csvLines[i].FieldName,
                                csvLines[i].Name);
                        }
                        else
                        {
                            break;
                        }
                    }

                    writer.WriteLine("}"); //LoopEntity
                }
            }
        }
    }
}
