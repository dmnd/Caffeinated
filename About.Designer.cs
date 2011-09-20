namespace Caffeinated {
    partial class AboutForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dmndLbl = new System.Windows.Forms.LinkLabel();
            this.caffeineLbl = new System.Windows.Forms.LinkLabel();
            this.visualpharmaLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Caffeinated.Properties.Resources.cup_coffee_icon_64;
            this.pictureBox1.Location = new System.Drawing.Point(81, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Version 1.0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(5, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prevents your PC from going to sleep or displaying the screen saver.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dmndLbl
            // 
            this.dmndLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dmndLbl.AutoSize = true;
            this.dmndLbl.Location = new System.Drawing.Point(24, 219);
            this.dmndLbl.Name = "dmndLbl";
            this.dmndLbl.Size = new System.Drawing.Size(179, 15);
            this.dmndLbl.TabIndex = 17;
            this.dmndLbl.TabStop = true;
            this.dmndLbl.Text = "desmondbrand.com/caffeinated";
            this.dmndLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dmndLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // caffeineLbl
            // 
            this.caffeineLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.caffeineLbl.AutoSize = true;
            this.caffeineLbl.LinkArea = new System.Windows.Forms.LinkArea(12, 17);
            this.caffeineLbl.Location = new System.Drawing.Point(31, 177);
            this.caffeineLbl.Name = "caffeineLbl";
            this.caffeineLbl.Size = new System.Drawing.Size(164, 21);
            this.caffeineLbl.TabIndex = 18;
            this.caffeineLbl.TabStop = true;
            this.caffeineLbl.Text = "Inspired by Caffeine for OS X.";
            this.caffeineLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.caffeineLbl.UseCompatibleTextRendering = true;
            this.caffeineLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // visualpharmaLbl
            // 
            this.visualpharmaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.visualpharmaLbl.AutoSize = true;
            this.visualpharmaLbl.LinkArea = new System.Windows.Forms.LinkArea(9, 11);
            this.visualpharmaLbl.Location = new System.Drawing.Point(52, 194);
            this.visualpharmaLbl.Name = "visualpharmaLbl";
            this.visualpharmaLbl.Size = new System.Drawing.Size(123, 21);
            this.visualpharmaLbl.TabIndex = 19;
            this.visualpharmaLbl.TabStop = true;
            this.visualpharmaLbl.Text = "Icons by VisualPharm.";
            this.visualpharmaLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.visualpharmaLbl.UseCompatibleTextRendering = true;
            this.visualpharmaLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Caffeinated";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visualpharmaLbl);
            this.Controls.Add(this.caffeineLbl);
            this.Controls.Add(this.dmndLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Caffeinated";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel dmndLbl;
        private System.Windows.Forms.LinkLabel caffeineLbl;
        private System.Windows.Forms.LinkLabel visualpharmaLbl;
        private System.Windows.Forms.Label label1;

    }
}
