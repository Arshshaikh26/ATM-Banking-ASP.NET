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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_login al = new admin_login();
            al.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cust_card_no ccn = new cust_card_no();
            ccn.Show();
        }
    }
}
