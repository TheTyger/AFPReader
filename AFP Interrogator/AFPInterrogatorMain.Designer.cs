namespace AFP_Interrogator
{
    partial class AFPInterrogatorMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainForm = new System.Windows.Forms.TabPage();
            this.lblFileName = new System.Windows.Forms.Label();
            this._lblFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstNodes = new System.Windows.Forms.ListBox();
            this._lblNodeCount = new System.Windows.Forms.Label();
            this.lblNodeCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._lblType = new System.Windows.Forms.Label();
            this._lblfTypeDesc = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtTypeDesc = new System.Windows.Forms.TextBox();
            this._lblCat = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCatDesc = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabMainForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainForm);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1398, 591);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMainForm
            // 
            this.tabMainForm.Controls.Add(this.lblNodeCount);
            this.tabMainForm.Controls.Add(this._lblNodeCount);
            this.tabMainForm.Controls.Add(this.lblFileName);
            this.tabMainForm.Controls.Add(this._lblFileName);
            this.tabMainForm.Controls.Add(this.label1);
            this.tabMainForm.Location = new System.Drawing.Point(4, 22);
            this.tabMainForm.Name = "tabMainForm";
            this.tabMainForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainForm.Size = new System.Drawing.Size(1390, 565);
            this.tabMainForm.TabIndex = 0;
            this.tabMainForm.Text = "Document Overview";
            this.tabMainForm.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(228, 35);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(16, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "...";
            // 
            // _lblFileName
            // 
            this._lblFileName.AutoSize = true;
            this._lblFileName.Location = new System.Drawing.Point(11, 35);
            this._lblFileName.Name = "_lblFileName";
            this._lblFileName.Size = new System.Drawing.Size(60, 13);
            this._lblFileName.TabIndex = 1;
            this._lblFileName.Text = "File Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document Information:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCatDesc);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblCat);
            this.tabPage2.Controls.Add(this._lblCat);
            this.tabPage2.Controls.Add(this.txtTypeDesc);
            this.tabPage2.Controls.Add(this.lblType);
            this.tabPage2.Controls.Add(this._lblfTypeDesc);
            this.tabPage2.Controls.Add(this._lblType);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lstNodes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1390, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Node Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstNodes
            // 
            this.lstNodes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstNodes.FormattingEnabled = true;
            this.lstNodes.Location = new System.Drawing.Point(3, 3);
            this.lstNodes.Name = "lstNodes";
            this.lstNodes.Size = new System.Drawing.Size(199, 559);
            this.lstNodes.TabIndex = 1;
            this.lstNodes.SelectedIndexChanged += new System.EventHandler(this.lstNodes_SelectedIndexChanged);
            // 
            // _lblNodeCount
            // 
            this._lblNodeCount.AutoSize = true;
            this._lblNodeCount.Location = new System.Drawing.Point(14, 70);
            this._lblNodeCount.Name = "_lblNodeCount";
            this._lblNodeCount.Size = new System.Drawing.Size(64, 13);
            this._lblNodeCount.TabIndex = 3;
            this._lblNodeCount.Text = "Node Count";
            // 
            // lblNodeCount
            // 
            this.lblNodeCount.AutoSize = true;
            this.lblNodeCount.Location = new System.Drawing.Point(231, 70);
            this.lblNodeCount.Name = "lblNodeCount";
            this.lblNodeCount.Size = new System.Drawing.Size(16, 13);
            this.lblNodeCount.TabIndex = 4;
            this.lblNodeCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Node Information: ";
            // 
            // _lblType
            // 
            this._lblType.AutoSize = true;
            this._lblType.Location = new System.Drawing.Point(330, 215);
            this._lblType.Name = "_lblType";
            this._lblType.Size = new System.Drawing.Size(62, 13);
            this._lblType.TabIndex = 3;
            this._lblType.Text = "Field Type: ";
            // 
            // _lblfTypeDesc
            // 
            this._lblfTypeDesc.AutoSize = true;
            this._lblfTypeDesc.Location = new System.Drawing.Point(280, 254);
            this._lblfTypeDesc.Name = "_lblfTypeDesc";
            this._lblfTypeDesc.Size = new System.Drawing.Size(112, 13);
            this._lblfTypeDesc.TabIndex = 4;
            this._lblfTypeDesc.Text = "Field Type Description";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(399, 215);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(16, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "...";
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Location = new System.Drawing.Point(402, 254);
            this.txtTypeDesc.Multiline = true;
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.ReadOnly = true;
            this.txtTypeDesc.Size = new System.Drawing.Size(685, 113);
            this.txtTypeDesc.TabIndex = 6;
            // 
            // _lblCat
            // 
            this._lblCat.AutoSize = true;
            this._lblCat.Location = new System.Drawing.Point(312, 380);
            this._lblCat.Name = "_lblCat";
            this._lblCat.Size = new System.Drawing.Size(80, 13);
            this._lblCat.TabIndex = 7;
            this._lblCat.Text = "Field Category: ";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(402, 380);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(16, 13);
            this.lblCat.TabIndex = 8;
            this.lblCat.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Field Category Description";
            // 
            // txtCatDesc
            // 
            this.txtCatDesc.Location = new System.Drawing.Point(402, 419);
            this.txtCatDesc.Multiline = true;
            this.txtCatDesc.Name = "txtCatDesc";
            this.txtCatDesc.ReadOnly = true;
            this.txtCatDesc.Size = new System.Drawing.Size(685, 119);
            this.txtCatDesc.TabIndex = 10;
            // 
            // AFPInterrogatorMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "AFPInterrogatorMain";
            this.Text = "AFP File Interrogator";
            this.tabControl1.ResumeLayout(false);
            this.tabMainForm.ResumeLayout(false);
            this.tabMainForm.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainForm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label _lblFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNodes;
        private System.Windows.Forms.Label lblNodeCount;
        private System.Windows.Forms.Label _lblNodeCount;
        private System.Windows.Forms.TextBox txtTypeDesc;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label _lblfTypeDesc;
        private System.Windows.Forms.Label _lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label _lblCat;
    }
}

