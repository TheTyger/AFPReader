using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginPageSegment
    {
        public const string Code = "BPS";
        public const string Name = "Begin Page Segment";
        public const string Description = "The Begin Page Segment structured field begins a page segment. A page segment " +
        "is a resource object that can be referenced from a page or overlay and that contains any mixture of: Bar code objects(BCOCA), " +
        "Graphics objects(GOCA), v Image objects(IOCA). /r/n" +
        "Objects in a page segment must specify an object area offset of zero so that they are positioned either at the origin of the " + 
        "including page or overlay coordinate system or at a reference point that is defined on the including page or overlay coordinate system by the Include Page Segment(IPS) structured field. /r/n" +
        "A page segment does not contain an active environment group.The environment for a page segment is defined by the active environment group of the including page or overlay.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 182";

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
