using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class InvokeDataMap
    {
        public const string Code = "IDM";
        public const string Name = "Invoke Data Map";
        public const string Description = "The Invoke Data Map structured field selects a new Data Map for printing line data and ends the " + 
            "current line-format page. With LND Data Maps, processing begins with the first Line Descriptor (LND) structured field of the invoked " + 
            "Data Map for the next line-format page. With RCD Data Maps, processing begins with the first Record Descriptor (RCD) structured field " + 
            "that matches the Record ID of the current line-data record. With XMD Data Maps, processing begins with the first XML Descriptor (XMD) " + 
            "structured field that matches the current Qualified Tag.";
        public const string Reference = "AFP Programming guide and Data Line Reference.pdf - pg 105";

        public static SFIData ConvertToSFIData()
        {
            return new SFIData
            {
                Name = Name,
                Code = Code,
                Description = Description,
                Reference = Reference
            };
        }
    }
}
