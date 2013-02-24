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
    public partial class FormInventory : Form
    {
        public FormInventory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetIC.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dataSetIC.Item);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.SearchFill(this.dataSetIC.Item, textBoxSearch.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.Update(this.dataSetIC.Item);
                labelSaved.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSaved.Visible = false;
            labelReverted.Visible = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.itemTableAdapter.Fill(this.dataSetIC.Item);
                labelReverted.Visible = true;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                //MessageBox.Show(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString());
                if (dataGridView1.Rows[i].Cells[0].FormattedValue.ToString() == "True")
                {
                    this.itemTableAdapter.Delete(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString()));
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormInventoryAdd frm = new FormInventoryAdd();
            frm.ShowDialog();
            refresh();
        }

        public void refresh()
        {
            this.itemTableAdapter.Fill(this.dataSetIC.Item);
        }

    }
}
