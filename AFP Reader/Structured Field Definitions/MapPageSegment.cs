using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapPageSegment
    {
        public const string Code = "MPS";
        public const string Name = "Map Page Segment";
        public const string Description = "The Map Page Segment structured field identifies page segments that are required to present a page on a physical medium.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 323";

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
