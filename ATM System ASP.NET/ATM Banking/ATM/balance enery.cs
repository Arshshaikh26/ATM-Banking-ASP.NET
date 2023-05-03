using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

    namespace ATM
{
    public partial class balance_enery : Form
    {
        SqlConnection con = new SqlConnection(data.con);
        public balance_enery()
        {
            InitializeComponent();
        }

        private void balance_enery_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            //SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select  * from transactions where account_no='" + label3.Text + "'", con);
            SqlDataReader rdr= cmd.ExecuteReader();
            if (rdr.Read())
            {
                label2.Text = rdr["total"].ToString();
            }
            rdr.Close();
            rdr.Dispose();
            con.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
