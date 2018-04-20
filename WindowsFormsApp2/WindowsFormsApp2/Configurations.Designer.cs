namespace WindowsFormsApp2
{
    partial class Configurations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeviceCombo = new System.Windows.Forms.ComboBox();
            this.DeviceNameBox = new System.Windows.Forms.TextBox();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DocRes = new System.Windows.Forms.TextBox();
            this.PhotoRes = new System.Windows.Forms.TextBox();
            this.DocEnhancement = new System.Windows.Forms.ComboBox();
            this.DocColor = new System.Windows.Forms.ComboBox();
            this.PhotoColor = new System.Windows.Forms.ComboBox();
            this.PhotoEnhancement = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UpperCaseCheck = new System.Windows.Forms.CheckBox();
            this.DocIntegrationCheck = new System.Windows.Forms.CheckBox();
            this.TiltingComboBox = new System.Windows.Forms.ComboBox();
            this.accentOutputCheck = new System.Windows.Forms.CheckBox();
            this.deleteDocAfterProcess = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ProcessModeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.digiCopyHeight = new System.Windows.Forms.TextBox();
            this.digiCopyWidth = new System.Windows.Forms.TextBox();
            this.SavePhotoCheck = new System.Windows.Forms.CheckBox();
            this.SavePhotoBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DateFormatCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acquisition Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image File/Folder";
            // 
            // DeviceCombo
            // 
            this.DeviceCombo.FormattingEnabled = true;
            this.DeviceCombo.Items.AddRange(new object[] {
            "IcarBox 250",
            "IcarBox 250 VIU",
            "IcarBox 260",
            "IcarBox 260 VIU",
            "IcarBox 240B",
            "IDBox",
            "IDBox VIU",
            "IDBoxE",
            "IDBoxE VIU",
            "TWAIN compatible scanner",
            "Virtual folder device",
            "Image file",
            "HP Photo Scan 1200",
            "Bancor K25 - IBM driver"});
            this.DeviceCombo.Location = new System.Drawing.Point(119, 28);
            this.DeviceCombo.Name = "DeviceCombo";
            this.DeviceCombo.Size = new System.Drawing.Size(223, 21);
            this.DeviceCombo.TabIndex = 4;
            // 
            // DeviceNameBox
            // 
            this.DeviceNameBox.Location = new System.Drawing.Point(119, 60);
            this.DeviceNameBox.Name = "DeviceNameBox";
            this.DeviceNameBox.Size = new System.Drawing.Size(223, 20);
            this.DeviceNameBox.TabIndex = 5;
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(119, 92);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(223, 20);
            this.FolderTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Document";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Resolution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Enhancement";
            // 
            // DocRes
            // 
            this.DocRes.Location = new System.Drawing.Point(119, 203);
            this.DocRes.Name = "DocRes";
            this.DocRes.Size = new System.Drawing.Size(54, 20);
            this.DocRes.TabIndex = 12;
            this.DocRes.Text = "200";
            // 
            // PhotoRes
            // 
            this.PhotoRes.Location = new System.Drawing.Point(119, 235);
            this.PhotoRes.Name = "PhotoRes";
            this.PhotoRes.Size = new System.Drawing.Size(54, 20);
            this.PhotoRes.TabIndex = 13;
            this.PhotoRes.Text = "200";
            // 
            // DocEnhancement
            // 
            this.DocEnhancement.FormattingEnabled = true;
            this.DocEnhancement.Items.AddRange(new object[] {
            "None",
            "Apply"});
            this.DocEnhancement.Location = new System.Drawing.Point(272, 203);
            this.DocEnhancement.Name = "DocEnhancement";
            this.DocEnhancement.Size = new System.Drawing.Size(70, 21);
            this.DocEnhancement.TabIndex = 14;
            // 
            // DocColor
            // 
            this.DocColor.FormattingEnabled = true;
            this.DocColor.Items.AddRange(new object[] {
            "Color",
            "Grayscale"});
            this.DocColor.Location = new System.Drawing.Point(197, 202);
            this.DocColor.Name = "DocColor";
            this.DocColor.Size = new System.Drawing.Size(54, 21);
            this.DocColor.TabIndex = 15;
            // 
            // PhotoColor
            // 
            this.PhotoColor.FormattingEnabled = true;
            this.PhotoColor.Items.AddRange(new object[] {
            "Color",
            "Grayscale"});
            this.PhotoColor.Location = new System.Drawing.Point(197, 235);
            this.PhotoColor.Name = "PhotoColor";
            this.PhotoColor.Size = new System.Drawing.Size(54, 21);
            this.PhotoColor.TabIndex = 16;
            // 
            // PhotoEnhancement
            // 
            this.PhotoEnhancement.FormattingEnabled = true;
            this.PhotoEnhancement.Items.AddRange(new object[] {
            "None",
            "Apply"});
            this.PhotoEnhancement.Location = new System.Drawing.Point(272, 235);
            this.PhotoEnhancement.Name = "PhotoEnhancement";
            this.PhotoEnhancement.Size = new System.Drawing.Size(70, 21);
            this.PhotoEnhancement.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpperCaseCheck
            // 
            this.UpperCaseCheck.AutoSize = true;
            this.UpperCaseCheck.Checked = true;
            this.UpperCaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCaseCheck.Location = new System.Drawing.Point(388, 94);
            this.UpperCaseCheck.Name = "UpperCaseCheck";
            this.UpperCaseCheck.Size = new System.Drawing.Size(189, 17);
            this.UpperCaseCheck.TabIndex = 20;
            this.UpperCaseCheck.Text = "Convert output string to uppercase";
            this.UpperCaseCheck.UseVisualStyleBackColor = true;
            // 
            // DocIntegrationCheck
            // 
            this.DocIntegrationCheck.AutoSize = true;
            this.DocIntegrationCheck.Location = new System.Drawing.Point(610, 62);
            this.DocIntegrationCheck.Name = "DocIntegrationCheck";
            this.DocIntegrationCheck.Size = new System.Drawing.Size(128, 17);
            this.DocIntegrationCheck.TabIndex = 21;
            this.DocIntegrationCheck.Text = "Document Integration";
            this.DocIntegrationCheck.UseVisualStyleBackColor = true;
            // 
            // TiltingComboBox
            // 
            this.TiltingComboBox.FormattingEnabled = true;
            this.TiltingComboBox.Items.AddRange(new object[] {
            "Horizontal Tilting",
            "Vertical Tilting",
            "No Image Tilting"});
            this.TiltingComboBox.Location = new System.Drawing.Point(388, 117);
            this.TiltingComboBox.Name = "TiltingComboBox";
            this.TiltingComboBox.Size = new System.Drawing.Size(129, 21);
            this.TiltingComboBox.TabIndex = 22;
            // 
            // accentOutputCheck
            // 
            this.accentOutputCheck.AutoSize = true;
            this.accentOutputCheck.Checked = true;
            this.accentOutputCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.accentOutputCheck.Location = new System.Drawing.Point(388, 62);
            this.accentOutputCheck.Name = "accentOutputCheck";
            this.accentOutputCheck.Size = new System.Drawing.Size(191, 17);
            this.accentOutputCheck.TabIndex = 23;
            this.accentOutputCheck.Text = "Remove accents from output string";
            this.accentOutputCheck.UseVisualStyleBackColor = true;
            // 
            // deleteDocAfterProcess
            // 
            this.deleteDocAfterProcess.AutoSize = true;
            this.deleteDocAfterProcess.Location = new System.Drawing.Point(610, 94);
            this.deleteDocAfterProcess.Name = "deleteDocAfterProcess";
            this.deleteDocAfterProcess.Size = new System.Drawing.Size(183, 17);
            this.deleteDocAfterProcess.TabIndex = 24;
            this.deleteDocAfterProcess.Text = "Delete Image file after processing";
            this.deleteDocAfterProcess.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Process Mode";
            // 
            // ProcessModeCombo
            // 
            this.ProcessModeCombo.FormattingEnabled = true;
            this.ProcessModeCombo.Items.AddRange(new object[] {
            "Document Reading",
            "Digital Copy"});
            this.ProcessModeCombo.Location = new System.Drawing.Point(471, 28);
            this.ProcessModeCombo.Name = "ProcessModeCombo";
            this.ProcessModeCombo.Size = new System.Drawing.Size(322, 21);
            this.ProcessModeCombo.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(649, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Digital Copy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(702, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Width:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(607, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Height:";
            // 
            // digiCopyHeight
            // 
            this.digiCopyHeight.Location = new System.Drawing.Point(654, 147);
            this.digiCopyHeight.Name = "digiCopyHeight";
            this.digiCopyHeight.Size = new System.Drawing.Size(32, 20);
            this.digiCopyHeight.TabIndex = 30;
            this.digiCopyHeight.Text = "86";
            // 
            // digiCopyWidth
            // 
            this.digiCopyWidth.Location = new System.Drawing.Point(746, 147);
            this.digiCopyWidth.Name = "digiCopyWidth";
            this.digiCopyWidth.Size = new System.Drawing.Size(32, 20);
            this.digiCopyWidth.TabIndex = 31;
            this.digiCopyWidth.Text = "55";
            // 
            // SavePhotoCheck
            // 
            this.SavePhotoCheck.AutoSize = true;
            this.SavePhotoCheck.Location = new System.Drawing.Point(377, 179);
            this.SavePhotoCheck.Name = "SavePhotoCheck";
            this.SavePhotoCheck.Size = new System.Drawing.Size(114, 17);
            this.SavePhotoCheck.TabIndex = 32;
            this.SavePhotoCheck.Text = "Save Photo Image";
            this.SavePhotoCheck.UseVisualStyleBackColor = true;
            // 
            // SavePhotoBox
            // 
            this.SavePhotoBox.Location = new System.Drawing.Point(445, 202);
            this.SavePhotoBox.Name = "SavePhotoBox";
            this.SavePhotoBox.Size = new System.Drawing.Size(322, 20);
            this.SavePhotoBox.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(374, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Date format type:";
            // 
            // DateFormatCombo
            // 
            this.DateFormatCombo.FormattingEnabled = true;
            this.DateFormatCombo.Items.AddRange(new object[] {
            "DD-MM-YY",
            "DD-MM-YYYY",
            "DD-MM-YY??",
            "MM-DD-YY",
            "MM-DD-YYYY",
            "MM-DD-YY??",
            "YY-MM-DD",
            "YYYY-MM-DD",
            "YY??-MM-DD",
            "MM-DD",
            "MM-YY",
            "MM-YYYY",
            "MM-YY??"});
            this.DateFormatCombo.Location = new System.Drawing.Point(502, 235);
            this.DateFormatCombo.Name = "DateFormatCombo";
            this.DateFormatCombo.Size = new System.Drawing.Size(265, 21);
            this.DateFormatCombo.TabIndex = 35;
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 346);
            this.Controls.Add(this.DateFormatCombo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SavePhotoBox);
            this.Controls.Add(this.SavePhotoCheck);
            this.Controls.Add(this.digiCopyWidth);
            this.Controls.Add(this.digiCopyHeight);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ProcessModeCombo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteDocAfterProcess);
            this.Controls.Add(this.accentOutputCheck);
            this.Controls.Add(this.TiltingComboBox);
            this.Controls.Add(this.DocIntegrationCheck);
            this.Controls.Add(this.UpperCaseCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhotoEnhancement);
            this.Controls.Add(this.PhotoColor);
            this.Controls.Add(this.DocColor);
            this.Controls.Add(this.DocEnhancement);
            this.Controls.Add(this.PhotoRes);
            this.Controls.Add(this.DocRes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.DeviceNameBox);
            this.Controls.Add(this.DeviceCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Configurations";
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DeviceCombo;
        private System.Windows.Forms.TextBox DeviceNameBox;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DocRes;
        private System.Windows.Forms.TextBox PhotoRes;
        private System.Windows.Forms.ComboBox DocEnhancement;
        private System.Windows.Forms.ComboBox DocColor;
        private System.Windows.Forms.ComboBox PhotoColor;
        private System.Windows.Forms.ComboBox PhotoEnhancement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox UpperCaseCheck;
        private System.Windows.Forms.CheckBox DocIntegrationCheck;
        private System.Windows.Forms.ComboBox TiltingComboBox;
        private System.Windows.Forms.CheckBox accentOutputCheck;
        private System.Windows.Forms.CheckBox deleteDocAfterProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ProcessModeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox digiCopyHeight;
        private System.Windows.Forms.TextBox digiCopyWidth;
        private System.Windows.Forms.CheckBox SavePhotoCheck;
        private System.Windows.Forms.TextBox SavePhotoBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox DateFormatCombo;
    }
}