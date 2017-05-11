using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndFormEnvironmentGroup
    {
        public const string Code = "EFG";
        public const string Name = "End Form Environment Group";
        public const string Description = "Documentation for this does not have a description...";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 595";

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
