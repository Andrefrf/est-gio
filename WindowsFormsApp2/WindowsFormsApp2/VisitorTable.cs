using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class VisitorTable : Form
    {
        private SqlConnection connect;
        public VisitorTable(SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
            fillTable();
            foreach (DataGridViewColumn c in VisitTable.Columns)
            {
                comboBox1.Items.Add(c.Name);
            }
            comboBox1.Text = comboBox1.Items[1].ToString();
            checkBox1.Visible = false;
            textBox1.Visible = true;
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
            string rowFilter = null ;
            if (textBox1.Visible)
            {
                if (textBox1.Text != "")
                {
                    rowFilter = string.Format("[{0}] = '{1}'", comboBox1.Text, textBox1.Text);
                }
            }
            else
            {
                rowFilter = string.Format("[{0}] = '{1}'", comboBox1.Text, checkBox1.Checked.ToString());

            }
            (VisitTable.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void updateTable()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter();
            sqlData.SelectCommand = new SqlCommand("SELECT * From AllVisits", connect);

            DataTable dtb = new DataTable();
            sqlData.Fill(dtb);
            VisitTable.DataSource = dtb;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "State" || comboBox1.Text == "Delivery")
            {
                checkBox1.Visible = true;
                textBox1.Visible = false;
            }
            else
            {
                checkBox1.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
