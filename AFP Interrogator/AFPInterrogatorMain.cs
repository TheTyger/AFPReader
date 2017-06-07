using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AFPParser;
using System.IO;

namespace AFP_Interrogator
{
    public partial class AFPInterrogatorMain : Form
    {
        public AFPInterrogatorMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AFP Files|*.afp";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                // parse for line data
                byte[] afpdata = File.ReadAllBytes(dlg.FileName);
                AFPDocument Doc = new AFPDocument(afpdata);

                //Update Document Info
                lblFileName.Text = dlg.FileName;
                lblNodeCount.Text = Doc.Nodes.Count.ToString();
                // Update list tab
                lstNodes.DataSource = Doc.Nodes;
                lstNodes.DisplayMember = "Name";

                // build AFP Data field
                // Build readable data field
                //AFPTreeView tv = new AFPTreeView(parsedData);
                //tv.populateTreeView(treeView1);
                string x = "0";
            }
        }

        private void lstNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AFPNode dl = (AFPNode)lstNodes.SelectedItem;
            updateFields(dl);
        }
        private void updateFields(AFPNode dl)
        {
            lblType.Text = dl.TypeName;
            txtTypeDesc.Text = dl.TypeDescription;
            lblCat.Text = dl.CategoryName;
            txtCatDesc.Text = dl.CategoryDescription;

            //lblAFPFlag.Text = dl.Flags;
            //lblAFPLen1.Text = dl.length.ToString();
            //lblAFPSFI1.Text = dl.SFIdentifier[0];
            //lblAFPSFI2.Text = dl.SFIdentifier[1];
            //lblAFPSFI3.Text = dl.SFIdentifier[2];
            //lblAFPPre.Text = dl.prefix;
            //lblAFPRes1.Text = dl.reserved[0];
            //lblAFPRes2.Text = dl.reserved[1];
            //lblReadSFI.Text = dl.SFIString;
            //lblReference.Text = dl.SFIReference;
            //txtSFDesc.Text = dl.SFIDesc;
            //txtData.Text = ConvertDataArraytoString(dl.data);
        }
    }
}
