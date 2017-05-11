using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ObjectContainerData
    {
        public const string Code = "OCD";
        public const string Name = "Object Container Data";
        public const string Description = "The Object Container Data structured field contains the data for an object carried in " + 
            "an object container.See “Object Type Identifiers” on page 623 for the list of object types that may be carried in an object container.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 332";

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
