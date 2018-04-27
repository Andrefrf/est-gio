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
    public partial class newBuilding : Form
    {
        SqlConnection connection;
        String comp;
        public newBuilding(System.Data.SqlClient.SqlConnection connect, string text)
        {
            InitializeComponent();
            comp = text;
            connection = connect;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Companies Set Building = @Building Where Company = @Company");
            using (SqlCommand com = new SqlCommand(sb.ToString(), connection))
            {
                com.Parameters.Add("@Building", SqlDbType.NVarChar).Value = BuildingText.Text;
                com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = comp;

                com.CommandType = System.Data.CommandType.Text;

                com.Connection = connection;

                connection.Open();

                com.ExecuteNonQuery();
                SqlTransaction trans = connection.BeginTransaction();
                trans.Commit();
                MessageBox.Show("Building Created!");
            }
            connection.Close();
            this.Close();
        }
    }
}
