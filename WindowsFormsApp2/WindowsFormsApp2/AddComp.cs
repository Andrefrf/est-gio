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
    public partial class Form5 : Form
    {
        SqlConnection connection;
        public Form5(System.Data.SqlClient.SqlConnection connect)
        {
            InitializeComponent();
            connection = connect;
        }

        private void AddCompButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Companies(Company) VALUES(@Comapny)");
            using (SqlCommand com = new SqlCommand(sb.ToString(), connection))
            {

                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = CompanyBox.Text;

                com.CommandType = System.Data.CommandType.Text;

                com.Connection = connection;

                connection.Open();

                com.ExecuteNonQuery();
                SqlTransaction trans = connection.BeginTransaction();
                trans.Commit();
                MessageBox.Show("Company created");
            }
            connection.Close();
            this.Close();
        }
    }
}
