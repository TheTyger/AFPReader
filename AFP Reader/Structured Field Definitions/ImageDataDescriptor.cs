using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ImageDataDescriptor
    {
        public const string Code = "IDD";
        public const string Name = "Image Data Descriptor";
        public const string Description = "The Image Data Descriptor structured field contains the descriptor data for an image data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 223";

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
