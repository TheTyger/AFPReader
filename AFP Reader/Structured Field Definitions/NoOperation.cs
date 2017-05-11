using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class NoOperation
    {
        public const string Code = "NOP";
        public const string Name = "No Operation";
        public const string Description = "The No Operation structured field performs no function.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 325";

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
