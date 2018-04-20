namespace WindowsFormsApp2
{
    partial class newBuilding
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
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.BuildingText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(22, 22);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.BuildingLabel.TabIndex = 0;
            this.BuildingLabel.Text = "Building:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(201, 19);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(48, 20);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BuildingText
            // 
            this.BuildingText.Location = new System.Drawing.Point(75, 19);
            this.BuildingText.Name = "BuildingText";
            this.BuildingText.Size = new System.Drawing.Size(120, 20);
            this.BuildingText.TabIndex = 2;
            // 
            // newBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 59);
            this.Controls.Add(this.BuildingText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BuildingLabel);
            this.Name = "newBuilding";
            this.Text = "newBuilding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox BuildingText;
    }
}