using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ImageRasterData
    {
        public const string Code = "IRD";
        public const string Name = "Image Raster Data";
        public const string Description = "The IM Image Raster Data structured field contains the image points that define the raster pattern for an IM image data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 649";

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
