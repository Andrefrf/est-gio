namespace WindowsFormsApp2
{
    partial class Form5
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
            this.CompLabel = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.TextBox();
            this.AddCompButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Location = new System.Drawing.Point(17, 22);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(85, 13);
            this.CompLabel.TabIndex = 0;
            this.CompLabel.Text = "Company Name:";
            // 
            // CompanyBox
            // 
            this.CompanyBox.Location = new System.Drawing.Point(108, 19);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(137, 20);
            this.CompanyBox.TabIndex = 1;
            // 
            // AddCompButton
            // 
            this.AddCompButton.FlatAppearance.BorderSize = 0;
            this.AddCompButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCompButton.Location = new System.Drawing.Point(268, 17);
            this.AddCompButton.Name = "AddCompButton";
            this.AddCompButton.Size = new System.Drawing.Size(54, 23);
            this.AddCompButton.TabIndex = 2;
            this.AddCompButton.Text = "Add";
            this.AddCompButton.UseVisualStyleBackColor = true;
            this.AddCompButton.Click += new System.EventHandler(this.AddCompButton_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 49);
            this.Controls.Add(this.AddCompButton);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.CompLabel);
            this.Name = "Form5";
            this.Text = "New Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompLabel;
        private System.Windows.Forms.TextBox CompanyBox;
        private System.Windows.Forms.Button AddCompButton;
    }
}