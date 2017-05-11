using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginPresentationTextBlock
    {
        public const string Code = "BPT";
        public const string Name = "Begin Presentation Text Block";
        public const string Description = "NOTHING HELPFUL IN DESCRIPTION";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 545";

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
