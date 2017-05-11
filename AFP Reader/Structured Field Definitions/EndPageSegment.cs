using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndPageSegment
    {
        public const string Code = "EPS";
        public const string Name = "End Page Segment";
        public const string Description = "The End Page Segment structured field terminates the page segment resource object initiated by a Begin Page Segment structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 215";

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
