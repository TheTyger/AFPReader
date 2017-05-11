using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class ConditionalProcessingControl
    {
        public const string Code = "CCP";
        public const string Name = "Conditional Processing Control";
        public const string Description = "The Conditional Processing Control structured field defines tests to be performed on " +
            "selected input records in line data and specifies the actions to take based on the test results. This optional structured field is " + 
            "selected with LND, RCD or XMD structured fields in the Page Definition. An LND, RCD or XMD can have a unique CCP associated with it or " + 
            "it can reference a CCP that has already been used. In either case, the CCP is referenced with the CCPID field of the LND, RCD or XMD. " + 
            "If a CCP structured field is included in a Page Definition, it must appear before the Data Maps in the Page Definition.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 95";

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
