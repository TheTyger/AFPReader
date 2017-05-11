using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class DataMapTransmissionSubcaseDescriptor
    {
        public const string Code = "DXD";
        public const string Name = "Data Map Transmission Descriptor";
        public const string Description = "The Data Map Transmission Subcase Descriptor structured field is supported only for migration purposes.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 99";

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
