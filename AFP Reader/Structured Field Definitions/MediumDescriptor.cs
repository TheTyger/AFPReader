﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class MediumDescriptor
    {
        public const string Code = "MDD";
        public const string Name = "Medium Descriptor";
        public const string Description = "The Medium Descriptor structured field specifies the size and orientation of the "+
        "medium presentation space for all sheets that are generated by the medium map "+
        "that contains the Medium Descriptor structured field.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 269";

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