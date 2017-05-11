using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndResourceEnvironmentGroup
    {
        public const string Code = "ESG";
        public const string Name = "End Resource Environment Group";
        public const string Description = "The End Resource Environment Group structured field terminates the definition of a Resource " + 
            "Environment Group initiated by a Begin Resource Environment Group structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 220";

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
