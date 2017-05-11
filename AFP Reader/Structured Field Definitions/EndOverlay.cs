using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndOverlay
    {
        public const string Code = "EMO";
        public const string Name = "End Overlay";
        public const string Description = "The End Overlay structured field terminates the overlay resource object initiated by a Begin Overlay structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 209";

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
