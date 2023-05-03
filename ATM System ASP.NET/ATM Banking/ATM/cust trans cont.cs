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
    public partial class cust_trans_cont : Form
    {
        public cust_trans_cont()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust_main cm = new cust_main();
            cm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
