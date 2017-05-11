using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndPresentationTextObject
    {
        public const string Code = "EPT";
        public const string Name = "End Presentation Text Object";
        public const string Description = "The End Presentation Text Object structured field terminates the current " +
            "presentation text object initiated by a Begin Presentation Text Object structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 216";

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
