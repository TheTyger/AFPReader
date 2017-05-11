using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapGraphicsObject
    {
        public const string Code = "MGO";
        public const string Name = "Map Graphics Object";
        public const string Description = "The Map Graphics Object structured field specifies how a graphics data object is mapped into its object area.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 299";

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
