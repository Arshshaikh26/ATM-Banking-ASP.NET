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
    public partial class bal_enq : Form
    {
        SqlConnection con = new SqlConnection(data.con);
        public bal_enq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand cmd = new SqlCommand("update customer_details set pin='" + textBox3.Text + "' where pin='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("PIN Changed Successfully");
            con.Close();
        }
    }
}
