﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace WindowsFormsApp2
{
    public partial class CheckOut : Form
    {
        private SqlConnection connect;
        private DataGridViewRow selectRow;
        private int toFilter;

        public CheckOut(SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            updateTable();
            foreach (DataGridViewColumn c in outGrid.Columns)
            {
                columnCombo.Items.Add(c.Name);
            }
            columnCombo.Text = columnCombo.Items[0].ToString();
            CheckOutButton.Image = Image.FromFile("images/ok.png");
            ExitButton.Image = Image.FromFile("images/exit.png");
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            updateTable();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectRow = outGrid.Rows[index];
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            int outId = 0;
            DateTime dT = (DateTime)selectRow.Cells[4].Value;
            try
            {
                using (SqlCommand com = new SqlCommand("SELECT PersonID FROM Person Where (Name = @Name OR Surname = @Surname) AND (IdNumber = @IdNumber AND DocType = @DocType)", connect))
                {
                    connect.Open();
                    com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = selectRow.Cells[0].Value.ToString();
                    com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = selectRow.Cells[1].Value.ToString();
                    com.Parameters.Add("@DocType", SqlDbType.NVarChar).Value = selectRow.Cells[2].Value.ToString();
                    com.Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = selectRow.Cells[3].Value.ToString();



                    com.ExecuteNonQuery();
                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        outId = Int32.Parse(reader["PersonID"].ToString());
                    }
                    reader.Close();

                    connect.Close();
                }

                using (SqlCommand command = new SqlCommand("UPDATE Visits SET Out = @Leaving , State = @State WHERE PersonID = @PersonID AND Out is NULL AND Entrance = @Entrance", connect))
                {
                    connect.Open();
                    command.Parameters.Add("@PersonID", SqlDbType.Int).Value = outId;
                    command.Parameters.Add("@Leaving", SqlDbType.DateTime).Value = DateTime.Now;
                    command.Parameters.Add("@Entrance", SqlDbType.DateTime).Value = dT;
                    command.Parameters.Add("@State", SqlDbType.Bit).Value = 1;

                    string query = command.CommandText;

                    foreach (SqlParameter p in command.Parameters)
                    {
                        query = query.Replace(p.ParameterName, p.Value.ToString());
                    }
                    command.ExecuteNonQuery();
                    SqlTransaction trans = connect.BeginTransaction();
                    trans.Commit();
                    connect.Close();
                }
                goodCheckOut.Visible = true;
                updateTable();
                outGrid.Update();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private int getInt(string v)
        {
            return Int32.Parse(v);
        }

        private void updateTable()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter();
            sqlData.SelectCommand = new SqlCommand("SELECT * From toCheckOut", connect);

            DataTable dtb = new DataTable();
            sqlData.Fill(dtb);
            outGrid.DataSource = dtb;
            NumberLabel.Text = outGrid.RowCount.ToString();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            updateTable();
            if (FilterValue.Text != "")
            {
                for (int u = 0; u < outGrid.RowCount; u++)
                {
                    if (outGrid.Rows[u].Cells[toFilter].Value.ToString() == FilterValue.Text)
                    {
                        outGrid.Rows[u].Visible = true;
                    }
                    else
                    {
                        outGrid.Rows.RemoveAt(u);
                    }
                }
            }
            NumberLabel.Text = outGrid.RowCount.ToString();
        }

        private void columnCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            toFilter = columnCombo.Items.IndexOf(columnCombo.Text);
        }
    }
}