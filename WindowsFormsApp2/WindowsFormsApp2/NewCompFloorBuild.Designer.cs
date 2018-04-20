namespace WindowsFormsApp2
{
    partial class NewCompFloorBuild
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
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.AddCompany = new System.Windows.Forms.Button();
            this.CompanyCombo = new System.Windows.Forms.ComboBox();
            this.BuildingCombo = new System.Windows.Forms.ComboBox();
            this.FloorCombo = new System.Windows.Forms.ComboBox();
            this.AddFloorButton = new System.Windows.Forms.Button();
            this.AddBuildingFloor = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
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
            this.FloorLabel.Location = new System.Drawing.Point(12, 45);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(33, 13);
            this.FloorLabel.TabIndex = 1;
            this.FloorLabel.Text = "Floor:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(12, 71);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.BuildingLabel.TabIndex = 2;
            this.BuildingLabel.Text = "Building:";
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
            this.CompanyCombo.Size = new System.Drawing.Size(164, 21);
            this.CompanyCombo.TabIndex = 8;
            this.CompanyCombo.SelectedIndexChanged += new System.EventHandler(this.CompanySelected);
            // 
            // BuildingCombo
            // 
            this.BuildingCombo.Enabled = false;
            this.BuildingCombo.FormattingEnabled = true;
            this.BuildingCombo.Location = new System.Drawing.Point(80, 68);
            this.BuildingCombo.Name = "BuildingCombo";
            this.BuildingCombo.Size = new System.Drawing.Size(164, 21);
            this.BuildingCombo.TabIndex = 9;
            // 
            // FloorCombo
            // 
            this.FloorCombo.Enabled = false;
            this.FloorCombo.FormattingEnabled = true;
            this.FloorCombo.Location = new System.Drawing.Point(80, 42);
            this.FloorCombo.Name = "FloorCombo";
            this.FloorCombo.Size = new System.Drawing.Size(164, 21);
            this.FloorCombo.TabIndex = 10;
            // 
            // AddFloorButton
            // 
            this.AddFloorButton.Location = new System.Drawing.Point(261, 40);
            this.AddFloorButton.Name = "AddFloorButton";
            this.AddFloorButton.Size = new System.Drawing.Size(62, 23);
            this.AddFloorButton.TabIndex = 11;
            this.AddFloorButton.Text = "Add";
            this.AddFloorButton.UseVisualStyleBackColor = true;
            this.AddFloorButton.Click += new System.EventHandler(this.AddFloorButton_Click);
            // 
            // AddBuildingFloor
            // 
            this.AddBuildingFloor.Location = new System.Drawing.Point(261, 66);
            this.AddBuildingFloor.Name = "AddBuildingFloor";
            this.AddBuildingFloor.Size = new System.Drawing.Size(62, 23);
            this.AddBuildingFloor.TabIndex = 12;
            this.AddBuildingFloor.Text = "Add";
            this.AddBuildingFloor.UseVisualStyleBackColor = true;
            this.AddBuildingFloor.Click += new System.EventHandler(this.AddBuildingFloor_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(183, 111);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(139, 31);
            this.HelpButton.TabIndex = 13;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // NewCompFloorBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 155);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.AddBuildingFloor);
            this.Controls.Add(this.AddFloorButton);
            this.Controls.Add(this.FloorCombo);
            this.Controls.Add(this.BuildingCombo);
            this.Controls.Add(this.CompanyCombo);
            this.Controls.Add(this.AddCompany);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.BuildingLabel);
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
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button AddCompany;
        private System.Windows.Forms.ComboBox CompanyCombo;
        private System.Windows.Forms.ComboBox BuildingCombo;
        private System.Windows.Forms.ComboBox FloorCombo;
        private System.Windows.Forms.Button AddFloorButton;
        private System.Windows.Forms.Button AddBuildingFloor;
        private new System.Windows.Forms.Button HelpButton;
    }
}