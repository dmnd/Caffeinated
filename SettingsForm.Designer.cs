namespace Caffeinated {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.DefaultDurationBox = new System.Windows.Forms.ComboBox();
            this.SettingsAtLaunchChkBox = new System.Windows.Forms.CheckBox();
            this.ActivateChkBox = new System.Windows.Forms.CheckBox();
            this.StartupChkBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 200);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caffeinated is now running. You can find its icon in the notification area near t" +
    "he clock. Click it to keep your PC awake by disabling automatic sleep. Click the" +
    " icon again to allow automatic sleep.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right-click the notification area icon to show the Caffeinated menu.";
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okBtn.Location = new System.Drawing.Point(376, 556);
            this.okBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(124, 45);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelBtn.Location = new System.Drawing.Point(510, 556);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 45);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caffeinated.Properties.Resources.Caffeine_Black_96;
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 160);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.SettingsAtLaunchChkBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ActivateChkBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StartupChkBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.radioButton3, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(186, 187);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(416, 361);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DefaultDurationBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 140);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(410, 56);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Default duration:";
            // 
            // DefaultDurationBox
            // 
            this.DefaultDurationBox.FormattingEnabled = true;
            this.DefaultDurationBox.Location = new System.Drawing.Point(157, 5);
            this.DefaultDurationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DefaultDurationBox.Name = "DefaultDurationBox";
            this.DefaultDurationBox.Size = new System.Drawing.Size(180, 33);
            this.DefaultDurationBox.TabIndex = 8;
            // 
            // SettingsAtLaunchChkBox
            // 
            this.SettingsAtLaunchChkBox.AutoSize = true;
            this.SettingsAtLaunchChkBox.Checked = global::Caffeinated.Properties.Settings.Default.ShowSettingsAtLaunch;
            this.SettingsAtLaunchChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SettingsAtLaunchChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Caffeinated.Properties.Settings.Default, "ShowSettingsAtLaunch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SettingsAtLaunchChkBox.Location = new System.Drawing.Point(4, 83);
            this.SettingsAtLaunchChkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsAtLaunchChkBox.Name = "SettingsAtLaunchChkBox";
            this.SettingsAtLaunchChkBox.Size = new System.Drawing.Size(293, 29);
            this.SettingsAtLaunchChkBox.TabIndex = 5;
            this.SettingsAtLaunchChkBox.Text = "Show this message upon launch";
            this.SettingsAtLaunchChkBox.UseVisualStyleBackColor = true;
            // 
            // ActivateChkBox
            // 
            this.ActivateChkBox.AutoSize = true;
            this.ActivateChkBox.Checked = global::Caffeinated.Properties.Settings.Default.ActivateAtLaunch;
            this.ActivateChkBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Caffeinated.Properties.Settings.Default, "ActivateAtLaunch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ActivateChkBox.Location = new System.Drawing.Point(4, 44);
            this.ActivateChkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActivateChkBox.Name = "ActivateChkBox";
            this.ActivateChkBox.Size = new System.Drawing.Size(204, 29);
            this.ActivateChkBox.TabIndex = 4;
            this.ActivateChkBox.Text = "Activate upon launch";
            this.ActivateChkBox.UseVisualStyleBackColor = true;
            // 
            // StartupChkBox
            // 
            this.StartupChkBox.AutoSize = true;
            this.StartupChkBox.Location = new System.Drawing.Point(4, 5);
            this.StartupChkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartupChkBox.Name = "StartupChkBox";
            this.StartupChkBox.Size = new System.Drawing.Size(362, 29);
            this.StartupChkBox.TabIndex = 3;
            this.StartupChkBox.Text = "Automatically launch at Windows startup";
            this.StartupChkBox.UseVisualStyleBackColor = true;
            this.StartupChkBox.CheckedChanged += new System.EventHandler(this.StartupChkBox_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 202);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(141, 29);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 237);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(141, 29);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 272);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 29);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(653, 615);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Welcome to Caffeinated";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DefaultDurationBox;
        private System.Windows.Forms.CheckBox SettingsAtLaunchChkBox;
        private System.Windows.Forms.CheckBox ActivateChkBox;
        private System.Windows.Forms.CheckBox StartupChkBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}