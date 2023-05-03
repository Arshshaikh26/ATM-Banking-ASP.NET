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
    public partial class admin_view_customer : Form
    {
        SqlConnection con = new SqlConnection(data.con);
        public admin_view_customer()
        {
            InitializeComponent();
        }

        private void admin_view_customer_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer_details", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"customer_details");
           // BindingSource bs = new BindingSource();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = ds;
          
          dataGridView1.DataMember = "customer_details".ToString();
            
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
