using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginPage
    {
        public const string Code = "BPG";
        public const string Name = "Begin Page";
        public const string Description = "The Begin Page structured field begins a presentation page. A presentation page contains an active environment group " +
        "to establish parameters such as the size of the page's presentation space and the fonts to be used by the data objects. It may also contain any mixture of: "+
        "Bar code objects, Graphics objects, Image objects, Object containers, Presentation text objects";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 179";

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
