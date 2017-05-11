using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MediumCopyCount
    {
        public const string Code = "MCC";
        public const string Name = "Medium Copy Count";
        public const string Description = "The Medium Copy Count structured field specifies the number of copies of each" +
        " medium, or sheet, to be presented, and the modifications that apply to each copy. "+
        "This specification is called a copy group.The MCC contains repeating groups that "+
        "specify copy subgroups, such that each copy subgroup may be specified "+
        "independently of any other copy subgroup. For each copy subgroup, the number "+
        "of copies, as well as the modifications to be applied to each copy, is specified by " + 
        "the repeating group.If the modifications for a copy subgroup specify duplexing, " +
        "that copy subgroup and all successive copy subgroups are paired such that the "+
        "first copy subgroup in the pair specifies the copy count as well as the" +
        "modifications to be applied to the front side of each copy, and the second copy "+
        "subgroup in the pair specifies the same copy count as well as an independent set " +
        "of modifications to be applied to the back side of each copy.The pairing of copy " +
        "subgroups continues as long as duplexing is specified.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 258";

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
