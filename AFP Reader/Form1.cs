using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AFPParser;

namespace AFP_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnloadafp_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AFP Files|*.afp";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK) {
                lblFileName.Text = dlg.FileName;

                // parse for line data
                byte[] afpdata = File.ReadAllBytes(dlg.FileName);
                AFPDocument Doc = new AFPDocument(afpdata);
                List<AFPDataLine> parsedData = AFPFormatHelper.Lines(afpdata);
                
                lstLines.DataSource = Doc.Nodes;
                lstLines.DisplayMember = "Name";

                // build AFP Data field
                // Build readable data field
                AFPTreeView tv = new AFPTreeView(parsedData);
                tv.populateTreeView(treeView1);
                string x = "0";
            }
            
        }

        private void lstLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            AFPDataLine dl = (AFPDataLine)lstLines.SelectedItem;
            updateFields(dl);
        }
        private void updateFields(AFPDataLine dl) {
            lblAFPFlag.Text = dl.flags;
            lblAFPLen1.Text = dl.length.ToString();
            lblAFPSFI1.Text = dl.SFIdentifier[0];
            lblAFPSFI2.Text = dl.SFIdentifier[1];
            lblAFPSFI3.Text = dl.SFIdentifier[2];
            lblAFPPre.Text = dl.prefix;
            lblAFPRes1.Text = dl.reserved[0];
            lblAFPRes2.Text = dl.reserved[1];
            lblReadSFI.Text = dl.SFIString;
            lblReference.Text = dl.SFIReference;
            txtSFDesc.Text = dl.SFIDesc;
            txtData.Text = ConvertDataArraytoString(dl.data);
        }

        private string ConvertDataArraytoString(List<byte> l) {
            StringBuilder pacMan = new StringBuilder();
            foreach (byte nom in l) {
                pacMan.Append(nom.ToString("X2"));
            }
            return pacMan.ToString();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AFPDataLine dl = (AFPDataLine)treeView1.SelectedNode.Tag;
            updateFields(dl);
        }
    }
}
