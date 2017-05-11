using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ObjectAreaPosition
    {
        public const string Code = "BOP";
        public const string Name = "Object Area Position";
        public const string Description = "The Object Area Position structured field specifies the origin and orientation of the object " +
            "area, and the origin and orientation of the object content within the object area.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 328";

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
