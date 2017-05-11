using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BarCodeDataDescriptor
    {
        public const string Code = "BDD";
        public const string Name = "Bar Code Data Descriptor";
        public const string Description = "The Bar Code Data Descriptor structured field contains the descriptor data for a bar code data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 152";

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
