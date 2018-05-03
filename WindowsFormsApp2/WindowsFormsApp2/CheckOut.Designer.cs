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
            this.databasecheckout = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toCheckOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new WindowsFormsApp2.DatabaseDataSet2();
            this.databaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApp2.DatabaseDataSet1();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.toCheckOutTableAdapter = new WindowsFormsApp2.DatabaseDataSet2TableAdapters.toCheckOutTableAdapter();
            this.OutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databasecheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCheckOutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // databasecheckout
            // 
            this.databasecheckout.AutoGenerateColumns = false;
            this.databasecheckout.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.databasecheckout.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.databasecheckout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.documentDataGridViewTextBoxColumn,
            this.entranceDataGridViewTextBoxColumn,
            this.cardDataGridViewTextBoxColumn});
            this.databasecheckout.Cursor = System.Windows.Forms.Cursors.Default;
            this.databasecheckout.DataSource = this.toCheckOutBindingSource;
            this.databasecheckout.Location = new System.Drawing.Point(26, 12);
            this.databasecheckout.Name = "databasecheckout";
            this.databasecheckout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.databasecheckout.Size = new System.Drawing.Size(650, 261);
            this.databasecheckout.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "Document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "Document";
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            // 
            // entranceDataGridViewTextBoxColumn
            // 
            this.entranceDataGridViewTextBoxColumn.DataPropertyName = "Entrance";
            this.entranceDataGridViewTextBoxColumn.HeaderText = "Entrance";
            this.entranceDataGridViewTextBoxColumn.Name = "entranceDataGridViewTextBoxColumn";
            // 
            // cardDataGridViewTextBoxColumn
            // 
            this.cardDataGridViewTextBoxColumn.DataPropertyName = "Card";
            this.cardDataGridViewTextBoxColumn.HeaderText = "Card";
            this.cardDataGridViewTextBoxColumn.Name = "cardDataGridViewTextBoxColumn";
            // 
            // toCheckOutBindingSource
            // 
            this.toCheckOutBindingSource.DataMember = "toCheckOut";
            this.toCheckOutBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSet1BindingSource
            // 
            this.databaseDataSet1BindingSource.DataSource = this.databaseDataSet1;
            this.databaseDataSet1BindingSource.Position = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(395, 279);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(209, 40);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Back";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // toCheckOutTableAdapter
            // 
            this.toCheckOutTableAdapter.ClearBeforeFill = true;
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(93, 279);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(216, 39);
            this.OutButton.TabIndex = 2;
            this.OutButton.Text = "Check Out";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 331);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.databasecheckout);
            this.Name = "CheckOut";
            this.Text = "Check Out";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databasecheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCheckOutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView databasecheckout;
        private System.Windows.Forms.BindingSource databaseDataSet1BindingSource;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.Button ReturnButton;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource toCheckOutBindingSource;
        private DatabaseDataSet2TableAdapters.toCheckOutTableAdapter toCheckOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OutButton;
    }
}