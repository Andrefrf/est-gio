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
            this.cardNBox = new System.Windows.Forms.TextBox();
            this.Companybox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Scan = new System.Windows.Forms.Button();
            this.Configure = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.MaleCheck = new System.Windows.Forms.CheckBox();
            this.FemaleCheck = new System.Windows.Forms.CheckBox();
            this.DeliveryYes = new System.Windows.Forms.CheckBox();
            this.DeliveryNo = new System.Windows.Forms.CheckBox();
            this.VisitingLabel = new System.Windows.Forms.Label();
            this.VisitingCombo = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.OutButton = new System.Windows.Forms.Button();
            this.VisitorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.SystemColors.Info;
            this.Photo.Location = new System.Drawing.Point(27, 38);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(167, 188);
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
            // cardNBox
            // 
            this.cardNBox.Location = new System.Drawing.Point(455, 104);
            this.cardNBox.Name = "cardNBox";
            this.cardNBox.Size = new System.Drawing.Size(200, 20);
            this.cardNBox.TabIndex = 3;
            // 
            // Companybox
            // 
            this.Companybox.Location = new System.Drawing.Point(235, 220);
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
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Card number";
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
            this.DeliveryLabel.Location = new System.Drawing.Point(232, 273);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(79, 13);
            this.DeliveryLabel.TabIndex = 17;
            this.DeliveryLabel.Text = "With Delivery ?";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.BackColor = System.Drawing.Color.Transparent;
            this.CompanyLabel.Location = new System.Drawing.Point(232, 204);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(51, 13);
            this.CompanyLabel.TabIndex = 18;
            this.CompanyLabel.Text = "Company";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Location = new System.Drawing.Point(232, 144);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 20;
            this.Gender.Text = "Gender";
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(235, 357);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(191, 75);
            this.Scan.TabIndex = 23;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Configure
            // 
            this.Configure.Location = new System.Drawing.Point(12, 330);
            this.Configure.Name = "Configure";
            this.Configure.Size = new System.Drawing.Size(191, 48);
            this.Configure.TabIndex = 24;
            this.Configure.Text = "Configure";
            this.Configure.UseVisualStyleBackColor = true;
            this.Configure.Click += new System.EventHandler(this.Configure_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 384);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(191, 48);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MaleCheck
            // 
            this.MaleCheck.AutoCheck = false;
            this.MaleCheck.AutoSize = true;
            this.MaleCheck.Location = new System.Drawing.Point(235, 161);
            this.MaleCheck.Name = "MaleCheck";
            this.MaleCheck.Size = new System.Drawing.Size(49, 17);
            this.MaleCheck.TabIndex = 27;
            this.MaleCheck.Text = "Male";
            this.MaleCheck.UseVisualStyleBackColor = true;
            // 
            // FemaleCheck
            // 
            this.FemaleCheck.AutoCheck = false;
            this.FemaleCheck.AutoSize = true;
            this.FemaleCheck.Location = new System.Drawing.Point(366, 161);
            this.FemaleCheck.Name = "FemaleCheck";
            this.FemaleCheck.Size = new System.Drawing.Size(60, 17);
            this.FemaleCheck.TabIndex = 28;
            this.FemaleCheck.Text = "Female";
            this.FemaleCheck.UseVisualStyleBackColor = true;
            // 
            // DeliveryYes
            // 
            this.DeliveryYes.AutoSize = true;
            this.DeliveryYes.Location = new System.Drawing.Point(240, 298);
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
            this.DeliveryNo.Location = new System.Drawing.Point(395, 298);
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
            this.VisitingLabel.Location = new System.Drawing.Point(452, 145);
            this.VisitingLabel.Name = "VisitingLabel";
            this.VisitingLabel.Size = new System.Drawing.Size(40, 13);
            this.VisitingLabel.TabIndex = 34;
            this.VisitingLabel.Text = "Visiting";
            // 
            // VisitingCombo
            // 
            this.VisitingCombo.FormattingEnabled = true;
            this.VisitingCombo.Location = new System.Drawing.Point(455, 161);
            this.VisitingCombo.Name = "VisitingCombo";
            this.VisitingCombo.Size = new System.Drawing.Size(200, 21);
            this.VisitingCombo.TabIndex = 35;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(12, 276);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(191, 48);
            this.PrintButton.TabIndex = 36;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // InButton
            // 
            this.InButton.Location = new System.Drawing.Point(455, 263);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(200, 75);
            this.InButton.TabIndex = 37;
            this.InButton.Text = "Check In";
            this.InButton.UseVisualStyleBackColor = true;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(455, 357);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(200, 75);
            this.OutButton.TabIndex = 38;
            this.OutButton.Text = "Check Out";
            this.OutButton.UseVisualStyleBackColor = true;
            // 
            // VisitorButton
            // 
            this.VisitorButton.Location = new System.Drawing.Point(455, 205);
            this.VisitorButton.Name = "VisitorButton";
            this.VisitorButton.Size = new System.Drawing.Size(191, 48);
            this.VisitorButton.TabIndex = 39;
            this.VisitorButton.Text = "Visitors";
            this.VisitorButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.VisitorButton);
            this.Controls.Add(this.DeliveryYes);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.InButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.VisitingCombo);
            this.Controls.Add(this.VisitingLabel);
            this.Controls.Add(this.DeliveryNo);
            this.Controls.Add(this.FemaleCheck);
            this.Controls.Add(this.MaleCheck);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Configure);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.DeliveryLabel);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.Companybox);
            this.Controls.Add(this.cardNBox);
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
        private System.Windows.Forms.TextBox cardNBox;
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
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Configure;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox MaleCheck;
        private System.Windows.Forms.CheckBox FemaleCheck;
        private System.Windows.Forms.CheckBox DeliveryYes;
        private System.Windows.Forms.CheckBox DeliveryNo;
        private System.Windows.Forms.Label VisitingLabel;
        private System.Windows.Forms.ComboBox VisitingCombo;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button VisitorButton;
    }
}

