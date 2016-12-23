namespace ElysiumLaunhcer
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkWindow = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlMax = new System.Windows.Forms.Panel();
            this.chkMaxim = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbRealms = new System.Windows.Forms.ComboBox();
            this.btnAddRealmlist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlMax.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkWindow);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 29);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkWindow
            // 
            this.chkWindow.AutoSize = true;
            this.chkWindow.Location = new System.Drawing.Point(4, 3);
            this.chkWindow.Name = "chkWindow";
            this.chkWindow.Size = new System.Drawing.Size(77, 17);
            this.chkWindow.TabIndex = 1;
            this.chkWindow.Text = "Windowed";
            this.chkWindow.UseVisualStyleBackColor = true;
            this.chkWindow.CheckedChanged += new System.EventHandler(this.chkWindow_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 134);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlMax
            // 
            this.pnlMax.Controls.Add(this.chkMaxim);
            this.pnlMax.Location = new System.Drawing.Point(119, 55);
            this.pnlMax.Name = "pnlMax";
            this.pnlMax.Size = new System.Drawing.Size(94, 29);
            this.pnlMax.TabIndex = 2;
            // 
            // chkMaxim
            // 
            this.chkMaxim.AutoSize = true;
            this.chkMaxim.Location = new System.Drawing.Point(3, 3);
            this.chkMaxim.Name = "chkMaxim";
            this.chkMaxim.Size = new System.Drawing.Size(75, 17);
            this.chkMaxim.TabIndex = 0;
            this.chkMaxim.Text = "Maximized";
            this.chkMaxim.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(119, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbResolution
            // 
            this.cbResolution.FormattingEnabled = true;
            this.cbResolution.Location = new System.Drawing.Point(75, 4);
            this.cbResolution.Name = "cbResolution";
            this.cbResolution.Size = new System.Drawing.Size(121, 21);
            this.cbResolution.TabIndex = 4;
            this.cbResolution.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resolution";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbResolution);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 37);
            this.panel3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Realmlist";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddRealmlist);
            this.panel4.Controls.Add(this.cbRealms);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(12, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 38);
            this.panel4.TabIndex = 8;
            // 
            // cbRealms
            // 
            this.cbRealms.FormattingEnabled = true;
            this.cbRealms.Location = new System.Drawing.Point(91, 6);
            this.cbRealms.Name = "cbRealms";
            this.cbRealms.Size = new System.Drawing.Size(105, 21);
            this.cbRealms.TabIndex = 8;
            // 
            // btnAddRealmlist
            // 
            this.btnAddRealmlist.Location = new System.Drawing.Point(67, 6);
            this.btnAddRealmlist.Name = "btnAddRealmlist";
            this.btnAddRealmlist.Size = new System.Drawing.Size(22, 21);
            this.btnAddRealmlist.TabIndex = 9;
            this.btnAddRealmlist.Text = "+";
            this.btnAddRealmlist.UseVisualStyleBackColor = true;
            this.btnAddRealmlist.Click += new System.EventHandler(this.btnAddRealmlist_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 173);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlMax);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMax.ResumeLayout(false);
            this.pnlMax.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkWindow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlMax;
        private System.Windows.Forms.CheckBox chkMaxim;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbRealms;
        private System.Windows.Forms.Button btnAddRealmlist;
    }
}