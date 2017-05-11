using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndPageMap
    {
        public const string Code = "EPM";
        public const string Name = "End Page Map";
        public const string Description = "The End Page Map structured field terminates the Page Map object initiated by a Begin Page Map structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 102";

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
