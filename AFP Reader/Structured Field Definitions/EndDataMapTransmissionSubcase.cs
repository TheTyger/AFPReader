using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class EndDataMapTransmissionSubcase
    {
        public const string Code = "EDX";
        public const string Name = "End Data Map Transmission Subcase";
        public const string Description = "The End Data Map Transmission Subcase structured field " + 
            "terminates the Data Map Transmission Subcase initiated by a Begin Data Map Transmission Subcase structured field.";
        public const string Reference = "AFP Programming Guide and Line Data Reference.pdf - pg 101";

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
