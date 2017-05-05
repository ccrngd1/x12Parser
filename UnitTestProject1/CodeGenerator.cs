using System.Collections.Generic;
using System.Text;

namespace LawsonCS.Model.EDI.X12.UnitTest.CodeGeneration
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

    public static class CodeGenerator
    {
        public static void CreateStrongTypeLoopsWithSegmentDefs(string sourceFile, string destinationFolder,
            string nameSpace)
        {
            var header =
                string.Format(
                    "using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\nusing System.Linq;\r\nnamespace {0}\r\n{{\r\n",
                    nameSpace);

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


            using (var writer = new System.IO.StreamWriter(System.IO.Path.Combine(destinationFolder, "837Loops.cs")))
            {
                var sb = new StringBuilder();

                sb.AppendFormat("\t\tpublic class ");


                writer.WriteLine(header);

                //class X12_837P_5010NL { 
                writer.WriteLine("\tpublic class X12_837P_5010NL:X12DocumentBase{");

                foreach (LoopsCSVHolder csvLine in csvLines)
                {
                    if (string.IsNullOrWhiteSpace(csvLine.LoopName))
                        continue;

                    writer.WriteLine("public Loop{0} Loop{0} ;", csvLine.LoopName);
                }

                writer.WriteLine("public X12_837P_5010NL(){");

                foreach (LoopsCSVHolder csvLine in csvLines)
                {
                    if (string.IsNullOrWhiteSpace(csvLine.LoopName))
                        continue;

                    writer.WriteLine("Loop{0} = new Loop{0}();", csvLine.LoopName);
                    writer.WriteLine("Loops.Add(Loop{0});", csvLine.LoopName);
                }

                writer.WriteLine("}");

                //class X12_837P_5010NL }
                writer.WriteLine("}");



                for (int i = 0; i < csvLines.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(csvLines[i].LoopName))
                        continue;

                    //class Loops####X : LoopsList {
                    writer.WriteLine("public class Loop{0} : LoopsList", csvLines[i].LoopName);
                    writer.WriteLine("{");

                    for (int j = i; j < csvLines.Count; j++)
                    {
                        if (!string.IsNullOrWhiteSpace(csvLines[i].LoopName))
                            break;

                        writer.WriteLine("public {0} {1};", csvLines[j].FieldName, csvLines[j].Name);
                    }

                    writer.WriteLine("public Loop{0}():base(null, 1, \"{1}\")", csvLines[i].LoopName, csvLines[i].FieldName);
                    writer.Write("{ }");

                    //override DefSegDef() {
                    writer.WriteLine("public override void DefineSegmentDefinition(){");

                    for (int j = i + 1; j < csvLines.Count; j++)
                    {
                        if (!string.IsNullOrWhiteSpace(csvLines[j].LoopName))
                            break;

                        string req = "SegmentUsageType.Required";

                        if (csvLines[j].Required != "Y")
                            req = "SegmentUsageType.Situational";

                        int temp = 0;
                        if (!int.TryParse(csvLines[j].Repeat, out temp))
                            temp = 999;

                        if (!string.IsNullOrWhiteSpace(csvLines[j].Qualifiers))
                        {
                            writer.Write("SegmentDefinitions.Add(new SegmentDefinition(new List<SegmentQualifiers> {");

                            writer.Write("new SegmentQualifiers(1, \"{0}\") ", csvLines[j].Qualifiers.Replace("\"", "").Replace(",\"", ""));
                            writer.Write("},");

                            writer.WriteLine(" {1}, {2}, typeof({0}))); ", csvLines[j].FieldName, req, temp);
                        }
                        else
                        {
                            writer.WriteLine("SegmentDefinitions.Add(new SegmentDefinition(null, {0}, {1}, typeof({2})));", req, temp, csvLines[j].FieldName);
                        }
                    }

                    //override DefSegDef }
                    writer.WriteLine("}");

                    //class Loops####X  }
                    writer.WriteLine("}");

                    writer.WriteLine("}");
                }
            }
        }
    }
}
