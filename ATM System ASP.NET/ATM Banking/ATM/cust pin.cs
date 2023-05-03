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
    public partial class cust_pin : Form
    {
        public cust_pin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cust_pin_Load(object sender, EventArgs e)
        {
            label7.Visible=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer_details where pin='" + textBox1.Text + "'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                cust_main cm = new cust_main();
                cm.label1.Text = label7.Text;
                cm.label2.Text = label6.Text;
                cm.label4.Text = label8.Text;
                cm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Pin");
            }

                
        }
    }
}
