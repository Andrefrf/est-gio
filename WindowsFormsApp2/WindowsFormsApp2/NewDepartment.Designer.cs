namespace WindowsFormsApp2
{
    partial class NewDepartment
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
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.FloorLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.AddCompany = new System.Windows.Forms.Button();
            this.CompanyCombo = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(12, 18);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(54, 13);
            this.CompanyLabel.TabIndex = 0;
            this.CompanyLabel.Text = "Company:";
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.Location = new System.Drawing.Point(12, 62);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(65, 13);
            this.FloorLabel.TabIndex = 1;
            this.FloorLabel.Text = "Department:";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(15, 109);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(140, 34);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.AddBurron_Click);
            // 
            // AddCompany
            // 
            this.AddCompany.Location = new System.Drawing.Point(261, 13);
            this.AddCompany.Name = "AddCompany";
            this.AddCompany.Size = new System.Drawing.Size(62, 23);
            this.AddCompany.TabIndex = 7;
            this.AddCompany.Text = "Add";
            this.AddCompany.UseVisualStyleBackColor = true;
            this.AddCompany.Click += new System.EventHandler(this.AddCompany_Click);
            // 
            // CompanyCombo
            // 
            this.CompanyCombo.FormattingEnabled = true;
            this.CompanyCombo.Location = new System.Drawing.Point(80, 14);
            this.CompanyCombo.Name = "CompanyCombo";
            this.CompanyCombo.Size = new System.Drawing.Size(163, 21);
            this.CompanyCombo.TabIndex = 8;
            this.CompanyCombo.SelectedIndexChanged += new System.EventHandler(this.CompanySelected);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(183, 111);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(139, 31);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Enabled = false;
            this.DepartmentBox.Location = new System.Drawing.Point(80, 59);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(236, 20);
            this.DepartmentBox.TabIndex = 14;
            // 
            // NewCompFloorBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 155);
            this.Controls.Add(this.DepartmentBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CompanyCombo);
            this.Controls.Add(this.AddCompany);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.FloorLabel);
            this.Controls.Add(this.CompanyLabel);
            this.Name = "NewCompFloorBuild";
            this.Text = "New Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label FloorLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button AddCompany;
        private System.Windows.Forms.ComboBox CompanyCombo;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox DepartmentBox;
    }
}