using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.OleDb;
namespace Inventory_Control
{
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetIC.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dataSetIC.Sales);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //this.salesTableAdapter.SearchFill(this.dataSetIC.Sales, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormSalesAdd frm = new FormSalesAdd();
            frm.ShowDialog();
            refresh();
        }

        public void refresh()
        {
            this.salesTableAdapter.Fill(this.dataSetIC.Sales);
        }

    }
}
