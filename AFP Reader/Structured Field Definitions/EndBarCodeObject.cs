using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndBarCodeObject
    {
        public const string Code = "EBC";
        public const string Name = "End Bar Code Object";
        public const string Description = "The End Bar Code Object structured field terminates the current bar code object initiated by a Begin Bar Code Object structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 201";

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
