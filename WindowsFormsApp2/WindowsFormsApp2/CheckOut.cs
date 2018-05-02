using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            this.toCheckOutTableAdapter.Fill(this.databaseDataSet2.toCheckOut);
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            this.toCheckOutTableAdapter.Fill(this.databaseDataSet2.toCheckOut);
        }

        private void OutButton_Click(object sender, EventArgs e)
        {
            databasecheckout.SelectedRows.
        }
    }
}
