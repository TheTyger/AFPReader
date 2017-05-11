using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginOverlay
    {
        public const string Code = "BMO";
        public const string Name = "Begin Overlay";
        public const string Description = "The Begin Overlay structured field begins an overlay. An overlay contains an active environment "+ 
            "group to establish parameters such as the size of the overlay's presentation space and the fonts to be used by the data objects.It may also contain " +
            "any mixture of: Bar code objects, Graphics objects, Image objects, Object containers, Presentation text objects";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 166";

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
