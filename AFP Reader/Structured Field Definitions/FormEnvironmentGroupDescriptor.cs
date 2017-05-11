using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class FormEnvironmentGroupDescriptor
    {
        public const string Code = "FGD";
        public const string Name = "Form Environment Group Descriptor";
        public const string Description = "OBSOLETE STRUCTURED FIELD";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 595";

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
