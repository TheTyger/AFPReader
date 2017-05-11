using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndNamedPageGroup
    {
        public const string Code = "ENG";
        public const string Name = "End Named Page Group";
        public const string Description = "The End Named Page Group structured field terminates a page group that was initiated by a Begin Named Page Group structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 210";

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
