using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginFormEnvironmentGroup
    {
        public const string Code = "BFG";
        public const string Name = "Begin Form Environment Group";
        public const string Description = "OBSOLETE FIELD";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 594";

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
