using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginBarCodeObject
    {
        public const string Code = "BBC";
        public const string Name = "Begin Bar Code Object";
        public const string Description = "The Begin Bar Code Object structured field begins a bar code data object, which becomes the current data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 149";

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
