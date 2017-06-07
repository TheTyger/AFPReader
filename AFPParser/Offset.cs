using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPParser
{
    
    public class Offset {
        public int Length;
        public int StartPosition;
        public string Name;
        public List<KeyValuePair<byte, string>> Values;

        public Offset(int l, int st, string n, List<KeyValuePair<byte, string>> v) {

        }
    }
}
