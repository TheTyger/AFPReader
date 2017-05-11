using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginObjectEnvironmentGroup
    {
        public const string Code = "BOG";
        public const string Name = "Begin Object Environment Group";
        public const string Description = "The Begin Document structured field names and begins the documentThe Begin Object Environment Group structured field begins an Object " +
        "Environment Group, which establishes the environment parameters for the object. The scope of an object environment group is its containing object..";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 176";

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
