namespace WindowsFormsApp2
{
    partial class newFloor
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
            this.FloorLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.FloorBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FloorLabel
            // 
            this.FloorLabel.AutoSize = true;
            this.FloorLabel.Location = new System.Drawing.Point(12, 18);
            this.FloorLabel.Name = "FloorLabel";
            this.FloorLabel.Size = new System.Drawing.Size(33, 13);
            this.FloorLabel.TabIndex = 0;
            this.FloorLabel.Text = "Floor:";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(186, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(38, 19);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FloorBox
            // 
            this.FloorBox.Location = new System.Drawing.Point(51, 15);
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.Size = new System.Drawing.Size(110, 20);
            this.FloorBox.TabIndex = 2;
            // 
            // newFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 52);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.FloorLabel);
            this.Name = "newFloor";
            this.Text = "newFloor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FloorLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FloorBox;
    }
}