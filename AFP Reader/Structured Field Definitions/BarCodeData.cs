using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BarCodeData
    {
        public const string Code = "BDA";
        public const string Name = "Bar Code Data";
        public const string Description = "The Bar Code Data structured field contains the data for a bar code object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 151";

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
