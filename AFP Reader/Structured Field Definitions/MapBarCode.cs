using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MapBarCode
    {
        public const string Code = "MBC";
        public const string Name = "Map Bar Code";
        public const string Description = "The Map Bar Code Object structured field specifies how a bar code data object is to be mapped into its object area.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 257";

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
