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
            companyFill();
            floorFill();
            buildingFill();
        }


        private void AddFloorButton_Click(object sender, EventArgs e)
        {
            newFloor form = new newFloor(connect, CompanyCombo.Text);
            form.ShowDialog();
            while (!this.ContainsFocus)
            {
                continue;
            }
            floorFill();
            buildingFill();
        }

        private void AddBuildingFloor_Click(object sender, EventArgs e)
        {
            newBuilding form = new newBuilding(connect, CompanyCombo.Text);
            form.ShowDialog();
            while (!this.ContainsFocus)
            {
                continue;
            }
            floorFill();
            buildingFill();
        }

        private void buildingFill()
        {
            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to DB");
            }

            SqlCommand command = new SqlCommand("SELECT Building FROM Companies WHERE Company = @Company", connect);
            command.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CompanyCombo.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                BuildingCombo.Items.Add(reader["Building"].ToString());
            }
            connect.Close();
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
                CompanyCombo.Items.Add(reader["Company"].ToString());
            }
            connect.Close();
        }

        private void floorFill()
        {
            try
            {
                connect.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to DB");
            }

            SqlCommand command = new SqlCommand("SELECT Floor FROM Companies WHERE Company = @Company", connect);
            command.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CompanyCombo.Text;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                CompanyCombo.Items.Add(reader["Floor"].ToString());
            }
            connect.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form inserts information about a company. You must select a company (If the company you want doesn't exist you can create a new one)" +
                "and you can define the floor and/or building it is located in.");
        }

        private void CompanySelected(object sender,EventArgs e)
        {
            FloorCombo.Enabled = true;
            BuildingCombo.Enabled = true;
            floorFill();
            buildingFill();
        }

    }
}
