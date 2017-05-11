using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ImageOutputControl
    {
        public const string Code = "IOC";
        public const string Name = "Image Output control";
        public const string Description = "The IM Image Output Control structured field specifies the position and " +
        "orientation of the IM image object area and the mapping of the image points to presentation device pels.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 646";

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
