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

    class X837_V2_Generation
    {
        public static void CreateLoops(string sourceFile, string destinationFolder, string namespaces)
        {
            string header =
                string.Format("using Model.EDI.X12.v2.Base;\r\nusing Model.EDI.X12.v2;\r\nnamespace {0} \r\n{\r\n", namespaces);

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

                        csvLines.Add(new LoopsCSVHolder
                        {
                            LoopName = columns[0],
                            FieldName = columns[1],
                            Name = columns[2],
                            Repeat = string.IsNullOrWhiteSpace(columns[3]) ? "1" : columns[3],
                            Qualifiers = columns[4],
                            Required = columns[5],
                            RequiredGroupSegs = columns[6],
                            RequiredFields = columns[7],
                            UnusedFields = columns[8],
                            RequiredGroupFields = columns[9],
                        });
                    }
                }
            }

            //start writing the loop def file, which contains all the loops with their segments
            //does not do subloops
            using (var writer = new System.IO.StreamWriter(System.IO.Path.Combine(destinationFolder, "837Loops.cs")))
            {
                for(int i=0; i<csvLines.Count; i++) { 
                //foreach (var csvLine in csvLines) {
                    if (!string.IsNullOrWhiteSpace(csvLines[i].LoopName)) continue;
                    writer.WriteLine("public class Loop{0}Collection : LoopCollection<{0}> {", csvLines[i].LoopName);

                    writer.WriteLine("pubic Loop{0}Collection(){}", csvLines[i].LoopName);
                    writer.WriteLine("public override bool Validate(){ throw new System.NotImplementedException();}");
                    writer.WriteLine("public override void SetUpDefinition(){throw new System.NotImplementedException();");

                    writer.WriteLine("}"); //LoopCollection

                    writer.WriteLine("public class Loop{0} : LoopEntity{", csvLines[i].LoopName);

                    while (true)
                    {
                        if (i + 1 < csvLines.Count() && string.IsNullOrWhiteSpace(csvLines[i + 1].LoopName))
                        {
                            i++;
                            writer.WriteLine("public {0}Collectionrump");
                        }
                    }

                    writer.WriteLine("}"); //LoopEntity
                }
            }
        }
    }
}
