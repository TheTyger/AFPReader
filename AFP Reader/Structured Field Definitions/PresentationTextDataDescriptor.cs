using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PresentationTextDataDescriptor
    {
        public const string Code = "PTX";
        public const string Name = "Presentation Text Data Descriptor (Format 2)";
        public const string Description = "The Presentation Text Data Descriptor structured field contains the descriptor data for a presentation text data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 368";

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
