﻿using System; 
using System.IO; 
using System.Text;
using EDI.X12.Segments;

namespace EDI.X12.Base
{
    /// <summary>
    /// Extensions for specific segment types
    /// </summary>
    public static class SegmentExtensions
    {
        /// <summary>
        /// Extnesion for ISA segment to pre-load the segment with data from the file
        /// This is the easiest way to load up the ISA versus via the Populate() method the other header/trailer segments go through
        /// </summary>
        /// <param name="isa">Instance of the ISA this is extending.  ISA will be altered.</param>
        /// <param name="s">Stream that holds the X12 to begin parsing and pre-load the ISA with</param>
        internal static void FromStream(this ISA isa, Stream s)
        {
            if(isa==null) isa = new ISA();

            var original = s.Position;
            if (s.Length - s.Position < 106)
                throw new Exception("Invalid ISA");
            byte[] valueBuffer = new byte[107];
            s.Read(valueBuffer, 0, 107);

            if (valueBuffer[0] == (byte)'I' &&
                valueBuffer[1] == (byte)'S' &&
                valueBuffer[2] == (byte)'A')
            {
                var elementSeperator = (char)valueBuffer[3];
                isa.LineSeperator =
                    Encoding.ASCII.GetString(valueBuffer, 105,
                        1); //Issue, spec says its character length of 1, but some files have \r\n some files do not have fixed isa correct

                //so many invalid files, really sucks
                if (char.IsLetterOrDigit(isa.LineSeperator[0]) || valueBuffer[103] != elementSeperator ||
                    valueBuffer[106] != 'G')
                {
                    s.Position = original + 4;
                    var bigBuffer = new byte[1024];
                    s.Read(bigBuffer, 0, 1024);

                    var field = Encoding.ASCII.GetString(bigBuffer);

                    var indexE = field.IndexOf("GS" + elementSeperator, StringComparison.Ordinal);
                    if (indexE == -1)
                    {
                        isa.ComponentElementSeparator = "~";
                        return;
                    }
                    var indexS = field.LastIndexOf(elementSeperator, indexE - 1);
                    isa.ComponentElementSeparator = field[indexS + 1].ToString();
                    isa.LineSeperator = field[indexS + 2].ToString();
                    s.Position = original + indexE + 5;
                }
                else
                {
                    isa.AuthInformationQualifier = Encoding.ASCII.GetString(valueBuffer, 4, 2);
                    isa.AuthorizationInformation = Encoding.ASCII.GetString(valueBuffer, 7, 10);
                    isa.SecurityInformationQualifier = Encoding.ASCII.GetString(valueBuffer, 18, 2);
                    isa.SecurityInformation = Encoding.ASCII.GetString(valueBuffer, 21, 10);
                    isa.InterchangeIDQualifier = Encoding.ASCII.GetString(valueBuffer, 32, 2);
                    isa.InterchangeSenderID = Encoding.ASCII.GetString(valueBuffer, 35, 15);
                    isa.InterchangeIDQualifier_2 = Encoding.ASCII.GetString(valueBuffer, 51, 2);
                    isa.InterchangeReceiverID = Encoding.ASCII.GetString(valueBuffer, 54, 15);
                    isa.InterchangeDate = Encoding.ASCII.GetString(valueBuffer, 70, 6);
                    isa.InterchangeTime = Encoding.ASCII.GetString(valueBuffer, 77, 4);
                    isa.RepetitionSeparator = Encoding.ASCII.GetString(valueBuffer, 82, 1);
                    isa.InterchangeControlVersion = Encoding.ASCII.GetString(valueBuffer, 84, 5);
                    isa.InterchangeControlNo = Encoding.ASCII.GetString(valueBuffer, 90, 9);
                    isa.AcknowledgmentRequested = Encoding.ASCII.GetString(valueBuffer, 100, 1);
                    isa.UsageIndicator = Encoding.ASCII.GetString(valueBuffer, 102, 1);
                    isa.ComponentElementSeparator = Encoding.ASCII.GetString(valueBuffer, 104, 1);
                    isa.LineSeperator =
                        Encoding.ASCII.GetString(valueBuffer, 105,
                            1); //Issue, spec says its character length of 1, but some files have \r\n
                }
                s.Position--;
            }
            else
                throw new ArgumentException("Invalid ISA");
        }
    }
}
