using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class InculdePageSegment
    {
        public const string Code = "IPS";
        public const string Name = "Include Page Segment";
        public const string Description = "The Include Page Segment structured field references a page segment resource object that " + 
            "is to be presented on the page or overlay presentation space.The IPS specifies a reference point on the including " + 
            "page or overlay coordinate system that may be used to position objects contained in the page segment.A page segment " +
            "can be referenced at any time during page or overlay state, but not during an object state. The page segment inherits " + 
            "the active environment group definition of the including page or overlay.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 248";

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
