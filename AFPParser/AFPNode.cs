using AFPParser.AFPDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPParser
{
    public class AFPNode
    {
        public List<AFPNode> Nodes { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public List<byte> RawData { get; set; }
        public int Length { get; set; }
        public byte[] Reserved { get; set; }
        public byte Flags { get; set; }
        public Semantics Data { get; set; }
        public byte Prefix { get; set; }

        public AFPNode(byte[] data, int start, int end)
        {
            Prefix = data[start];
            Length = data[start + 2] + (data[start + 1] * 256);
            
            Flags = data[start + 6];
            Reserved = new byte[] { data[start + 7], data[start + 8]};
            RawData = new List<byte>();
            for (int i = start + 9; i < end; i++)
            {
                RawData.Add(data[i]);
            }
            StructuredField sf = new StructuredField((data[start + 3].ToString("x2") + data[start + 4].ToString("x2") + data[start + 5].ToString("x2")).ToUpper());
            Code = sf.Code;
            Description = sf.Description;
            Name = sf.Name;
            //Data
        }
        public AFPNode(AFPNode data) {
            new AFPNode(data.RawData.ToArray(), 0, (RawData.Count - 1));
        }
    }
}
