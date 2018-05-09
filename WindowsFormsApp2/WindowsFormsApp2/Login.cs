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
            if (reader["Name"].ToString() == null) {
                MessageBox.Show(WRONG_LOG);
            }
            else{
                Boolean admin = reader.GetBoolean(2);
            }
            connect.Close();
            this.Hide();
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
    }
}
