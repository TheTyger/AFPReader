using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFPParser
{
    public class AFPDocument
    {
        public List<AFPNode> Nodes { get; set; }

        public AFPDocument(byte[] afpRawData, bool FormatAsTree = false) {
            // Build One Dimensional list of nodes
            List<AFPNode> TempList = new List<AFPNode>();
            for (int curIndex = 0; curIndex < afpRawData.Length - 1;)
            {
                if (afpRawData[curIndex] == 0x5a)
                {
                    int rowEndIndex = getEndIndex(curIndex, afpRawData[curIndex + 1], afpRawData[curIndex + 2]);
                    if (rowEndIndex == -1) rowEndIndex = afpRawData.Length - 1;

                    TempList.Add(new AFPNode(afpRawData, curIndex, rowEndIndex));
                    curIndex = rowEndIndex + 1;
                }
                else
                {
                    curIndex++;
                }
            }
            // Re-order node list into TreeView
            if (FormatAsTree)
            {
                Nodes = BuildTreeView(TempList);
            }
            else {
                Nodes = TempList;
            }
        }

        private static int getEndIndex(int start, byte l1, byte l2)
        {
            int length = (256 * l1) + l2;
            return start + length;
        }

        private List<AFPNode> BuildTreeView(List<AFPNode> raw) {
            List<AFPNode> r = new List<AFPNode>();

            Nodes = new List<AFPNode>();
            for (int j = 0; j < raw.Count;)
            {
                
                // If current line SFI matches a start tag, build into interior list
                if (AFPDefinitions.ObjectPairs.StandardFieldElementPairs.ContainsKey(raw[j].Code))
                {
                    // Add Current line as Node
                    AFPNode newNode = raw[j];
                    // Pass in list and index for next creation as children
                    int index;
                    newNode.Nodes = BuildChildGroup(raw, j + 1, raw[j].Code, out index);
                    Nodes.Add(newNode);
                    j = index;
                }
                else
                {
                    Nodes.Add(raw[j]);
                    j++;
                }
            }
            
            return r;
        }

        private static List<AFPNode> BuildChildGroup(List<AFPNode> dl, int sIndex, string SFI, out int index)
        {
            index = 0;
            string EndKey = AFPDefinitions.ObjectPairs.StandardFieldElementPairs[SFI];
            List<AFPNode> Nodes = new List<AFPNode>();
            for (int i = sIndex; i < dl.Count;)
            {
                if (dl[i].Code == EndKey)
                {
                    Nodes.Add(new AFPNode(dl[i]));
                    i++;
                    index = i;
                    break;
                }
                // If current line SFI matches a start tag, build into interior list
                else if (AFPDefinitions.ObjectPairs.StandardFieldElementPairs.ContainsKey(dl[i].Code))
                {
                    // Add Current line as Node
                    AFPNode newNode = new AFPNode(dl[i]);
                    // Pass in list and index for next creation as children
                    newNode.Nodes = BuildChildGroup(dl, i + 1, dl[i].Code, out index);
                    Nodes.Add(newNode);
                    i = index;

                }
                else
                {
                    Nodes.Add(new AFPNode(dl[i]));
                    i++;
                }
            }

            return Nodes;
        }
    }
}
