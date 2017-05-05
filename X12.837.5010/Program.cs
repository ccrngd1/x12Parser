using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X12.Data.Loops;
using X12.Data;
using System.Collections.Concurrent;
using System.Threading;

namespace X12._837._5010
{
    class Program
    {
        static Dictionary<string, ITypedSegment> segmentConverters = new Dictionary<string, ITypedSegment>();

        static void Main(string[] args)
        {

            foreach (var type in System.Reflection.Assembly.GetAssembly(typeof(ISASegment)).GetTypes().Where(a => a.GetInterface("ITypedSegment") != null))
            {
                var seg = Activator.CreateInstance(type) as ITypedSegment;

                segmentConverters.Add(seg.SegmentName, seg);
            }


            // var testFile = @"c:\projects\test Files\X12Compare\CLP\X12\100748\CLP-201511121119468532-45f3143c-cbb7-4492-8e57-7518f85f8393.txt"; //@"C:\projects\Test Files\Prof_8375010_HV_example.txt";
            var sw = new System.Diagnostics.Stopwatch();            
            sw.Start();
            var mem1 = Process.GetCurrentProcess().PrivateMemorySize64;
            Dictionary<string, List<object>> typedSegments = new Dictionary<string, List<object>>();
          
            int fileCount = 0;
            
            var swTotal = new System.Diagnostics.Stopwatch();
            swTotal.Start();
            var startMem = Process.GetCurrentProcess().WorkingSet64;
            var set = new string[] { @"C:\projects\Test Files\X12Compare\CLP\X12\63068\CLP-201511131152218029-bb1b3993-8fa9-4e92-9c64-ac5a942c7c31.txt",
            @"C:\projects\Test Files\X12Compare\CLP\X12\79699\CLP-201511091137142566-c93d7d9b-c9d9-44a6-b123-c5188b5fdebc.txt"};
            
            var options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 3;
            //Parallel.ForEach(System.IO.Directory.GetFiles(@"C:\projects\Test Files\X12Compare\CLP", "CLP*.txt",
            //    System.IO.SearchOption.AllDirectories), options, file =>
            foreach(var file in System.IO.Directory.GetFiles(@"C:\projects\Test Files\X12Compare\CLP", "CLP*.txt",
                System.IO.SearchOption.AllDirectories))
                {
                    fileCount++;
                    ProcessFile(file);
                 
                }
                swTotal.Stop();
                SegmentsPerFile.Sort();
                System.Diagnostics.Trace.WriteLine(string.Format("Sum Segments: {0}\r\nMedian: {1}\r\nStdDev: {2}",
                    SegmentsPerFile.Sum(), SegmentsPerFile.Median(), SegmentsPerFile.StdDev()));

                System.Diagnostics.Trace.WriteLine(string.Format("Avg Segments: {0}\tSum Segments: {1}\tClaims: {2}\tFiles: {3}\tTime: {4}\tMemory: {5}\tPeek: {6}", 
                    SegmentsPerFile.Average(), SegmentsPerFile.Sum(),
                    _grandTotal, fileCount,
                swTotal.Elapsed,                
                Process.GetCurrentProcess().WorkingSet64, 
                Process.GetCurrentProcess().PeakWorkingSet64 ) );
        
            
                      

        }
        private static bool Enabled = true;
        private static long _grandTotal = 0;
        static WorkerObject[] workerObjectPool = new WorkerObject[10];
        private static List<int> SegmentsPerFile = new List<int>();
        public static void ProcessFile(string file)
        {
            WorkerObject workerObject = null;
            lock (workerObjectPool)
            {
                for (int i = 0; i < workerObjectPool.Length; i++)
                {
                    if (workerObjectPool[i] == null)
                    {
                            workerObject= new WorkerObject();
                            workerObjectPool[i] = workerObject;
                    
                        break;
                    }
                    if (!workerObjectPool[i].InUse)
                    {
                        workerObject = workerObjectPool[i];
                        break;
                        
                    }
                }
                if(workerObject!=null)
                    workerObject.InUse = true;

            }
            var loop837 = workerObject.loop837;
            var transaction = workerObject.transaction;
            using (var reader = new SegmentStream(System.IO.File.OpenRead(file)))
            {
                char sep = reader.ISA.ComponentElementSeparator[0];
                var segments = new List<ITypedSegment>();
                var line = 1;
                while (!reader.EndOfFile)
                {
                    line++;
                    var segment = reader.ReadNextLine();
                    if (segment == null) continue;
                    if (segment.Fields.Count < 2) continue;
                    try
                    {
                        if (!segmentConverters.ContainsKey(segment[0]))
                        {
                            continue;
                        }
                        ITypedSegment typedSegment = segmentConverters[segment[0]].Create(segment, sep);// GetTypedSegment(segment, sep);
                        if (typedSegment != null)
                        {//Per segment not working, need to figure out why but meh
                            segments.Add(typedSegment);
                           // transaction.Add(typedSegment);
                  
                        }

                    }
                    catch (KeyNotFoundException)
                    {
                        System.Diagnostics.Trace.WriteLine("Segment type not created, or segment was not parsed correctly: " + segment.ToString());
                    }
                }
                //var Tran = new Transaction(Loop837.Definition);
                SegmentsPerFile.Add(segments.Count);
                var loops = transaction.Build(segments);
         
                int totalClaims = 0;

                foreach (var loop in transaction.Loops)
                {
                    var batch = new BatchData();
                    LoopToClp.ConvertGroupStart(loop, batch);
                    totalClaims += batch.Count;
                }

                Interlocked.Add(ref _grandTotal, totalClaims);
             

            }
            lock (workerObjectPool)
            {
                workerObject.transaction.Reset();
                workerObject.InUse = false;
            }
        }
    }
}
