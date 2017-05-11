using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PresentationTextData
    {
        public const string Code = "PTX";
        public const string Name = "Presentation Text Data";
        public const string Description = "The Presentation Text Data structured field contains the data for a presentation text data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 369";

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
