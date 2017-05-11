using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PageModificationControl
    {
        public const string Code = "PMC";
        public const string Name = "Page Modification Control";
        public const string Description = "The Page Modification Control structured field specifies modifications to be " +
        "applied to a page presented on a physical medium. /r/n" +
        "If the ID of a specific PMC is selected in the PGP structured field of the active medium map in N-up mode, only the modifications specified by that PMC are "+
        "applied to pages placed on the medium.If a specific PMC is not selected in N-up mode, all modifications specified by all PMCs in the active medium map are " +
        "applied to pages placed on the medium.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 355";

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
