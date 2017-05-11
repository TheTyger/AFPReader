using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginNamedPageGroup
    {
        public const string Code = "BNG";
        public const string Name = "Begin Named Page Group";
        public const string Description = "The Begin Named Page Group structured field begins a page group, which is a " +
        "named, logical grouping of sequential pages.A page group may contain other nested page groups.All pages in the page group and all other page groups that are " +
        "nested in the page group inherit the attributes that are assigned to the page group using TLE structured fields.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 168";

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
