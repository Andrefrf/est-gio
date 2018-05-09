namespace WindowsFormsApp2
{
    partial class UserAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PWLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.pwBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminCheck = new System.Windows.Forms.CheckBox();
            this.newPWBox = new System.Windows.Forms.TextBox();
            this.newUserBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PWLabel);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Controls.Add(this.pwBox);
            this.groupBox1.Controls.Add(this.userBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Adding";
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWLabel.Location = new System.Drawing.Point(6, 95);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(103, 22);
            this.PWLabel.TabIndex = 8;
            this.PWLabel.Text = "Password:";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(51, 45);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(58, 22);
            this.UserName.TabIndex = 7;
            this.UserName.Text = "User:";
            // 
            // pwBox
            // 
            this.pwBox.Location = new System.Drawing.Point(115, 97);
            this.pwBox.Name = "pwBox";
            this.pwBox.PasswordChar = '*';
            this.pwBox.Size = new System.Drawing.Size(222, 23);
            this.pwBox.TabIndex = 1;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(115, 47);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(222, 23);
            this.userBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.adminCheck);
            this.groupBox2.Controls.Add(this.newPWBox);
            this.groupBox2.Controls.Add(this.newUserBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(453, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Admin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "User:";
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.Location = new System.Drawing.Point(115, 153);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(15, 14);
            this.adminCheck.TabIndex = 4;
            this.adminCheck.UseVisualStyleBackColor = true;
            // 
            // newPWBox
            // 
            this.newPWBox.Location = new System.Drawing.Point(115, 97);
            this.newPWBox.Name = "newPWBox";
            this.newPWBox.PasswordChar = '*';
            this.newPWBox.Size = new System.Drawing.Size(205, 23);
            this.newPWBox.TabIndex = 3;
            // 
            // newUserBox
            // 
            this.newUserBox.Location = new System.Drawing.Point(115, 47);
            this.newUserBox.Name = "newUserBox";
            this.newUserBox.Size = new System.Drawing.Size(205, 23);
            this.newUserBox.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(23, 196);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(140, 46);
            this.ConfirmButton.TabIndex = 2;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(227, 196);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(140, 46);
            this.outButton.TabIndex = 3;
            this.outButton.Text = "Cancel";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserAdd";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label PWLabel;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox pwBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox adminCheck;
        private System.Windows.Forms.TextBox newPWBox;
        private System.Windows.Forms.TextBox newUserBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button outButton;
    }
}