using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ObjectAreaDescriptor
    {
        public const string Code = "OBD";
        public const string Name = "Object Area Descriptor";
        public const string Description = "The Object Area Descriptor structured field specifies the size and attributes of an object area presentation space.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 326";

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
