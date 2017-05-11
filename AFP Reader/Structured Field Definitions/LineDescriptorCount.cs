using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class LineDescriptorCount
    {
        public const string Code = "LNC";
        public const string Name = "Line Descriptor Count";
        public const string Description = "The Line Descriptor Count structured field specifies the number of Line Descriptor " +
            "(LND), Record Descriptor (RCD) or XML Descriptor (XMD) structured fields in the Data Map Transmission Subcase.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 115";

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
