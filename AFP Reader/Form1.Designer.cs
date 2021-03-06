﻿namespace AFP_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnloadafp = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lstLines = new System.Windows.Forms.ListBox();
            this._lblpre1 = new System.Windows.Forms.Label();
            this._lblLen1 = new System.Windows.Forms.Label();
            this._lblsfi1 = new System.Windows.Forms.Label();
            this._lblflag1 = new System.Windows.Forms.Label();
            this._lblres1 = new System.Windows.Forms.Label();
            this.lblAFPPre = new System.Windows.Forms.Label();
            this.lblAFPLen1 = new System.Windows.Forms.Label();
            this.lblAFPSFI1 = new System.Windows.Forms.Label();
            this.lblAFPSFI2 = new System.Windows.Forms.Label();
            this.lblAFPSFI3 = new System.Windows.Forms.Label();
            this.lblAFPFlag = new System.Windows.Forms.Label();
            this.lblAFPRes1 = new System.Windows.Forms.Label();
            this.lblAFPRes2 = new System.Windows.Forms.Label();
            this.lblReadSFI = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.txtSFDesc = new System.Windows.Forms.TextBox();
            this.tabAFPLineList = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtData = new System.Windows.Forms.TextBox();
            this.tabAFPLineList.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnloadafp
            // 
            this.btnloadafp.Location = new System.Drawing.Point(12, 4);
            this.btnloadafp.Name = "btnloadafp";
            this.btnloadafp.Size = new System.Drawing.Size(102, 23);
            this.btnloadafp.TabIndex = 0;
            this.btnloadafp.Text = "Load AFP File";
            this.btnloadafp.UseVisualStyleBackColor = true;
            this.btnloadafp.Click += new System.EventHandler(this.btnloadafp_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(128, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(79, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "No File Loaded";
            // 
            // lstLines
            // 
            this.lstLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLines.FormattingEnabled = true;
            this.lstLines.Location = new System.Drawing.Point(3, 3);
            this.lstLines.Name = "lstLines";
            this.lstLines.Size = new System.Drawing.Size(539, 391);
            this.lstLines.TabIndex = 2;
            this.lstLines.SelectedIndexChanged += new System.EventHandler(this.lstLines_SelectedIndexChanged);
            // 
            // _lblpre1
            // 
            this._lblpre1.AutoSize = true;
            this._lblpre1.Location = new System.Drawing.Point(648, 55);
            this._lblpre1.Name = "_lblpre1";
            this._lblpre1.Size = new System.Drawing.Size(33, 13);
            this._lblpre1.TabIndex = 3;
            this._lblpre1.Text = "Prefix";
            // 
            // _lblLen1
            // 
            this._lblLen1.AutoSize = true;
            this._lblLen1.Location = new System.Drawing.Point(690, 55);
            this._lblLen1.Name = "_lblLen1";
            this._lblLen1.Size = new System.Drawing.Size(40, 13);
            this._lblLen1.TabIndex = 4;
            this._lblLen1.Text = "Length";
            // 
            // _lblsfi1
            // 
            this._lblsfi1.AutoSize = true;
            this._lblsfi1.Location = new System.Drawing.Point(774, 55);
            this._lblsfi1.Name = "_lblsfi1";
            this._lblsfi1.Size = new System.Drawing.Size(63, 13);
            this._lblsfi1.TabIndex = 5;
            this._lblsfi1.Text = "SF Identifier";
            // 
            // _lblflag1
            // 
            this._lblflag1.AutoSize = true;
            this._lblflag1.Location = new System.Drawing.Point(874, 55);
            this._lblflag1.Name = "_lblflag1";
            this._lblflag1.Size = new System.Drawing.Size(32, 13);
            this._lblflag1.TabIndex = 6;
            this._lblflag1.Text = "Flags";
            // 
            // _lblres1
            // 
            this._lblres1.AutoSize = true;
            this._lblres1.Location = new System.Drawing.Point(928, 55);
            this._lblres1.Name = "_lblres1";
            this._lblres1.Size = new System.Drawing.Size(57, 13);
            this._lblres1.TabIndex = 7;
            this._lblres1.Text = "\'Reserved\'";
            // 
            // lblAFPPre
            // 
            this.lblAFPPre.AutoSize = true;
            this.lblAFPPre.BackColor = System.Drawing.Color.White;
            this.lblAFPPre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPPre.Location = new System.Drawing.Point(651, 72);
            this.lblAFPPre.Name = "lblAFPPre";
            this.lblAFPPre.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPPre.Size = new System.Drawing.Size(31, 25);
            this.lblAFPPre.TabIndex = 9;
            this.lblAFPPre.Text = "5a";
            // 
            // lblAFPLen1
            // 
            this.lblAFPLen1.AutoSize = true;
            this.lblAFPLen1.BackColor = System.Drawing.Color.White;
            this.lblAFPLen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPLen1.Location = new System.Drawing.Point(693, 72);
            this.lblAFPLen1.Name = "lblAFPLen1";
            this.lblAFPLen1.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPLen1.Size = new System.Drawing.Size(31, 25);
            this.lblAFPLen1.TabIndex = 10;
            this.lblAFPLen1.Text = "5a";
            // 
            // lblAFPSFI1
            // 
            this.lblAFPSFI1.AutoSize = true;
            this.lblAFPSFI1.BackColor = System.Drawing.Color.White;
            this.lblAFPSFI1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPSFI1.Location = new System.Drawing.Point(752, 72);
            this.lblAFPSFI1.Name = "lblAFPSFI1";
            this.lblAFPSFI1.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPSFI1.Size = new System.Drawing.Size(31, 25);
            this.lblAFPSFI1.TabIndex = 12;
            this.lblAFPSFI1.Text = "5a";
            // 
            // lblAFPSFI2
            // 
            this.lblAFPSFI2.AutoSize = true;
            this.lblAFPSFI2.BackColor = System.Drawing.Color.White;
            this.lblAFPSFI2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPSFI2.Location = new System.Drawing.Point(789, 72);
            this.lblAFPSFI2.Name = "lblAFPSFI2";
            this.lblAFPSFI2.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPSFI2.Size = new System.Drawing.Size(31, 25);
            this.lblAFPSFI2.TabIndex = 13;
            this.lblAFPSFI2.Text = "5a";
            // 
            // lblAFPSFI3
            // 
            this.lblAFPSFI3.AutoSize = true;
            this.lblAFPSFI3.BackColor = System.Drawing.Color.White;
            this.lblAFPSFI3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPSFI3.Location = new System.Drawing.Point(826, 72);
            this.lblAFPSFI3.Name = "lblAFPSFI3";
            this.lblAFPSFI3.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPSFI3.Size = new System.Drawing.Size(31, 25);
            this.lblAFPSFI3.TabIndex = 14;
            this.lblAFPSFI3.Text = "5a";
            // 
            // lblAFPFlag
            // 
            this.lblAFPFlag.AutoSize = true;
            this.lblAFPFlag.BackColor = System.Drawing.Color.White;
            this.lblAFPFlag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPFlag.Location = new System.Drawing.Point(875, 72);
            this.lblAFPFlag.Name = "lblAFPFlag";
            this.lblAFPFlag.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPFlag.Size = new System.Drawing.Size(31, 25);
            this.lblAFPFlag.TabIndex = 15;
            this.lblAFPFlag.Text = "5a";
            // 
            // lblAFPRes1
            // 
            this.lblAFPRes1.AutoSize = true;
            this.lblAFPRes1.BackColor = System.Drawing.Color.White;
            this.lblAFPRes1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPRes1.Location = new System.Drawing.Point(921, 72);
            this.lblAFPRes1.Name = "lblAFPRes1";
            this.lblAFPRes1.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPRes1.Size = new System.Drawing.Size(31, 25);
            this.lblAFPRes1.TabIndex = 16;
            this.lblAFPRes1.Text = "5a";
            // 
            // lblAFPRes2
            // 
            this.lblAFPRes2.AutoSize = true;
            this.lblAFPRes2.BackColor = System.Drawing.Color.White;
            this.lblAFPRes2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAFPRes2.Location = new System.Drawing.Point(954, 72);
            this.lblAFPRes2.Name = "lblAFPRes2";
            this.lblAFPRes2.Padding = new System.Windows.Forms.Padding(5);
            this.lblAFPRes2.Size = new System.Drawing.Size(31, 25);
            this.lblAFPRes2.TabIndex = 17;
            this.lblAFPRes2.Text = "5a";
            // 
            // lblReadSFI
            // 
            this.lblReadSFI.AutoSize = true;
            this.lblReadSFI.BackColor = System.Drawing.Color.White;
            this.lblReadSFI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReadSFI.Location = new System.Drawing.Point(651, 110);
            this.lblReadSFI.Name = "lblReadSFI";
            this.lblReadSFI.Padding = new System.Windows.Forms.Padding(5);
            this.lblReadSFI.Size = new System.Drawing.Size(31, 25);
            this.lblReadSFI.TabIndex = 30;
            this.lblReadSFI.Text = "5a";
            // 
            // lblReference
            // 
            this.lblReference.Location = new System.Drawing.Point(857, 122);
            this.lblReference.Name = "lblReference";
            this.lblReference.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblReference.Size = new System.Drawing.Size(443, 13);
            this.lblReference.TabIndex = 32;
            this.lblReference.Text = "Reference Information Missing";
            this.lblReference.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSFDesc
            // 
            this.txtSFDesc.Location = new System.Drawing.Point(651, 149);
            this.txtSFDesc.Multiline = true;
            this.txtSFDesc.Name = "txtSFDesc";
            this.txtSFDesc.ReadOnly = true;
            this.txtSFDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSFDesc.Size = new System.Drawing.Size(649, 109);
            this.txtSFDesc.TabIndex = 31;
            // 
            // tabAFPLineList
            // 
            this.tabAFPLineList.Controls.Add(this.tabPage3);
            this.tabAFPLineList.Controls.Add(this.tabPage4);
            this.tabAFPLineList.Location = new System.Drawing.Point(12, 33);
            this.tabAFPLineList.Name = "tabAFPLineList";
            this.tabAFPLineList.SelectedIndex = 0;
            this.tabAFPLineList.Size = new System.Drawing.Size(553, 423);
            this.tabAFPLineList.TabIndex = 33;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstLines);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(545, 397);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Raw View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.treeView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(545, 397);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Tree View";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(539, 391);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(651, 289);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(649, 160);
            this.txtData.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1305, 457);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.txtSFDesc);
            this.Controls.Add(this.tabAFPLineList);
            this.Controls.Add(this._lblpre1);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblReadSFI);
            this.Controls.Add(this.btnloadafp);
            this.Controls.Add(this._lblLen1);
            this.Controls.Add(this.lblAFPPre);
            this.Controls.Add(this.lblAFPRes2);
            this.Controls.Add(this.lblAFPSFI1);
            this.Controls.Add(this._lblsfi1);
            this.Controls.Add(this.lblAFPLen1);
            this.Controls.Add(this.lblAFPRes1);
            this.Controls.Add(this.lblAFPSFI2);
            this.Controls.Add(this._lblflag1);
            this.Controls.Add(this.lblAFPSFI3);
            this.Controls.Add(this.lblAFPFlag);
            this.Controls.Add(this._lblres1);
            this.Name = "Form1";
            this.Text = "AFP Translator";
            this.tabAFPLineList.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnloadafp;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ListBox lstLines;
        private System.Windows.Forms.Label _lblpre1;
        private System.Windows.Forms.Label _lblLen1;
        private System.Windows.Forms.Label _lblsfi1;
        private System.Windows.Forms.Label _lblflag1;
        private System.Windows.Forms.Label _lblres1;
        private System.Windows.Forms.Label lblAFPPre;
        private System.Windows.Forms.Label lblAFPLen1;
        private System.Windows.Forms.Label lblAFPSFI1;
        private System.Windows.Forms.Label lblAFPSFI2;
        private System.Windows.Forms.Label lblAFPSFI3;
        private System.Windows.Forms.Label lblAFPFlag;
        private System.Windows.Forms.Label lblAFPRes1;
        private System.Windows.Forms.Label lblAFPRes2;
        private System.Windows.Forms.Label lblReadSFI;
        private System.Windows.Forms.TextBox txtSFDesc;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.TabControl tabAFPLineList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtData;
    }
}

