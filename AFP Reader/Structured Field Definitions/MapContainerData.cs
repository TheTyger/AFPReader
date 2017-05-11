using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapContainerData
    {
        public const string Code = "MCD";
        public const string Name = "Map Container Data";
        public const string Description = "The Map Container Data structured field specifies how a presentation data object "+
            "that is carried within an object container is mapped into its object area.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 260";

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
