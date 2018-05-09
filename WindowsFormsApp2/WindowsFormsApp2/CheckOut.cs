using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp2
{
    public partial class CheckOut : Form
    {
        SqlConnection connect;
        DataGridViewRow selectRow;
        public CheckOut(SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            updateTable();
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

            using (SqlCommand com = new SqlCommand("SELECT PersonID as ID from Person where Name = @Name AND Surname = @Surname AND IdNumber = @IdNumber AND DocType = @DocType", connect))
            {
                connect.Open();
                com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = selectRow.Cells[0].Value.ToString();
                com.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = selectRow.Cells[1].Value.ToString();
                com.Parameters.Add("@DocType", SqlDbType.NVarChar).Value = selectRow.Cells[2].Value.ToString();
                com.Parameters.Add("@IdNumber", SqlDbType.NVarChar).Value = selectRow.Cells[3].Value.ToString();

                com.ExecuteNonQuery();
                SqlDataReader r = com.ExecuteReader();
                r.Read();
                outId = Int32.Parse(r["ID"].ToString());
                MessageBox.Show(outId.ToString());
                r.Close();
                connect.Close();
            }

            using (SqlCommand command = new SqlCommand("UPDATE Visits SET Out = @Leaving FROM Visits WHERE PersonID = @PersonID AND Out is NULL AND Entrance = @Entrance",connect))
            {
                connect.Open();
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = outId;
                command.Parameters.Add("@Leaving", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@Entrance", SqlDbType.DateTime).Value = dT;


                string query = command.CommandText;

                foreach (SqlParameter p in command.Parameters)
                {
                    query = query.Replace(p.ParameterName, p.Value.ToString());
                }
                MessageBox.Show(query);
                command.ExecuteNonQuery();
                SqlTransaction trans = connect.BeginTransaction();
                trans.Commit();
                connect.Close();
            }
            goodCheckOut.Visible = true;
            updateTable();
        }

        private int getInt(string v)
        {
            return Int32.Parse(v);
        }

        private void updateTable()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter();
            sqlData.SelectCommand = new SqlCommand("SELECT * From toCheckOut",connect);
            
            DataTable dtb = new DataTable();
            sqlData.Fill(dtb);
            outGrid.DataSource = dtb;
        }
    }
}