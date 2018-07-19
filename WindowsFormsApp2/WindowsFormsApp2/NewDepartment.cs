using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class NewDepartment : Form
    {
        SqlConnection connect;
        public NewDepartment(System.Data.SqlClient.SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            companyFill();
        }

        private void AddBurron_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand com = new SqlCommand("insert into Companies(CompanyName, Department ,CompanyID) Values(@Company,@Department, Next Value for Id_Seq_Company)", connect))
                {
                    com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CompanyCombo.Text;
                    com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = DepartmentBox.Text;
                    connect.Open();
                    com.ExecuteNonQuery();
                    SqlTransaction trans = connect.BeginTransaction();
                    trans.Commit();
                    connect.Close();
                }
                this.Close();
            }
            catch(SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            connect.Close();
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
            connect.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT DISTINCT CompanyName as Company FROM Companies", connect);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    CompanyCombo.Items.Add(reader["Company"].ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            connect.Close();
        }


        private void HelpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanySelected(object sender,EventArgs e)
        {
            DepartmentBox.Enabled = true;
        }

    }
}
