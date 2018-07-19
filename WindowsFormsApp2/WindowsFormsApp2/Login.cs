using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

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
            ConfirmButton.Image = Image.FromFile("images/ok.png");
            OutButton.Image = Image.FromFile("images/exit.png");
            this.ControlBox = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
            
            SqlCommand command = new SqlCommand("SELECT * FROM Users Where Name = @Name AND Password = @Password", connect);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userNameBox.Text;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = PasswordBox.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    try
                    {
                        if (reader[0].ToString() == null)
                        {
                            MessageBox.Show(WRONG_LOG);
                        }
                        else
                        {
                            String val = reader[2].ToString();
                            if (val == "True")
                            {
                                admin = true;
                            }
                            else
                            {
                                admin = false;
                            }
                        }
                        connect.Close();
                        this.Hide();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("User/Password does not exist.");
                        this.clear();
                        connect.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
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

        private void OutButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
