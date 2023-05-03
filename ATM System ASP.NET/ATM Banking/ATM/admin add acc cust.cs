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
    public partial class admin_add_acc_cust : Form
    {
        SqlConnection con = new SqlConnection(data.con);
        public admin_add_acc_cust()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void admin_add_acc_cust_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer_details", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                comboBox1.Items.Add(rdr["account_number"]).ToString();
            }
            label6.Visible = false;
            label5.Visible = false;
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer_details where account_number='"+comboBox1.Text+"'", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                textBox1.Text = rdr["name"].ToString();
                textBox2.Text = rdr["balance"].ToString();
         
            }
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label5.Text = (double.Parse(textBox2.Text) + double.Parse(textBox3.Text)).ToString();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_Layout(object sender, LayoutEventArgs e)
        {
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            label6.Visible = true;
            label5.Visible = true;
            label6.Text = "Account Credited By:";
            textBox3.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
