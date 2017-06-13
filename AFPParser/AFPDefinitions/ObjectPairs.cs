using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPParser.AFPDefinitions
{
    public class ObjectPairs
    {
        public static Dictionary<string, string> StandardFieldElementPairs = new Dictionary<string, string>
        {
            {"BDT","EDT" },
            {"BPG", "EPG" },
            {"BPT","EPT" },
            {"BAG", "EAG" },
            {"BII","EII" },
            {"BNG","ENG"}
        };
    }
}
