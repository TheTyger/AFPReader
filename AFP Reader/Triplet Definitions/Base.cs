using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_Reader.Triplet_Definitions
{
    internal class Base
    {
        public int Length { get; set; }
        public string Tid { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Data { get; set; }

        public string ConvertToEBSIDIC(byte[] b) {
            return Encoding.GetEncoding("IBM037").GetString(b);
        }
        
    }
}
