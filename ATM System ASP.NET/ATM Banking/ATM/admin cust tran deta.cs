using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlClient;

namespace ATM
{
    public partial class admin_cust_tran_deta : Form
    {
        SqlConnection con = new SqlConnection(data.con);
        public admin_cust_tran_deta()
        {
            InitializeComponent();
        }

        private void admin_cust_tran_deta_Load(object sender, EventArgs e)
        {
           DataGridViewButtonColumn del=new DataGridViewButtonColumn();
            del.Text="Delete";
                del.Name="Delete";
            del.DataPropertyName="Delete";
            dataGridView1.Columns.Add(del);





       
    }

    private void button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from transactions where account_no='"+textBox1.Text+"'", con);
        DataSet ds = new DataSet();
        da.Fill(ds, "transactions");
        // BindingSource bs = new BindingSource();
        dataGridView1.AutoGenerateColumns = true;
        dataGridView1.DataSource = ds;

        dataGridView1.DataMember = "transactions".ToString();

       

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        //if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("delete from transactions where account_no='" + textBox1.Text + "'", con);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}
        if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
        {
            MessageBox.Show(String.Format("Clicked! Row: {0}", e.RowIndex));
        }
    }

  
   
  }
}

