using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class PresentationFidelityControl
    {
        public const string Code = "PFC";
        public const string Name = "Presentation Fidelity Control";
        public const string Description = "The Presentation Fidelity Control structured field specifies the user fidelity requirements for data " + 
            "presented on physical media and for operations performed on physical media.The scope of the Presentation Fidelity Control structured field " + 
            "is the document or print file controlled by the form map that contains this structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 335";

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
