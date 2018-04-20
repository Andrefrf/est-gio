namespace WindowsFormsApp2
{
    partial class Main
    {

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Photo = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.idNBox = new System.Windows.Forms.TextBox();
            this.Companybox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.Scan = new System.Windows.Forms.Button();
            this.Configure = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.DeliveryYes = new System.Windows.Forms.CheckBox();
            this.DeliveryNo = new System.Windows.Forms.CheckBox();
            this.VisitingLabel = new System.Windows.Forms.Label();
            this.VisitingCombo = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.VisitorButton = new System.Windows.Forms.Button();
            this.CompLabel = new System.Windows.Forms.Label();
            this.CompCombo = new System.Windows.Forms.ComboBox();
            this.VisitingAdd = new System.Windows.Forms.Button();
            this.VCompAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.SystemColors.Info;
            this.Photo.Location = new System.Drawing.Point(26, 12);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(160, 170);
            this.Photo.TabIndex = 0;
            this.Photo.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(235, 38);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(200, 20);
            this.NameBox.TabIndex = 1;
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(455, 38);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(200, 20);
            this.SurnameBox.TabIndex = 2;
            // 
            // idNBox
            // 
            this.idNBox.Location = new System.Drawing.Point(455, 104);
            this.idNBox.Name = "idNBox";
            this.idNBox.Size = new System.Drawing.Size(200, 20);
            this.idNBox.TabIndex = 3;
            // 
            // Companybox
            // 
            this.Companybox.Location = new System.Drawing.Point(235, 160);
            this.Companybox.Name = "Companybox";
            this.Companybox.Size = new System.Drawing.Size(200, 20);
            this.Companybox.TabIndex = 4;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(235, 104);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(200, 20);
            this.TypeBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(452, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Identity Number";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeLabel.Location = new System.Drawing.Point(232, 88);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 14;
            this.TypeLabel.Text = "Type";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Transparent;
            this.Name.Location = new System.Drawing.Point(232, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 15;
            this.Name.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.BackColor = System.Drawing.Color.Transparent;
            this.Surname.Location = new System.Drawing.Point(452, 22);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(49, 13);
            this.Surname.TabIndex = 16;
            this.Surname.Text = "Surname";
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryLabel.Location = new System.Drawing.Point(452, 144);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(79, 13);
            this.DeliveryLabel.TabIndex = 17;
            this.DeliveryLabel.Text = "With Delivery ?";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompanyLabel.Location = new System.Drawing.Point(232, 144);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(51, 13);
            this.CompanyLabel.TabIndex = 18;
            this.CompanyLabel.Text = "Company";
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(235, 441);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(298, 102);
            this.Scan.TabIndex = 23;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Configure
            // 
            this.Configure.Location = new System.Drawing.Point(26, 441);
            this.Configure.Name = "Configure";
            this.Configure.Size = new System.Drawing.Size(191, 48);
            this.Configure.TabIndex = 24;
            this.Configure.Text = "Configure";
            this.Configure.UseVisualStyleBackColor = true;
            this.Configure.Click += new System.EventHandler(this.Configure_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(26, 495);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 48);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // DeliveryYes
            // 
            this.DeliveryYes.AutoSize = true;
            this.DeliveryYes.Location = new System.Drawing.Point(455, 161);
            this.DeliveryYes.Name = "DeliveryYes";
            this.DeliveryYes.Size = new System.Drawing.Size(44, 17);
            this.DeliveryYes.TabIndex = 30;
            this.DeliveryYes.Text = "Yes";
            this.DeliveryYes.UseVisualStyleBackColor = true;
            this.DeliveryYes.CheckedChanged += new System.EventHandler(this.DeliveryYes_CheckedChanged);
            // 
            // DeliveryNo
            // 
            this.DeliveryNo.AutoSize = true;
            this.DeliveryNo.Location = new System.Drawing.Point(610, 161);
            this.DeliveryNo.Name = "DeliveryNo";
            this.DeliveryNo.Size = new System.Drawing.Size(40, 17);
            this.DeliveryNo.TabIndex = 31;
            this.DeliveryNo.Text = "No";
            this.DeliveryNo.UseVisualStyleBackColor = true;
            this.DeliveryNo.CheckedChanged += new System.EventHandler(this.DeliveryNo_CheckedChanged);
            // 
            // VisitingLabel
            // 
            this.VisitingLabel.AutoSize = true;
            this.VisitingLabel.BackColor = System.Drawing.Color.Transparent;
            this.VisitingLabel.Location = new System.Drawing.Point(46, 268);
            this.VisitingLabel.Name = "VisitingLabel";
            this.VisitingLabel.Size = new System.Drawing.Size(40, 13);
            this.VisitingLabel.TabIndex = 34;
            this.VisitingLabel.Text = "Visiting";
            // 
            // VisitingCombo
            // 
            this.VisitingCombo.FormattingEnabled = true;
            this.VisitingCombo.Location = new System.Drawing.Point(49, 284);
            this.VisitingCombo.Name = "VisitingCombo";
            this.VisitingCombo.Size = new System.Drawing.Size(114, 21);
            this.VisitingCombo.TabIndex = 35;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(26, 387);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(191, 48);
            this.PrintButton.TabIndex = 36;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // InButton
            // 
            this.InButton.Location = new System.Drawing.Point(539, 387);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(200, 75);
            this.InButton.TabIndex = 37;
            this.InButton.Text = "Check In";
            this.InButton.UseVisualStyleBackColor = true;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(539, 468);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(200, 75);
            this.OutButton.TabIndex = 38;
            this.OutButton.Text = "Check Out";
            this.OutButton.UseVisualStyleBackColor = true;
            // 
            // VisitorButton
            // 
            this.VisitorButton.Location = new System.Drawing.Point(235, 387);
            this.VisitorButton.Name = "VisitorButton";
            this.VisitorButton.Size = new System.Drawing.Size(296, 48);
            this.VisitorButton.TabIndex = 39;
            this.VisitorButton.Text = "Visitors";
            this.VisitorButton.UseVisualStyleBackColor = true;
            // 
            // CompLabel
            // 
            this.CompLabel.AutoSize = true;
            this.CompLabel.Location = new System.Drawing.Point(232, 268);
            this.CompLabel.Name = "CompLabel";
            this.CompLabel.Size = new System.Drawing.Size(121, 13);
            this.CompLabel.TabIndex = 40;
            this.CompLabel.Text = "Company/Floor/Building";
            // 
            // CompCombo
            // 
            this.CompCombo.FormattingEnabled = true;
            this.CompCombo.Location = new System.Drawing.Point(235, 284);
            this.CompCombo.Name = "CompCombo";
            this.CompCombo.Size = new System.Drawing.Size(121, 21);
            this.CompCombo.TabIndex = 41;
            // 
            // VisitingAdd
            // 
            this.VisitingAdd.Location = new System.Drawing.Point(169, 282);
            this.VisitingAdd.Name = "VisitingAdd";
            this.VisitingAdd.Size = new System.Drawing.Size(42, 23);
            this.VisitingAdd.TabIndex = 45;
            this.VisitingAdd.Text = "Add";
            this.VisitingAdd.UseVisualStyleBackColor = true;
            this.VisitingAdd.Click += new System.EventHandler(this.VisitingAdd_Click);
            // 
            // VCompAdd
            // 
            this.VCompAdd.Location = new System.Drawing.Point(364, 282);
            this.VCompAdd.Name = "VCompAdd";
            this.VCompAdd.Size = new System.Drawing.Size(43, 23);
            this.VCompAdd.TabIndex = 46;
            this.VCompAdd.Text = "Add";
            this.VCompAdd.UseVisualStyleBackColor = true;
            this.VCompAdd.Click += new System.EventHandler(this.VCompAdd_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(826, 555);
            this.Controls.Add(this.VCompAdd);
            this.Controls.Add(this.VisitingAdd);
            this.Controls.Add(this.CompCombo);
            this.Controls.Add(this.CompLabel);
            this.Controls.Add(this.VisitorButton);
            this.Controls.Add(this.DeliveryYes);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.VisitingCombo);
            this.Controls.Add(this.VisitingLabel);
            this.Controls.Add(this.DeliveryNo);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Configure);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.DeliveryLabel);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.Companybox);
            this.Controls.Add(this.idNBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Photo);
            this.Text = "IcarVisitor";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox idNBox;
        private System.Windows.Forms.TextBox Companybox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TypeLabel;
#pragma warning disable CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        private System.Windows.Forms.Label Name;
#pragma warning restore CS0108 // O membro oculta o membro herdado; nova palavra-chave ausente
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label DeliveryLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Configure;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox DeliveryYes;
        private System.Windows.Forms.CheckBox DeliveryNo;
        private System.Windows.Forms.Label VisitingLabel;
        private System.Windows.Forms.ComboBox VisitingCombo;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button VisitorButton;
        private System.Windows.Forms.Label CompLabel;
        private System.Windows.Forms.ComboBox CompCombo;
        private System.Windows.Forms.Button VisitingAdd;
        private System.Windows.Forms.Button VCompAdd;
    }
}

