using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndResourceGroup
    {
        public const string Code = "ERG";
        public const string Name = "End Resource group";
        public const string Description = "The End Resource Group structured field terminates the definition of a resource group initiated by a Begin Resource Group structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 218";

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
