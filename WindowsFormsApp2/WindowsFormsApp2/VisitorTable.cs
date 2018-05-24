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
    public partial class VisitorTable : Form
    {
        private SqlConnection connect;
        private int toFilter;
        public VisitorTable(SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            fillTable();
        }

        private void fillTable()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter();
            sqlData.SelectCommand = new SqlCommand("SELECT * From AllVisits", connect);

            DataTable dtb = new DataTable();
            sqlData.Fill(dtb);
            VisitTable.DataSource = dtb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateTable();
            if (textBox1.Text != "")
            {
                for (int u = 0; u < VisitTable.RowCount; u++)
                {
                    if (VisitTable.Rows[u].Cells[toFilter].Value.Equals(textBox1.Text))
                    {
                        VisitTable.Rows[u].Visible = true;
                    }
                    else
                    {
                        VisitTable.Rows.RemoveAt(u);
                    }
                }
            }
        }
        
        private void updateTable()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter();
            sqlData.SelectCommand = new SqlCommand("SELECT * From AllVisits", connect);

            DataTable dtb = new DataTable();
            sqlData.Fill(dtb);
            VisitTable.DataSource = dtb;
        }
    }
}
