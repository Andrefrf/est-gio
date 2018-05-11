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
    public partial class UserDelete : Form
    {
        private SqlConnection connect;

        public UserDelete(System.Data.SqlClient.SqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
            fillUsers();
        }

        private void fillUsers()
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT Name FROM Users", connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserCombo.Items.Add(reader["Name"].ToString());
            }
            connect.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE Name = @Name", connect);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = UserCombo.Text;
            command.ExecuteNonQuery();
            SqlTransaction trans = connect.BeginTransaction();
            trans.Commit();
            connect.Close();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
