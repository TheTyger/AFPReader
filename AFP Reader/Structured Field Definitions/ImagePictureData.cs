using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ImagePictureData
    {
        public const string Code = "IPD";
        public const string Name = "Image Pictue Data";
        public const string Description = "The Image Picture Data structured field contains the data for an image data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 241";

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
