﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Structured_Field_Definitions
{
    class BeginGraphicsObject
    {
        public const string Code = "BGR";
        public const string Name = "Begin Graphics Object";
        public const string Description = "The Begin Graphics Object structured field begins a graphics data object which becomes the current data object.";
        public const string Reference = "AFP Mixed Object Document Content.pdf - pg 132";

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
