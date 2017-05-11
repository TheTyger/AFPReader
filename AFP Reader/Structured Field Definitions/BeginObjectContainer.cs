using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginObjectContainer
    {
        public const string Code = "BOC";
        public const string Name = "Begin Object Container";
        public const string Description = "The Begin Object Container structured field begins an object container, which may be used " + 
            "to envelop and carry object data.The object data may or may not bedefined by an AFP presentation architecture.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 171";

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
