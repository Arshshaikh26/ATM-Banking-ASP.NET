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
    public partial class cust_cash_with_sav : Form
    {
        public cust_cash_with_sav()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               label4.Text = (double.Parse(label1.Text) - double.Parse(textBox1.Text)).ToString();
              




                cust_receipt cr = new cust_receipt();
                cr.label9.Text = textBox1.Text;
                cr.label11.Text = label4.Text;
                cr.label10.Text = label5.Text;
                cr.label13.Text = label1.Text;
                cr.label14.Text = label2.Text;
                cr.Show();
        }

        private void cust_cash_with_sav_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
