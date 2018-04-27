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
    public partial class PersonForm : Form
    {
        SqlConnection connect;

        public PersonForm(System.Data.SqlClient.SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            companyFill();
        }

        public PersonForm(SqlConnection connection, string text) : this(connection)
        {
            Text = text;
        }

        private void companyFill()
        {
            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to DB");
            }

            SqlCommand command = new SqlCommand("SELECT Company FROM Companies", connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                companyCombo.Items.Add(reader["Company"].ToString());
            }
            connect.Close();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO ToVisit(Name,Id) VALUES(@Name,@Id)");
            using (SqlCommand com = new SqlCommand(sb.ToString(), connect))
            {
                connect.Open();
                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = valuesCheck(name);

                com.CommandType = System.Data.CommandType.Text;

                com.Connection = connect;


                com.ExecuteNonQuery();
                SqlTransaction trans = connect.BeginTransaction();
                trans.Commit();
                MessageBox.Show("Data Inserted!");
            }

            connect.Close();
            this.Close();
        }

        private object valuesCheck(string text)
        {
            if (text == null)
            {
                return DBNull.Value;
            }
            else return text;
        }
    }
}
