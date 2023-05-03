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
    public partial class admin_main : Form
    {
        public admin_main()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_create_cust acc = new admin_create_cust();
            acc.Show();
        }

        private void viewCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_view_customer avc = new admin_view_customer();
            avc.Show();
        }

        private void addACDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_add_acc_cust aaac = new admin_add_acc_cust();
            aaac.Show();
        }

        private void customerTransDeyailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_cust_tran_deta actd = new admin_cust_tran_deta();
            actd.Show();
        }
    }
}
