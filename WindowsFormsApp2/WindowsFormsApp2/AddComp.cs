﻿using System;
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
    public partial class Form5 : Form
    {
        SqlConnection connection;
        public Form5(System.Data.SqlClient.SqlConnection connect)
        {
            InitializeComponent();
            connection = connect;
        }

        private void AddCompButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public String getComp()
        {
            return CompanyBox.Text;
        }
    }
}
