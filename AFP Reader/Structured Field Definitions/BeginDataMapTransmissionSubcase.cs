using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginDataMapTransmissionSubcase
    {
        public const string Code = "BDX";
        public const string Name = "Begin Data Map Transmission Subcase";
        public const string Description = "The Begin Data Map Transmission Subcase structured "+
            "field begins a Data Map Transmission Subcase object, which contains the structured fields used to map lines of data to the page.";
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
