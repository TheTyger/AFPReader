using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class LineDescriptor
    {
        public const string Code = "LND";
        public const string Name = "Line Descriptor";
        public const string Description = "The Line Descriptor structured field contains information, such as line position, text orientation, font selection, " + 
            "field selection, and conditional processing identification, used to format line data." + 
            "/r/n Note: The LNDs in a Data Map are numbered sequentially, starting with 1. Values from 1 through the number of LNDs are allowed.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 116";

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
