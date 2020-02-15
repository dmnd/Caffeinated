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
            this.label1 = new System.Windows.Forms.Label();
            this.OriginallyByLink = new System.Windows.Forms.LinkLabel();
            this.ForkedByTheJoeFinLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Caffeinated.Properties.Resources.Caffeine_Black_96;
            this.pictureBox1.Location = new System.Drawing.Point(100, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 172);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Version 1.1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(8, 323);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 67);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prevents your PC from going to sleep or displaying the screen saver.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dmndLbl
            // 
            this.dmndLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dmndLbl.AutoSize = true;
            this.dmndLbl.Location = new System.Drawing.Point(34, 365);
            this.dmndLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dmndLbl.Name = "dmndLbl";
            this.dmndLbl.Size = new System.Drawing.Size(0, 25);
            this.dmndLbl.TabIndex = 17;
            this.dmndLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dmndLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // caffeineLbl
            // 
            this.caffeineLbl.AutoSize = true;
            this.caffeineLbl.LinkArea = new System.Windows.Forms.LinkArea(12, 17);
            this.caffeineLbl.Location = new System.Drawing.Point(67, 390);
            this.caffeineLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caffeineLbl.Name = "caffeineLbl";
            this.caffeineLbl.Size = new System.Drawing.Size(246, 30);
            this.caffeineLbl.TabIndex = 18;
            this.caffeineLbl.TabStop = true;
            this.caffeineLbl.Text = "Inspired by Caffeine for OS X.";
            this.caffeineLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.caffeineLbl.UseCompatibleTextRendering = true;
            this.caffeineLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Caffeinated";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OriginallyByLink
            // 
            this.OriginallyByLink.AutoSize = true;
            this.OriginallyByLink.LinkArea = new System.Windows.Forms.LinkArea(14, 18);
            this.OriginallyByLink.Location = new System.Drawing.Point(17, 439);
            this.OriginallyByLink.Name = "OriginallyByLink";
            this.OriginallyByLink.Size = new System.Drawing.Size(163, 30);
            this.OriginallyByLink.TabIndex = 21;
            this.OriginallyByLink.TabStop = true;
            this.OriginallyByLink.Text = "Originally by dmnd";
            this.OriginallyByLink.UseCompatibleTextRendering = true;
            this.OriginallyByLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ForkedByTheJoeFinLink
            // 
            this.ForkedByTheJoeFinLink.AutoSize = true;
            this.ForkedByTheJoeFinLink.LinkArea = new System.Windows.Forms.LinkArea(10, 19);
            this.ForkedByTheJoeFinLink.Location = new System.Drawing.Point(198, 439);
            this.ForkedByTheJoeFinLink.Name = "ForkedByTheJoeFinLink";
            this.ForkedByTheJoeFinLink.Size = new System.Drawing.Size(174, 30);
            this.ForkedByTheJoeFinLink.TabIndex = 22;
            this.ForkedByTheJoeFinLink.TabStop = true;
            this.ForkedByTheJoeFinLink.Text = "Forked by TheJoeFin";
            this.ForkedByTheJoeFinLink.UseCompatibleTextRendering = true;
            this.ForkedByTheJoeFinLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForkedByTheJoeFinLink_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 481);
            this.Controls.Add(this.ForkedByTheJoeFinLink);
            this.Controls.Add(this.OriginallyByLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caffeineLbl);
            this.Controls.Add(this.dmndLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(14, 17, 14, 17);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel OriginallyByLink;
        private System.Windows.Forms.LinkLabel ForkedByTheJoeFinLink;
    }
}
