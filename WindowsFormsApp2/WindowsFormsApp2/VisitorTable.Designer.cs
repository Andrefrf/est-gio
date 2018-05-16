namespace WindowsFormsApp2
{
    partial class VisitorTable
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
            this.outGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // outGrid
            // 
            this.outGrid.AllowUserToAddRows = false;
            this.outGrid.AllowUserToDeleteRows = false;
            this.outGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outGrid.Location = new System.Drawing.Point(36, 30);
            this.outGrid.Name = "outGrid";
            this.outGrid.ReadOnly = true;
            this.outGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outGrid.Size = new System.Drawing.Size(646, 184);
            this.outGrid.TabIndex = 1;
            // 
            // VisitorTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.outGrid);
            this.Name = "VisitorTable";
            this.Text = "VisitorTable";
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView outGrid;
    }
}