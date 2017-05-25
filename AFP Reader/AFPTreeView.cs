using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFP_Reader
{
    public class AFPNode
    {
        public List<AFPNode> Children { get; set; }
        public string Name { get; set; }
        public AFPDataLine Data { get; set; }

        public AFPNode(AFPDataLine line)
        {
            // create single line with no children
            Data = line;
            Name = line.SFIString;
        }
        public static List<AFPNode> BuildChildGroup(List<AFPDataLine> dl, int sIndex, string SFI, out int index)
        {
            index = 0;
            string EndKey = AFPFile.StandardFieldElementPairs[SFI];
            List<AFPNode> Nodes = new List<AFPNode>();
            for (int i = sIndex; i < dl.Count;)
            {
                // Skip all No Operations
                if (dl[i].SFICode == "NOP")
                {
                    i++;
                    continue;
                }

                if (dl[i].SFICode == EndKey)
                {
                    Nodes.Add(new AFPNode(dl[i]));
                    i++;
                    index = i;
                    break;
                }
                // If current line SFI matches a start tag, build into interior list
                else if (AFPFile.StandardFieldElementPairs.ContainsKey(dl[i].SFICode))
                {
                    // Add Current line as Node
                    AFPNode newNode = new AFPNode(dl[i]);
                    // Pass in list and index for next creation as children
                    newNode.Children = BuildChildGroup(dl, i + 1, dl[i].SFICode, out index);
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
    public class AFPTreeView
    {
        public int Count { get; set; }
        public List<AFPNode> Nodes { get; set; }
        public AFPTreeView(List<AFPDataLine> dl)
        {
            Nodes = new List<AFPNode>();
            for (int j = 0; j < dl.Count;)
            {
                // Skip all No Operations
                if (dl[j].SFICode == "NOP")
                {
                    j++;
                    continue;
                }
                // If current line SFI matches a start tag, build into interior list
                if (AFPFile.StandardFieldElementPairs.ContainsKey(dl[j].SFICode))
                {
                    // Add Current line as Node
                    AFPNode newNode = new AFPNode(dl[j]);
                    // Pass in list and index for next creation as children
                    int index;
                    newNode.Children = AFPNode.BuildChildGroup(dl, j + 1, dl[j].SFICode, out index);
                    Nodes.Add(newNode);
                    j = index;
                }
                else
                {
                    Nodes.Add(new AFPNode(dl[j]));
                    j++;
                }
            }
            
        }

        public void populateTreeView(TreeView view)
        {
            foreach (AFPNode Node in Nodes) {
                TreeNode tn = view.Nodes.Add(Node.Name);
                tn.Tag = Node.Data;
                foreach (AFPNode child in Node.Children) {
                    tn = AddChildNodes(tn, child);
                }
            }

        }
        private TreeNode AddChildNodes(TreeNode tn, AFPNode child) {
            TreeNode tnx= tn.Nodes.Add(child.Name);
            tnx.Tag = child.Data;
            if (child.Children != null) {
                foreach (AFPNode ch in child.Children)
                {
                    tnx = AddChildNodes(tnx, ch);
                }
            }
            
            return tn;
        }
    }
    
}
