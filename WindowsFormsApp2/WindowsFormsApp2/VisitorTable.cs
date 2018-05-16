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
        SqlConnection connect;
        public VisitorTable(SqlConnection connection)
        {
            InitializeComponent();
            connect = connection;
        }


    }
}
