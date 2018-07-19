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
            this.RemoveUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.xmlPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.watermarkBox = new System.Windows.Forms.TextBox();
            this.WatermarkLabel = new System.Windows.Forms.Label();
            this.nationCheck = new System.Windows.Forms.CheckBox();
            this.genderCheck = new System.Windows.Forms.CheckBox();
            this.expireCheck = new System.Windows.Forms.CheckBox();
            this.addressCheck = new System.Windows.Forms.CheckBox();
            this.commentsCheck = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acquisition Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image File/Folder";
            // 
            // DeviceCombo
            // 
            this.DeviceCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.DeviceCombo.Location = new System.Drawing.Point(122, 32);
            this.DeviceCombo.Name = "DeviceCombo";
            this.DeviceCombo.Size = new System.Drawing.Size(223, 21);
            this.DeviceCombo.TabIndex = 4;
            // 
            // DeviceNameBox
            // 
            this.DeviceNameBox.Location = new System.Drawing.Point(122, 64);
            this.DeviceNameBox.Name = "DeviceNameBox";
            this.DeviceNameBox.Size = new System.Drawing.Size(223, 20);
            this.DeviceNameBox.TabIndex = 5;
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(122, 96);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(223, 20);
            this.FolderTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Document";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Photo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Resolution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Enhancement";
            // 
            // DocRes
            // 
            this.DocRes.Location = new System.Drawing.Point(122, 51);
            this.DocRes.Name = "DocRes";
            this.DocRes.Size = new System.Drawing.Size(54, 20);
            this.DocRes.TabIndex = 12;
            this.DocRes.Text = "200";
            // 
            // PhotoRes
            // 
            this.PhotoRes.Location = new System.Drawing.Point(122, 83);
            this.PhotoRes.Name = "PhotoRes";
            this.PhotoRes.Size = new System.Drawing.Size(54, 20);
            this.PhotoRes.TabIndex = 13;
            this.PhotoRes.Text = "200";
            // 
            // DocEnhancement
            // 
            this.DocEnhancement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocEnhancement.FormattingEnabled = true;
            this.DocEnhancement.Items.AddRange(new object[] {
            "None",
            "Apply"});
            this.DocEnhancement.Location = new System.Drawing.Point(275, 51);
            this.DocEnhancement.Name = "DocEnhancement";
            this.DocEnhancement.Size = new System.Drawing.Size(70, 21);
            this.DocEnhancement.TabIndex = 14;
            // 
            // DocColor
            // 
            this.DocColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocColor.FormattingEnabled = true;
            this.DocColor.Items.AddRange(new object[] {
            "Color",
            "Grayscale"});
            this.DocColor.Location = new System.Drawing.Point(200, 50);
            this.DocColor.Name = "DocColor";
            this.DocColor.Size = new System.Drawing.Size(54, 21);
            this.DocColor.TabIndex = 15;
            // 
            // PhotoColor
            // 
            this.PhotoColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PhotoColor.FormattingEnabled = true;
            this.PhotoColor.Items.AddRange(new object[] {
            "Color",
            "Grayscale"});
            this.PhotoColor.Location = new System.Drawing.Point(200, 83);
            this.PhotoColor.Name = "PhotoColor";
            this.PhotoColor.Size = new System.Drawing.Size(54, 21);
            this.PhotoColor.TabIndex = 16;
            // 
            // PhotoEnhancement
            // 
            this.PhotoEnhancement.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PhotoEnhancement.FormattingEnabled = true;
            this.PhotoEnhancement.Items.AddRange(new object[] {
            "None",
            "Apply"});
            this.PhotoEnhancement.Location = new System.Drawing.Point(275, 83);
            this.PhotoEnhancement.Name = "PhotoEnhancement";
            this.PhotoEnhancement.Size = new System.Drawing.Size(70, 21);
            this.PhotoEnhancement.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(227, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpperCaseCheck
            // 
            this.UpperCaseCheck.AutoSize = true;
            this.UpperCaseCheck.Checked = true;
            this.UpperCaseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCaseCheck.Location = new System.Drawing.Point(19, 81);
            this.UpperCaseCheck.Name = "UpperCaseCheck";
            this.UpperCaseCheck.Size = new System.Drawing.Size(189, 17);
            this.UpperCaseCheck.TabIndex = 20;
            this.UpperCaseCheck.Text = "Convert output string to uppercase";
            this.UpperCaseCheck.UseVisualStyleBackColor = true;
            // 
            // DocIntegrationCheck
            // 
            this.DocIntegrationCheck.AutoSize = true;
            this.DocIntegrationCheck.Location = new System.Drawing.Point(241, 49);
            this.DocIntegrationCheck.Name = "DocIntegrationCheck";
            this.DocIntegrationCheck.Size = new System.Drawing.Size(128, 17);
            this.DocIntegrationCheck.TabIndex = 21;
            this.DocIntegrationCheck.Text = "Document Integration";
            this.DocIntegrationCheck.UseVisualStyleBackColor = true;
            // 
            // TiltingComboBox
            // 
            this.TiltingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TiltingComboBox.FormattingEnabled = true;
            this.TiltingComboBox.Items.AddRange(new object[] {
            "Horizontal Tilting",
            "Vertical Tilting",
            "No Image Tilting"});
            this.TiltingComboBox.Location = new System.Drawing.Point(19, 108);
            this.TiltingComboBox.Name = "TiltingComboBox";
            this.TiltingComboBox.Size = new System.Drawing.Size(129, 21);
            this.TiltingComboBox.TabIndex = 22;
            // 
            // accentOutputCheck
            // 
            this.accentOutputCheck.AutoSize = true;
            this.accentOutputCheck.Checked = true;
            this.accentOutputCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.accentOutputCheck.Location = new System.Drawing.Point(19, 49);
            this.accentOutputCheck.Name = "accentOutputCheck";
            this.accentOutputCheck.Size = new System.Drawing.Size(191, 17);
            this.accentOutputCheck.TabIndex = 23;
            this.accentOutputCheck.Text = "Remove accents from output string";
            this.accentOutputCheck.UseVisualStyleBackColor = true;
            // 
            // deleteDocAfterProcess
            // 
            this.deleteDocAfterProcess.AutoSize = true;
            this.deleteDocAfterProcess.Location = new System.Drawing.Point(241, 81);
            this.deleteDocAfterProcess.Name = "deleteDocAfterProcess";
            this.deleteDocAfterProcess.Size = new System.Drawing.Size(183, 17);
            this.deleteDocAfterProcess.TabIndex = 24;
            this.deleteDocAfterProcess.Text = "Delete Image file after processing";
            this.deleteDocAfterProcess.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Process Mode";
            // 
            // ProcessModeCombo
            // 
            this.ProcessModeCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ProcessModeCombo.FormattingEnabled = true;
            this.ProcessModeCombo.Items.AddRange(new object[] {
            "Document Reading",
            "Digital Copy"});
            this.ProcessModeCombo.Location = new System.Drawing.Point(102, 15);
            this.ProcessModeCombo.Name = "ProcessModeCombo";
            this.ProcessModeCombo.Size = new System.Drawing.Size(322, 21);
            this.ProcessModeCombo.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Digital Copy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Width:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(269, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Height:";
            // 
            // digiCopyHeight
            // 
            this.digiCopyHeight.Location = new System.Drawing.Point(316, 108);
            this.digiCopyHeight.Name = "digiCopyHeight";
            this.digiCopyHeight.Size = new System.Drawing.Size(32, 20);
            this.digiCopyHeight.TabIndex = 30;
            this.digiCopyHeight.Text = "86";
            // 
            // digiCopyWidth
            // 
            this.digiCopyWidth.Location = new System.Drawing.Point(408, 108);
            this.digiCopyWidth.Name = "digiCopyWidth";
            this.digiCopyWidth.Size = new System.Drawing.Size(32, 20);
            this.digiCopyWidth.TabIndex = 31;
            this.digiCopyWidth.Text = "55";
            // 
            // SavePhotoCheck
            // 
            this.SavePhotoCheck.AutoSize = true;
            this.SavePhotoCheck.Location = new System.Drawing.Point(15, 179);
            this.SavePhotoCheck.Name = "SavePhotoCheck";
            this.SavePhotoCheck.Size = new System.Drawing.Size(114, 17);
            this.SavePhotoCheck.TabIndex = 32;
            this.SavePhotoCheck.Text = "Save Photo Image";
            this.SavePhotoCheck.UseVisualStyleBackColor = true;
            // 
            // SavePhotoBox
            // 
            this.SavePhotoBox.Location = new System.Drawing.Point(144, 177);
            this.SavePhotoBox.Name = "SavePhotoBox";
            this.SavePhotoBox.Size = new System.Drawing.Size(265, 20);
            this.SavePhotoBox.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Date format type:";
            // 
            // DateFormatCombo
            // 
            this.DateFormatCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
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
            this.DateFormatCombo.Location = new System.Drawing.Point(144, 144);
            this.DateFormatCombo.Name = "DateFormatCombo";
            this.DateFormatCombo.Size = new System.Drawing.Size(265, 21);
            this.DateFormatCombo.TabIndex = 35;
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveUserButton.FlatAppearance.BorderSize = 0;
            this.RemoveUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveUserButton.Location = new System.Drawing.Point(636, 390);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(154, 44);
            this.RemoveUserButton.TabIndex = 37;
            this.RemoveUserButton.Text = "Remove User";
            this.RemoveUserButton.UseVisualStyleBackColor = false;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddUserButton.FlatAppearance.BorderSize = 0;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Location = new System.Drawing.Point(421, 390);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(154, 44);
            this.AddUserButton.TabIndex = 36;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(158, 338);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(45, 20);
            this.daysBox.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 341);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Number of days for reset:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(367, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Export XML";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // xmlPath
            // 
            this.xmlPath.Location = new System.Drawing.Point(123, 13);
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.Size = new System.Drawing.Size(159, 20);
            this.xmlPath.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "XML export path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(286, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // watermarkBox
            // 
            this.watermarkBox.Location = new System.Drawing.Point(122, 123);
            this.watermarkBox.Name = "watermarkBox";
            this.watermarkBox.Size = new System.Drawing.Size(223, 20);
            this.watermarkBox.TabIndex = 45;
            // 
            // WatermarkLabel
            // 
            this.WatermarkLabel.AutoSize = true;
            this.WatermarkLabel.Location = new System.Drawing.Point(15, 126);
            this.WatermarkLabel.Name = "WatermarkLabel";
            this.WatermarkLabel.Size = new System.Drawing.Size(83, 13);
            this.WatermarkLabel.TabIndex = 46;
            this.WatermarkLabel.Text = "Watermark Text";
            // 
            // nationCheck
            // 
            this.nationCheck.AutoSize = true;
            this.nationCheck.Checked = true;
            this.nationCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nationCheck.Location = new System.Drawing.Point(29, 41);
            this.nationCheck.Name = "nationCheck";
            this.nationCheck.Size = new System.Drawing.Size(75, 17);
            this.nationCheck.TabIndex = 47;
            this.nationCheck.Text = "Nationality";
            this.nationCheck.UseVisualStyleBackColor = true;
            // 
            // genderCheck
            // 
            this.genderCheck.AutoSize = true;
            this.genderCheck.Checked = true;
            this.genderCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.genderCheck.Location = new System.Drawing.Point(90, 64);
            this.genderCheck.Name = "genderCheck";
            this.genderCheck.Size = new System.Drawing.Size(61, 17);
            this.genderCheck.TabIndex = 48;
            this.genderCheck.Text = "Gender";
            this.genderCheck.UseVisualStyleBackColor = true;
            // 
            // expireCheck
            // 
            this.expireCheck.AutoSize = true;
            this.expireCheck.Checked = true;
            this.expireCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.expireCheck.Location = new System.Drawing.Point(141, 41);
            this.expireCheck.Name = "expireCheck";
            this.expireCheck.Size = new System.Drawing.Size(98, 17);
            this.expireCheck.TabIndex = 49;
            this.expireCheck.Text = "Expiration Date";
            this.expireCheck.UseVisualStyleBackColor = true;
            // 
            // addressCheck
            // 
            this.addressCheck.AutoSize = true;
            this.addressCheck.Checked = true;
            this.addressCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addressCheck.Location = new System.Drawing.Point(267, 41);
            this.addressCheck.Name = "addressCheck";
            this.addressCheck.Size = new System.Drawing.Size(64, 17);
            this.addressCheck.TabIndex = 50;
            this.addressCheck.Text = "Address";
            this.addressCheck.UseVisualStyleBackColor = true;
            // 
            // commentsCheck
            // 
            this.commentsCheck.AutoSize = true;
            this.commentsCheck.Checked = true;
            this.commentsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.commentsCheck.Location = new System.Drawing.Point(224, 64);
            this.commentsCheck.Name = "commentsCheck";
            this.commentsCheck.Size = new System.Drawing.Size(75, 17);
            this.commentsCheck.TabIndex = 51;
            this.commentsCheck.Text = "Comments";
            this.commentsCheck.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Available fields:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DeviceCombo);
            this.groupBox1.Controls.Add(this.DeviceNameBox);
            this.groupBox1.Controls.Add(this.FolderTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 129);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.DocRes);
            this.groupBox2.Controls.Add(this.PhotoRes);
            this.groupBox2.Controls.Add(this.DocEnhancement);
            this.groupBox2.Controls.Add(this.DocColor);
            this.groupBox2.Controls.Add(this.PhotoColor);
            this.groupBox2.Controls.Add(this.WatermarkLabel);
            this.groupBox2.Controls.Add(this.PhotoEnhancement);
            this.groupBox2.Controls.Add(this.watermarkBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 164);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Document Scan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.UpperCaseCheck);
            this.groupBox3.Controls.Add(this.DocIntegrationCheck);
            this.groupBox3.Controls.Add(this.TiltingComboBox);
            this.groupBox3.Controls.Add(this.accentOutputCheck);
            this.groupBox3.Controls.Add(this.deleteDocAfterProcess);
            this.groupBox3.Controls.Add(this.ProcessModeCombo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.digiCopyHeight);
            this.groupBox3.Controls.Add(this.digiCopyWidth);
            this.groupBox3.Controls.Add(this.SavePhotoCheck);
            this.groupBox3.Controls.Add(this.SavePhotoBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.DateFormatCombo);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(373, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 211);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processing";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.nationCheck);
            this.groupBox4.Controls.Add(this.genderCheck);
            this.groupBox4.Controls.Add(this.expireCheck);
            this.groupBox4.Controls.Add(this.addressCheck);
            this.groupBox4.Controls.Add(this.commentsCheck);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(373, 229);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 106);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fields";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.xmlPath);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Location = new System.Drawing.Point(373, 341);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 43);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Export";
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 446);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.RemoveUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Configurations";
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Button RemoveUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox xmlPath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox watermarkBox;
        private System.Windows.Forms.Label WatermarkLabel;
        private System.Windows.Forms.CheckBox nationCheck;
        private System.Windows.Forms.CheckBox genderCheck;
        private System.Windows.Forms.CheckBox expireCheck;
        private System.Windows.Forms.CheckBox addressCheck;
        private System.Windows.Forms.CheckBox commentsCheck;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}