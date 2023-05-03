namespace ATM
{
    partial class admin_view_customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_detailsTableAdapter = new ATM.ATMDataSetTableAdapters.customer_detailsTableAdapter();
            this.aTMDataSet = new ATM.ATMDataSet();
            this.customerdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aTMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Customer details";
            // 
            // customer_detailsTableAdapter
            // 
            this.customer_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // aTMDataSet
            // 
            this.aTMDataSet.DataSetName = "ATMDataSet";
            this.aTMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerdetailsBindingSource
            // 
            this.customerdetailsBindingSource.DataMember = "customer_details";
            this.customerdetailsBindingSource.DataSource = this.aTMDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 333);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // admin_view_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 372);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "admin_view_customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_view_customer";
            this.Load += new System.EventHandler(this.admin_view_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aTMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ATM.ATMDataSetTableAdapters.customer_detailsTableAdapter customer_detailsTableAdapter;
        private ATMDataSet aTMDataSet;
        private System.Windows.Forms.BindingSource customerdetailsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}