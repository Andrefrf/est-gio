using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private const string WRONG_LOG = "Wrong Username and/or Password!";
        protected Boolean admin;
        protected SqlConnection connect;

        public Login(SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            admin = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users Where Name = @Name AND Password = @Password", connect);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userNameBox.Text;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordBox.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            try
            {
                if (reader["Name"].ToString() == null)
                {
                    MessageBox.Show(WRONG_LOG);
                }
                else
                {
                    admin = reader.GetBoolean(2);
                }
                connect.Close();
                this.Hide();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("User/Password does not exist.");
                this.clear();
                connect.Close();
            }

        }

        private void clear()
        {
            userNameBox.Text = null;
            PasswordBox.Text = null;
        }

        public Boolean getType()
        {
            return admin;
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UserAdd adder = new UserAdd(connect);
            adder.ShowDialog();
            userNameBox.Text = null;
            PasswordBox.Text = null;
            this.Hide();
            while (adder.Visible)
            {

            }
            this.Show();
        }

        private void userNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (userNameBox.Focused)
                {
                    PasswordBox.Focus();
                }
                else if (PasswordBox.Focused)
                {
                    ConfirmButton.Focus();
                }
            }
        }
    }
}
