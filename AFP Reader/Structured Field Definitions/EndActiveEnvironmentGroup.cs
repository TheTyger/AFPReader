using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndActiveEnvironmentGroup
    {
        public const string Code = "EAG";
        public const string Name = "End Active Environment Group";
        public const string Description = "The End Active Environment Group structured field terminates the definition of an Active " +
            "Environment Group initiated by a Begin Active Environment Group structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 200";

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
