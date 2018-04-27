using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class NewCompFloorBuild : Form
    {
        SqlConnection connect;
        public NewCompFloorBuild(System.Data.SqlClient.SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            companyFill();
        }

        private void AddBurron_Click(object sender, EventArgs e)
        {
            using (SqlCommand com = new SqlCommand("Insert into Companies(Name, Department, ID values (@Company, @Department, @ID",connect))
            {
                com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CompanyCombo.Text;
                com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = DepartmentBox.Text;
                com.Parameters.Add("@ID", SqlDbType.Int).Value = "NEXT VALUE FROM Id_Seq_Company";
                connect.Open();
                com.ExecuteNonQuery();
                SqlTransaction trans = connect.BeginTransaction();
                trans.Commit();
                connect.Close();
            }
            this.Close();
        }

        private void AddCompany_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5(connect);
            form.ShowDialog();
            while (!this.ContainsFocus)
            {
                continue;
            }
            CompanyCombo.Items.Add(form.getComp());
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

            SqlCommand command = new SqlCommand("SELECT DISTINCT Company FROM Companies", connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CompanyCombo.Items.Add(reader["Company"].ToString());
            }
            connect.Close();
        }


        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void CompanySelected(object sender,EventArgs e)
        {
            DepartmentBox.Enabled = true;
        }

    }
}
