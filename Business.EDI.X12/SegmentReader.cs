using System;
using System.IO; 
using Model.EDI.X12.v2;
using Model.EDI.X12.v2.Base;

namespace Business.EDI.X12.v2
{ 

    public class SegmentStream : IDisposable
    {
        public Stream BaseStream { get; protected set; } 
        public bool IsDisposed { get; private set; }
        public bool EndOfFile { get; internal set; }

        public SegmentStream(Stream s, ref X12Doc x12doc)
        {
            // BufferSize = s.Length;
            buffer = new byte[BufferSize];
            BaseStream = s;
            EndOfFile = false;
            x12doc.InterchagneControlHeader = new ISA();
            x12doc.InterchagneControlHeader.FromStream(s);
            lastPoisition = s.Position;
            head = tail = 0;
        }


        public baseFieldValues ReadNextLine(Delimiters delims)
        {
            var index = tail;
            var exitbyte = (byte)delims.Segment;
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
                    oldtail++;//since some incorrectly set line ending to \r\n and yet someone also did \n\r
                if ((int)(index - oldtail) == 0)
                {
                    return null;
                }
                return new baseFieldValues(buffer, (int)oldtail, (int)(index - oldtail), (byte)delims.Element, delims.Component.ToString());
            }
            else
            {
                sb.Write(buffer, 0, (int)(index));

                return new baseFieldValues(sb.ToArray(), (int)oldtail, (int)(sb.Length - oldtail), (byte)delims.Element, delims.Component.ToString());
            }

        }

        public void Dispose()
        {
            if (BaseStream != null)
                BaseStream.Dispose();
            IsDisposed = true;
        }
        ~SegmentStream()
        {
            if (!IsDisposed)
                this.Dispose();
        }
        private long lastPoisition;
        private long head;
        private long tail;
        private static long BufferSize = 2048;//4096;
        private byte[] buffer = null;
    }
}
