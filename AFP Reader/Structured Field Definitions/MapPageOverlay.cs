using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapPageOverlay
    {
        public const string Code = "MPO";
        public const string Name = "Map Page Overlay";
        public const string Description = "The Map Page Overlay structured field maps local identifiers to page overlay names.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 321";

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
