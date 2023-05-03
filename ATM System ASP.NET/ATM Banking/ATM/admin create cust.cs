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
    public partial class admin_create_cust : Form
    {
        SqlConnection con = new SqlConnection(data.con);
        public admin_create_cust()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void admin_create_cust_Load(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand com = new SqlCommand("select count(*) from customer_details", con);
            //con.Open();
            int count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            textBox8.Text = ("3241100011" + count);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("data source=CLIENT-07\\SQLEXPRESS;integrated security=true;initial catalog=ATM;");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer_details(name,address,email_id,contact_number,card_number,pin,city,account_type,balance) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox9.Text + "')", con);
            cmd.ExecuteNonQuery();
            comboBox1.Text = " ";
            textBox9.Text=" ";
            textBox8.Text = " ";
            textBox7.Text = " ";
            textBox6.Text = " ";
            textBox5.Text = " ";
            textBox4.Text = " ";
            textBox3.Text = " ";
            textBox2.Text = " ";
            textBox1.Text = " ";
            textBox1.Focus();
            con.Close();



           
        }
    }
}
