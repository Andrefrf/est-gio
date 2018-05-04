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
            connect.Open();
            using (SqlCommand com = new SqlCommand("SELECT PersonID as ID from Person where Name = @Name AND Surname = @Surname AND IdNumber = @IdNumber AND DocType = @DocType", connect))
            {

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
            }

            using (SqlCommand com = new SqlCommand("UPDATE Visits SET Out = @Leaving Where PersonID = @PersonID AND Out = @Left AND Entrance = @Entrance",connect))
            {
                com.Parameters.Add("@PersonId", SqlDbType.Int).Value = outId;
                com.Parameters.Add("@Left", SqlDbType.DateTime2).Value = DBNull.Value;
                com.Parameters.Add("@Leaving", SqlDbType.DateTime2).Value = DateTime.Now;
                com.Parameters.Add("@Entrance", SqlDbType.DateTime2).Value = selectRow.Cells[4].Value;


                com.ExecuteNonQuery();
                SqlTransaction trans = connect.BeginTransaction();
                trans.Commit();
            }
            connect.Close();
            MessageBox.Show("Visitor checked out!");
            updateTable();
        }

        private DateTime makeTime(string v)
        {
            String[] splitted = v.Split(null);
            String[] day = splitted[0].Split('/');
            String[] time = splitted[1].Split(':');
            DateTime date = new DateTime(getInt(day[2]), getInt(day[1]), getInt(day[0]), getInt(time[0]),getInt(time[1]),getInt(time[2]));
            return date;
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
