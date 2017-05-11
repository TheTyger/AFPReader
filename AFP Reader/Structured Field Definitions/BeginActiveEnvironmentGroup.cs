using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginActiveEnvironmentGroup
    {
        public const string Code = "BAG";
        public const string Name = "Begin Active Environment Group";
        public const string Description = "The Begin Active Environment Group structured field begins an Active Environment Group, " +
            "which establishes the environment parameters for the page or overlay.The scope of the active environment group is the containing page or overlay.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 148";

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
