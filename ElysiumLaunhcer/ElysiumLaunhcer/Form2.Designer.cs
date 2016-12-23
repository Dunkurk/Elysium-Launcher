namespace ElysiumLaunhcer
{
    partial class frmFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirstTime));
            this.btnRealmlistDefault = new System.Windows.Forms.Button();
            this.btnSelectLocation = new System.Windows.Forms.Button();
            this.btmEditRealmlist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRealmlist = new System.Windows.Forms.Panel();
            this.pnlRealmlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRealmlistDefault
            // 
            this.btnRealmlistDefault.Location = new System.Drawing.Point(44, 25);
            this.btnRealmlistDefault.Name = "btnRealmlistDefault";
            this.btnRealmlistDefault.Size = new System.Drawing.Size(116, 23);
            this.btnRealmlistDefault.TabIndex = 0;
            this.btnRealmlistDefault.Text = "Use Elysium";
            this.btnRealmlistDefault.UseVisualStyleBackColor = true;
            this.btnRealmlistDefault.Click += new System.EventHandler(this.btnRealmlistDefault_Click);
            // 
            // btnSelectLocation
            // 
            this.btnSelectLocation.Location = new System.Drawing.Point(59, 25);
            this.btnSelectLocation.MaximumSize = new System.Drawing.Size(113, 23);
            this.btnSelectLocation.MinimumSize = new System.Drawing.Size(113, 23);
            this.btnSelectLocation.Name = "btnSelectLocation";
            this.btnSelectLocation.Size = new System.Drawing.Size(113, 23);
            this.btnSelectLocation.TabIndex = 1;
            this.btnSelectLocation.Text = "Select Folder";
            this.btnSelectLocation.UseVisualStyleBackColor = true;
            this.btnSelectLocation.Click += new System.EventHandler(this.btnSelectLocation_Click);
            // 
            // btmEditRealmlist
            // 
            this.btmEditRealmlist.Location = new System.Drawing.Point(44, 54);
            this.btmEditRealmlist.Name = "btmEditRealmlist";
            this.btmEditRealmlist.Size = new System.Drawing.Size(116, 23);
            this.btmEditRealmlist.TabIndex = 2;
            this.btmEditRealmlist.Text = "Edit Realmlist";
            this.btmEditRealmlist.UseVisualStyleBackColor = true;
            this.btmEditRealmlist.Click += new System.EventHandler(this.btmEditRealmlist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realmlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vanilla WoW Location";
            // 
            // pnlRealmlist
            // 
            this.pnlRealmlist.Controls.Add(this.label1);
            this.pnlRealmlist.Controls.Add(this.btnRealmlistDefault);
            this.pnlRealmlist.Controls.Add(this.btmEditRealmlist);
            this.pnlRealmlist.Location = new System.Drawing.Point(12, 54);
            this.pnlRealmlist.Name = "pnlRealmlist";
            this.pnlRealmlist.Size = new System.Drawing.Size(200, 100);
            this.pnlRealmlist.TabIndex = 5;
            this.pnlRealmlist.Visible = false;
            // 
            // frmFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 153);
            this.Controls.Add(this.pnlRealmlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFirstTime";
            this.Text = "First Time Setup";
            this.Load += new System.EventHandler(this.frmFirstTime_Load);
            this.pnlRealmlist.ResumeLayout(false);
            this.pnlRealmlist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRealmlistDefault;
        private System.Windows.Forms.Button btnSelectLocation;
        private System.Windows.Forms.Button btmEditRealmlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlRealmlist;
    }
}