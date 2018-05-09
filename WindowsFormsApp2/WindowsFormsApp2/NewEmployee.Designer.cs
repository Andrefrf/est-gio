namespace WindowsFormsApp2
{
    partial class PersonForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.companyCombo = new System.Windows.Forms.ComboBox();
            this.OutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 24);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name: ";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(76, 21);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(172, 20);
            this.NameBox.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 89);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(119, 41);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Company: ";
            // 
            // companyCombo
            // 
            this.companyCombo.FormattingEnabled = true;
            this.companyCombo.Location = new System.Drawing.Point(75, 54);
            this.companyCombo.Name = "companyCombo";
            this.companyCombo.Size = new System.Drawing.Size(173, 21);
            this.companyCombo.TabIndex = 4;
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(143, 89);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(119, 41);
            this.OutButton.TabIndex = 5;
            this.OutButton.Text = "Cancel";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 142);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.companyCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "PersonForm";
            this.Text = "New Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companyCombo;
        private System.Windows.Forms.Button OutButton;
    }
}