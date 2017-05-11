using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ImageInputDescriptor
    {
        public const string Code = "IID";
        public const string Name = "Image Input Descriptor";
        public const string Description = "The IM Image Input Descriptor structured field contains the descriptor data for an " +
            "IM image data object. This data specifies the resolution, size, and color of the IM image.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 645";

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
