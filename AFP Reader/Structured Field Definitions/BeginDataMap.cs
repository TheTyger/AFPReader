using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginDataMap
    {
        public const string Code = "BDM";
        public const string Name = "Begin Data Map";
        public const string Description = "The Begin Data Map structured field begins a Data Map resource object.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 87";

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
