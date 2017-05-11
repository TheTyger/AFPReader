using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ContainerDataDescriptor
    {
        public const string Code = "CD";
        public const string Name = "Container Data Descriptor";
        public const string Description = "The Container Data Descriptor structured field specifies control information for a " +
        "presentation data object that is carried in an object container.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 198";

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
