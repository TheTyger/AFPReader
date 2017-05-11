using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginResourceGroup
    {
        public const string Code = "BRG";
        public const string Name = "Begin Resource Group";
        public const string Description = "The Begin Resource Group structured field begins a resource group, which becomes the current resource group at the same level in the document hierarchy.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 158";

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
