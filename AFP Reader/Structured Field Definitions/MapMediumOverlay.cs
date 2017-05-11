using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapMediumOverlay
    {
        public const string Code = "MMO";
        public const string Name = "Map Medium Overlay";
        public const string Description = "The Map Medium Overlay structured field maps one-byte medium overlay local identifiers " + 
            "that are specified by keywords in the Medium Modification Control (MMC) structured field to medium overlay names.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 315";

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
