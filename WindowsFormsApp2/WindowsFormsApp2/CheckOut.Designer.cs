namespace WindowsFormsApp2
{
    partial class CheckOut
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
            this.components = new System.ComponentModel.Container();
            this.toCheckOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApp2.DatabaseDataSet();
            this.toCheckOutTableAdapter = new WindowsFormsApp2.DatabaseDataSetTableAdapters.toCheckOutTableAdapter();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.outGrid = new System.Windows.Forms.DataGridView();
            this.goodCheckOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnCombo = new System.Windows.Forms.ComboBox();
            this.FilterValue = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toCheckOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toCheckOutBindingSource
            // 
            this.toCheckOutBindingSource.DataMember = "toCheckOut";
            this.toCheckOutBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toCheckOutTableAdapter
            // 
            this.toCheckOutTableAdapter.ClearBeforeFill = true;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(88, 325);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(152, 51);
            this.CheckOutButton.TabIndex = 1;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(385, 325);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(152, 51);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // outGrid
            // 
            this.outGrid.AllowUserToAddRows = false;
            this.outGrid.AllowUserToDeleteRows = false;
            this.outGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outGrid.Location = new System.Drawing.Point(26, 72);
            this.outGrid.Name = "outGrid";
            this.outGrid.ReadOnly = true;
            this.outGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.outGrid.Size = new System.Drawing.Size(646, 184);
            this.outGrid.TabIndex = 0;
            this.outGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // goodCheckOut
            // 
            this.goodCheckOut.AutoSize = true;
            this.goodCheckOut.BackColor = System.Drawing.SystemColors.Control;
            this.goodCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goodCheckOut.ForeColor = System.Drawing.Color.Lime;
            this.goodCheckOut.Location = new System.Drawing.Point(279, 280);
            this.goodCheckOut.Name = "goodCheckOut";
            this.goodCheckOut.Size = new System.Drawing.Size(123, 13);
            this.goodCheckOut.TabIndex = 3;
            this.goodCheckOut.Text = "Visitor checked Out!";
            this.goodCheckOut.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Column:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value:";
            // 
            // columnCombo
            // 
            this.columnCombo.FormattingEnabled = true;
            this.columnCombo.Location = new System.Drawing.Point(74, 33);
            this.columnCombo.Name = "columnCombo";
            this.columnCombo.Size = new System.Drawing.Size(110, 21);
            this.columnCombo.TabIndex = 6;
            this.columnCombo.SelectedIndexChanged += new System.EventHandler(this.columnCombo_SelectedIndexChanged);
            // 
            // FilterValue
            // 
            this.FilterValue.Location = new System.Drawing.Point(264, 33);
            this.FilterValue.Name = "FilterValue";
            this.FilterValue.Size = new System.Drawing.Size(100, 20);
            this.FilterValue.TabIndex = 7;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(394, 32);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(81, 21);
            this.Filter.TabIndex = 8;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(490, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Visitors: ";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.SystemColors.Control;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumberLabel.Location = new System.Drawing.Point(614, 36);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(0, 13);
            this.NumberLabel.TabIndex = 11;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 392);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FilterValue);
            this.Controls.Add(this.columnCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goodCheckOut);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.outGrid);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toCheckOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource toCheckOutBindingSource;
        private DatabaseDataSetTableAdapters.toCheckOutTableAdapter toCheckOutTableAdapter;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView outGrid;
        private System.Windows.Forms.Label goodCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox columnCombo;
        private System.Windows.Forms.TextBox FilterValue;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberLabel;
    }
}