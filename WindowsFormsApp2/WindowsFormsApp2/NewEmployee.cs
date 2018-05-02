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

            SqlCommand command = new SqlCommand("SELECT Company,Department FROM Companies", connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                companyCombo.Items.Add(reader["Company"].ToString() + "," + reader["Department"].ToString());
            }
            connect.Close();
        }


        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                String name = NameBox.Text;
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Workers(Name,WorkerId) VALUES(@Name,NEXT VALUE For Id_Seq_Worker)");
                using (SqlCommand com = new SqlCommand(sb.ToString(), connect))
                {
                    com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = valuesCheck(name);
                    com.CommandType = System.Data.CommandType.Text;

                    com.ExecuteNonQuery();
                    SqlTransaction trans = connect.BeginTransaction();
                    trans.Commit();
                }
                using (SqlCommand com = new SqlCommand("Insert into WorksIn(Company,WorkerId) values(@Company,@Worker)", connect))
                {
                    int IDw = getWorkerId(name);
                    int IDc = getCompanyId(companyCombo.Text);

                    com.Parameters.Add("@Company", SqlDbType.Int).Value = IDc;
                    com.Parameters.Add("@Worker", SqlDbType.Int).Value = IDw;
                    com.ExecuteNonQuery();
                    SqlTransaction trans = connect.BeginTransaction();
                    trans.Commit();
                }

                connect.Close();
                this.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show("This worker is already in the company and department");
                MessageBox.Show(exc.Message.ToString());
                connect.Close();
            }
        }

        private int getCompanyId(string text)
        {
            String[] compD = text.Split(',');
            using (SqlCommand com = new SqlCommand("Select ID from Companies where Company = @Company AND Department = @Department", connect))
            {
                connect.Open();

                com.Parameters.Add("@Company", SqlDbType.NVarChar).Value = compD[0];
                com.Parameters.Add("@Department", SqlDbType.NVarChar).Value = compD[1];

                com.ExecuteNonQuery();
                SqlDataReader r = com.ExecuteReader();
                r.Read();
                return Int32.Parse(r["ID"].ToString());
            }
        }

        private int getWorkerId(string name)
        {
            using (SqlCommand com = new SqlCommand("Select WorkerId from Workers where Name = @Name", connect)) { 
            connect.Open();
            com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
            com.ExecuteNonQuery();
            SqlDataReader r = com.ExecuteReader();
            r.Read();
            return Int32.Parse(r["WorkerId"].ToString());
            }
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

    internal class int32
    {
    }
}
