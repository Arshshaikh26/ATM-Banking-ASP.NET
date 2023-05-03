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
    public partial class cust_main : Form
    {
        public cust_main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cust_main_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust_cash_with ccw = new cust_cash_with();
            ccw.label1.Text = label1.Text;
            ccw.label2.Text = label2.Text;
            ccw.label3.Text = label4.Text;

            ccw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bal_enq be = new bal_enq();
            be.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            balance_enery be = new balance_enery();
            be.label3.Text = label4.Text;
            be.Show();
        }
    }
}
