using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class IncludePageOverlay
    {
        public const string Code = "IPO";
        public const string Name = "Include Page Overlay";
        public const string Description = "The Include Page Overlay structured field references an overlay resource definition " + 
            "that is to be positioned on the page.A page overlay can be referenced at any time during the page state, but " + 
            "not during an object state. The overlay contains its own active environment group definition. The current environment " + 
            "of the page that included the overlay is restored when the Include Page Overlay has been completed.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 245";

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
