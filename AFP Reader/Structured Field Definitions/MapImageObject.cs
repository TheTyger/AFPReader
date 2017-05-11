using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapImageObject
    {
        public const string Code = "MIO";
        public const string Name = "Map Image Object";
        public const string Description = "The Map Image Object structured field specifies how an image data object is mapped into its object area.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 300";

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
