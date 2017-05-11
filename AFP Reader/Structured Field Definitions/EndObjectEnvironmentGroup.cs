using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndObjectEnvironmentGroup
    {
        public const string Code = "EOG";
        public const string Name = "End Object Environment Group";
        public const string Description = "The End Object Environment Group structured field terminates the definition of an Object " + 
            "Environment Group initiated by a Begin Object Environment Group structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 212";

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
