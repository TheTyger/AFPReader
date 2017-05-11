using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class RecordDescriptor
    {
        public const string Code = "RCD";
        public const string Name = "Record Descriptor";
        public const string Description = "The Record Descriptor structured field contains information, such as record position, " +
            "text orientation, font selection, field selection, and conditional processing identification, used to format line data that consists of records tagged with record identifiers.";
        public const string Reference = "AFP Programming guide and Line Data Reference.pdf - pg 139";

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
