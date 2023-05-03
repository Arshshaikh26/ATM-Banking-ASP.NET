using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM
{
    public partial class cust_cash_with : Form
    {
        public cust_cash_with()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry for Inconvience");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust_cash_with_sav ccws = new cust_cash_with_sav();
            ccws.label1.Text = label1.Text;
            ccws.label2.Text = label2.Text;
            ccws.label5.Text = label3.Text;
           
            
            ccws.Show();
        }
    }
}
