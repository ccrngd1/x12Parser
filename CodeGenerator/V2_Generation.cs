using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator
{
    public class LoopsCSVHolder
    {
        public string LoopName;
        public string FieldName;
        public string Name;
        public string Repeat;
        public string Qualifiers;
        public string Required;
        public string RequiredFields;
        public string UnusedFields;
        public string RequiredGroupFields;
    }

    public class X12_V2_Generation
    {
        public static List<LoopsCSVHolder> ReadMetaData(string sourceFile)
        {
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

                        if (!string.IsNullOrWhiteSpace(columns[0]))
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
                            t.RequiredFields = columns[6]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[7]))
                            t.UnusedFields = columns[7]?.Trim().Replace(" ", "");

                        if (!string.IsNullOrWhiteSpace(columns[8]))
                            t.RequiredGroupFields = columns[8]?.Trim().Replace(" ", "");

                        csvLines.Add(t);
                    }
                }
            }
            return csvLines;
        }

        public static void CreateLoops(string sourceFile, string destinationFolder, string namespaces)
        {
            var csvLines = ReadMetaData(sourceFile);

            //start writing the loop def file, which contains all the loops with their segments
            //does not do subloops
            using (
                var writer =
                    new System.IO.StreamWriter(System.IO.Path.Combine(destinationFolder, namespaces + ".RAWLoops.cs")))
            {
                for (int i = 0; i < csvLines.Count; i++)
                {
                    //foreach (var csvLine in csvLines) {
                    if (string.IsNullOrWhiteSpace(csvLines[i].LoopName)) continue;
                    writer.WriteLine("public partial class Loop{0}Collection : LoopCollection<Loop{0}> {{",
                        csvLines[i].LoopName);

                    writer.WriteLine("public Loop{0}Collection(){{}}", csvLines[i].LoopName);
                    writer.WriteLine("public override bool Validate(){ throw new System.NotImplementedException();}");
                    writer.WriteLine(
                        "public override void SetUpDefinition(){throw new System.NotImplementedException();}");

                    writer.WriteLine("}"); //LoopCollection

                    writer.WriteLine("public partial class Loop{0} : LoopEntity{{", csvLines[i].LoopName);

                    writer.WriteLine("public Loop{0}(){{}}", csvLines[i].LoopName); //ctor

                    while (true)
                    {
                        if (i + 1 < csvLines.Count()
                            && string.IsNullOrWhiteSpace(csvLines[i + 1].LoopName)
                            && !string.IsNullOrWhiteSpace(csvLines[i + 1].FieldName))
                        {
                            i++;
                            csvLines[i].FieldName = csvLines[i].FieldName[0] +
                                                    csvLines[i].FieldName.ToLower().Substring(1);
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

        public static void CreateDefinitions(string sourceFile, string destinationFolder, string namespaces)
        {
            var csvLines = ReadMetaData(sourceFile);

            using (
                var writer =
                    new System.IO.StreamWriter(System.IO.Path.Combine(destinationFolder,
                        namespaces + ".RAWDefinitions.cs")))
            {
                for (int i = 0; i < csvLines.Count; i++)
                {
                    if (string.IsNullOrWhiteSpace(csvLines[i].LoopName)) continue;

                    writer.WriteLine("public partial class Loop{0}Collection{{", csvLines[i].LoopName);

                    writer.WriteLine("public void SetUpDefinition(X12DocDefinition docDef){");

                    ////Generation code below for this section of code
                    //InformationSourceLevelLoop.Definition = new LoopDefinition(999);
                    //DocumentDefinition.loops.Add(InformationSourceLevelLoop.Definition);
                    if (csvLines[i].Repeat != "0" && csvLines[i].Repeat != "1")
                        csvLines[i].Repeat = "999";

                    writer.WriteLine("this.Definition = new LoopDefinition({0});", csvLines[i].Repeat);
                    writer.WriteLine("docDef.loops.Add(this.Definition);");

                    while (true)
                    {
                        if (i + 1 < csvLines.Count()
                            && string.IsNullOrWhiteSpace(csvLines[i + 1].LoopName)
                            && !string.IsNullOrWhiteSpace(csvLines[i + 1].FieldName))
                        {
                            i++;
                            csvLines[i].FieldName = csvLines[i].FieldName[0] +
                                                    csvLines[i].FieldName.ToLower().Substring(1);

                            string usage = "SegmentUsageType.";
                            if (string.IsNullOrWhiteSpace(csvLines[i].Required) || csvLines[i].Required.ToLower() == "y")
                                usage += "Required";
                            else
                                usage += "Optional";

                            if (csvLines[i].Repeat != "0" && csvLines[i].Repeat != "1")
                                csvLines[i].Repeat = "999";

                            writer.WriteLine("var {0}Def = new SegmentDefinition(", csvLines[i].FieldName);
                            writer.WriteLine("{0}, ", usage);
                            writer.WriteLine("{0}, ", csvLines[i].Repeat);
                            writer.WriteLine("typeof({0}), ", csvLines[i].FieldName.ToUpper());
                            writer.WriteLine("{0}", csvLines[i].Name);
                            writer.WriteLine(");");

                            ////Generation code below for this section of code
                            //var isaDef = new SegmentDefinition(SegmentUsageType.Required, 1, typeof(ISA), InterchagneControlHeader);
                            //isaDef.Qualifiers.Add(new SegmentQualifiers(1, new[] { "00", "03" }));
                            //isaDef.RequiredFields.AddRange(new[] { 1, 2 }.ToList());
                            //isaDef.UnusedFields.AddRange(new[] { 3, 4 }.ToList());
                            //isaDef.SyntaxRuleList.AddRange("123,456".Split(',').ToList());
                            //InterchagneControlHeader.Definition = isaDef;
                            //DocumentDefinition.segments.Add(isaDef);

                            writer.WriteLine("{0}Def.Qualifiers.Add(new SegmentQualifiers(1, \"{1}\".Split(','))); ",
                                csvLines[i].FieldName, csvLines[i].Qualifiers);

                            if (!string.IsNullOrWhiteSpace(csvLines[i].RequiredFields))
                            {
                                foreach (var reqId in csvLines[i].RequiredFields.Split(','))
                                {
                                    writer.WriteLine("{0}Def.RequiredFields.Add({1});", csvLines[i].FieldName, reqId);
                                }
                                writer.WriteLine("{0}Def.RequiredFields.AddRange(new []{{ {1} }}.ToList());",
                                    csvLines[i].FieldName, csvLines[i].RequiredFields);
                            }

                            writer.WriteLine("{0}Def.UnusedFields.AddRange(new []{{ {1} }}.ToList());",
                                csvLines[i].FieldName, csvLines[i].UnusedFields);

                            writer.WriteLine("{0}Def.SyntaxRuleList.AddRange(\"{1}\".Split(',').ToList());",
                                csvLines[i].FieldName, csvLines[i].RequiredGroupFields);

                            writer.WriteLine("{0}.Definition = {1}Def;", csvLines[i].Name, csvLines[i].FieldName);
                            writer.WriteLine("docDef.segments.Add({0}Def);", csvLines[i].FieldName);
                        }
                        else
                        {
                            writer.WriteLine("}"); //SetupDefinition
                            break;
                        }
                    }

                    writer.WriteLine("}"); //partial x:LoopEntity
                }
            }
        }

        public static void CreateSingleDefintion(string sourceFile, string destinationFolder, string namespaces)
        {
            var csvLines = ReadMetaData(sourceFile);

            StringBuilder sbMainLoops = new StringBuilder();
            StringBuilder sbSubLoops = new StringBuilder();
            StringBuilder sbSegments = new StringBuilder();

            bool tableHeaderRecordFound = false;
            for (int i = 0; i < csvLines.Count; i++)
            {
                //if (string.IsNullOrWhiteSpace(csvLines[i].LoopName)) continue;
                if (!tableHeaderRecordFound && !string.IsNullOrWhiteSpace(csvLines[i].FieldName) &&
                    csvLines[i].FieldName.ToLower() != "table") continue;
                if (!tableHeaderRecordFound && string.IsNullOrWhiteSpace(csvLines[i].FieldName)) continue;
                tableHeaderRecordFound = true;

                string currentLoop = null;

                while (true)
                {
                    if (i + 1 < csvLines.Count())
                    {
                        i++;

                        if (!string.IsNullOrWhiteSpace(csvLines[i].Repeat) && csvLines[i].Repeat != "0" &&
                            csvLines[i].Repeat != "1")
                            csvLines[i].Repeat = "999";

                        if (!string.IsNullOrWhiteSpace(csvLines[i].FieldName))
                            csvLines[i].FieldName = csvLines[i].FieldName[0] +
                                                    csvLines[i].FieldName.ToLower().Substring(1);

                        if (string.IsNullOrWhiteSpace(csvLines[i].LoopName) //then we have segemnt
                            && !string.IsNullOrWhiteSpace(csvLines[i].FieldName))
                        {
                            string usage = "SegmentUsageType.";
                            if (string.IsNullOrWhiteSpace(csvLines[i].Required) || csvLines[i].Required.ToLower() == "y")
                                usage += "Required";
                            else
                                usage += "Optional";

                            //SegmentDefinition(SegmentUsageType use, int reps, Type segT)
                            sbSegments.AppendFormat("var {0}_{4}_{3} = new SegmentDefinition({1},{2},typeof({0}));\r\n",
                                csvLines[i].FieldName.ToUpper(), usage, csvLines[i].Repeat, currentLoop,
                                csvLines[i].Name);

                            sbSegments.AppendFormat("{0}.LoopSegments.Add({1}_{2}_{0}); \r\n", currentLoop,
                                csvLines[i].FieldName.ToUpper(), csvLines[i].Name);
                        }
                        else if (!string.IsNullOrWhiteSpace(csvLines[i].LoopName)
                                 && !string.IsNullOrWhiteSpace(csvLines[i].FieldName))
                            //then we have subloop - create and add to the given parent
                        {
                            sbSubLoops.AppendFormat("var Loop{0}Definition = new LoopDefinition({1}); \r\n",
                                csvLines[i].LoopName, csvLines[i].Repeat);
                            sbSubLoops.AppendFormat("Loop{0}Definition.LoopName = \"{0}\"; \r\n", csvLines[i].LoopName);
                            sbSubLoops.AppendFormat("Loop{0}Definition.LoopDescription = \"{1}\"; \r\n", csvLines[i].LoopName,
                                csvLines[i].Name);

                            sbSubLoops.AppendFormat("Loop{1}Definition.SubLoops.Add(Loop{0}Definition); \r\n", csvLines[i].LoopName,
                                csvLines[i].FieldName.ToUpper());

                            currentLoop = string.Format("Loop{0}Definition", csvLines[i].LoopName);
                        }
                        else if (!string.IsNullOrWhiteSpace(csvLines[i].LoopName)
                                 && string.IsNullOrWhiteSpace(csvLines[i].FieldName)) //then we have main loop
                        {

                            sbMainLoops.AppendFormat("var Loop{0}Definition = new LoopDefinition({1}); \r\n",
                                csvLines[i].LoopName, csvLines[i].Repeat);
                            sbMainLoops.AppendFormat("Loop{0}Definition.LoopName = \"{0}\"; \r\n", csvLines[i].LoopName);
                            sbMainLoops.AppendFormat("Loop{0}Definition.LoopDescription = \"{1}\"; \r\n", csvLines[i].LoopName,
                                csvLines[i].Name);
                            sbMainLoops.AppendFormat("DocumentDefinition.loops.Add(Loop{0}Definition); \r\n", csvLines[i].LoopName);

                            currentLoop = string.Format("Loop{0}Definition", csvLines[i].LoopName);
                        }
                        else //never should happen
                        {
                            Console.WriteLine("oops");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            using (
                var writer =
                    new System.IO.StreamWriter(System.IO.Path.Combine(destinationFolder,
                        namespaces + ".RAWDefinitionSingle.cs")))
            {
                writer.WriteLine("public void SetUpWholeDefinition(){");
                writer.WriteLine("DocumentDefinition = new X12DocDefinition(); ");

                writer.WriteLine("//MainLoops");
                writer.WriteLine(sbMainLoops.ToString());
                writer.WriteLine("//");
                writer.WriteLine("//subLoops");
                writer.WriteLine(sbSubLoops.ToString());
                writer.WriteLine("//");
                writer.WriteLine("//segments");
                writer.WriteLine(sbSegments.ToString());
                writer.WriteLine("//");

                writer.WriteLine("}");
            }
        }
    }
}
