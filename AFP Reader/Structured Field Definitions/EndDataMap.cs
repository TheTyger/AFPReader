using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndDataMap
    {
        public const string Code = "EDM";
        public const string Name = "End Data Map";
        public const string Description = "The End Data Map structured field terminates the Data Map object initiated by a Begin Data Map structured field.";
        public const string Reference = "AFP Programming guide and Line Data Reference.pdf - pg 100";

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
