using System;
using System.IO;  
using EDI.X12.Base;
using EDI.X12.Segments; 

namespace EDI.X12.SegmentReader
{ 
    /// <summary>
    /// Represents the file as stream of segments that can be ingested by the parser and the hard coded format definitions
    /// </summary>
    public class SegmentStream : IDisposable
    {
        private Stream BaseStream { get; set; }
        private bool IsDisposed { get; set; }
        private bool EndOfFile { get; set; }

        private long _lastPoisition;
        private long _head;
        private long _tail;
        private const long BufferSize = 2048;
        private byte[] _buffer = null;

        /// <summary>
        /// Default Ctor, requires both the stream of the file and a reference to the pre-created x12 document to begin populating
        /// </summary>
        /// <param name="s">x12 file in stream form</param>
        /// <param name="x12Doc">pre-created x12 doc to begin populating</param>
        public SegmentStream(Stream s, ref X12Doc x12Doc)
        { 
            _buffer = new byte[BufferSize];
            BaseStream = s;
            EndOfFile = false;
            x12Doc.InterchagneControlHeader = new ISA();
            x12Doc.InterchagneControlHeader.FromStream(s);
            _lastPoisition = s.Position;
            _head = _tail = 0;
        }

        /// <summary>
        /// Move to the next segment line in the stream
        /// </summary>
        /// <param name="delims">Delimiters so the line can be split correctlys</param>
        /// <returns>A BaseFieldValues object that can be ingested by a derived segment type in a hard coded document format</returns>
        public BaseFieldValues ReadNextLine(Delimiters delims)
        {
            var index = _tail;
            var exitbyte = (byte)delims.Segment;
            var sb = new MemoryStream();
            if (_head == 0 || _tail == BufferSize || _tail == _head)
            {
                _head = BaseStream.Read(_buffer, (int)0, (int)(BufferSize));
                _tail = 0;
                index = 0;
                if (_head == 0)
                {
                    EndOfFile = true;
                    return null;
                }
            }
            while (_buffer[index] != exitbyte)
            {
                index++;
                if (index >= BufferSize || index >= _head)
                {
                    if (BaseStream.Position == BaseStream.Length)
                    {
                        EndOfFile = true;
                        return null;
                    }
                    if ((_buffer[_tail] == 10) ||
                     (_buffer[_tail] == 13))
                        _tail++;//since some incorrectly set line ending to \r\n

                    sb.Write(_buffer, (int)_tail, (int)(BufferSize - _tail));
                    _head = BaseStream.Read(_buffer, (int)0, (int)(BufferSize));
                    index = 0;
                    _tail = 0;
                }
            }
            var oldtail = _tail;
            _tail = index + 1;
            if (index >= _head && BaseStream.Position == BaseStream.Length)
                EndOfFile = true;

            if (sb.Length == 0)
            {
                if ((_buffer[oldtail] == 10 && _buffer[oldtail + 1] == 13) ||
                    (_buffer[oldtail] == 13 && _buffer[oldtail + 1] == 10))
                    oldtail++;//since some incorrectly set line ending to \r\n and yet someone also did \n\r
                if ((int)(index - oldtail) == 0)
                {
                    return null;
                }
                return new BaseFieldValues(_buffer, (int)oldtail, (int)(index - oldtail), (byte)delims.Element, delims.Component.ToString());
            }
            else
            {
                sb.Write(_buffer, 0, (int)(index));

                return new BaseFieldValues(sb.ToArray(), (int)oldtail, (int)(sb.Length - oldtail), (byte)delims.Element, delims.Component.ToString());
            }

        }

        /// <summary>
        /// Dispose of the object and release all resources
        /// </summary>
        public void Dispose()
        {
            if (BaseStream != null)
                BaseStream.Dispose();

            IsDisposed = true;
        }

        /// <summary>
        /// Default Dtor
        /// </summary>
        ~SegmentStream()
        {
            if (!IsDisposed)
                this.Dispose();
        }
    }
}
