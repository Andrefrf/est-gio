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
            if (newPWBox.Text.ToCharArray().Length < 5)
            {
                MessageBox.Show("The password must be 5 characters long");
            }
            else
            {
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

                this.Close();
            }
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
