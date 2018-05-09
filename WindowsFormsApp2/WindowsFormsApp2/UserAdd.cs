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
    public partial class UserAdd : Form
    {
        private const string WRONG_LOG = "Wrong Username and/or Password!";
        private const string NOT_ADMIN = "This user is not allowed to add another user";
        private const string ADDED = "New user added!";
        private SqlConnection connect;
        public UserAdd(SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int i = checkUser();
            switch (i)
            {
                case 1:
                    MessageBox.Show(WRONG_LOG);
                    break;

                case 2:
                    MessageBox.Show(NOT_ADMIN);
                    break;

                case 3:
                    connect.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Users(Name,Password,isAdmin) VALUES(@Name,@Password,@isAdmin)", connect);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = newUserBox.Text;
                    command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = newPWBox.Text;
                    Boolean admin = adminCheck.Checked;
                    if (admin)
                    {
                        command.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = 1;
                    }
                    else
                    {
                        command.Parameters.Add("@isAdmin", SqlDbType.Bit).Value = 0;
                    }
                    command.ExecuteNonQuery();
                    SqlTransaction trans = connect.BeginTransaction();
                    trans.Commit();
                    connect.Close();
                    MessageBox.Show(ADDED);
                    break;

                default:
                    break;
            }
            this.Close();
        }

        private int checkUser()
        {
            int status=0;
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Users Where Name = @Name AND Password = @Password", connect);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = userBox.Text;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pwBox.Text;

            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            if (reader["Name"].ToString() == null)
            {
                status = 1;
            }
            else
            {
                Boolean admin = reader.GetBoolean(2);
                if (admin)
                {
                    status = 3;
                }
                else
                {
                    status = 2;
                }
            }
            connect.Close();
            return status;
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
