using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginPageMap
    {
        public const string Code = "BPM";
        public const string Name = "Begin Page Map";
        public const string Description = "The Begin Page Map structured field begins a Page Map resource object, also called a Page Definition or PageDef. " + 
            "A Page Definition is a print control resource object used to compose line data into pages for printing on page printers.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 94";

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
