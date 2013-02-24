using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Control
{
    public partial class FormSalesAdd : Form
    {
        public FormSalesAdd()
        {
            InitializeComponent();
        }

        private void FormSalesAdd_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSetIC.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dataSetIC.Item);
            // TODO: This line of code loads data into the 'dataSetIC.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dataSetIC.Sales);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            double xprice = Convert.ToDouble(dataSetIC.Tables["Item"].Rows[this.comboBoxItem.SelectedIndex]["ItemSellPrice"]);
            double xamount = Convert.ToDouble(textBoxItemAmount.Text);
            textBoxTotal.Text = Convert.ToString(xprice * xamount);
        }

        private void validateTextDouble(object sender, EventArgs e)
        {
            Exception X = new Exception();

            TextBox T = (TextBox)sender;

            try
            {
                if (T.Text != "-")
                {
                    double x = double.Parse(T.Text);

                    if (T.Text.Contains(','))
                        throw X;
                }
                
            }
            catch (Exception)
            {
                try
                {
                    int CursorIndex = T.SelectionStart - 1;
                    T.Text = T.Text.Remove(CursorIndex, 1);

                    //Align Cursor to same index
                    T.SelectionStart = CursorIndex;
                    T.SelectionLength = 0;
                }
                catch (Exception) { }
            }
            if (T.Text == "")
            {
                T.Text = "0";
            }
            double xprice = Convert.ToDouble(dataSetIC.Tables["Item"].Rows[comboBoxItem.SelectedIndex]["ItemSellPrice"]);
            double xamount = Convert.ToDouble(textBoxItemAmount.Text);
            textBoxTotal.Text = Convert.ToString(xprice * xamount);
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.salesTableAdapter.Insert(DateTime.Now, Convert.ToInt32(comboBoxItem.SelectedValue), Convert.ToDouble(textBoxItemAmount.Text), Convert.ToDecimal(textBoxTotal.Text), true);
            this.itemTableAdapter.UpdateAmount(Convert.ToDouble(textBoxItemAmount.Text), Convert.ToInt32(comboBoxItem.SelectedValue));
            this.Close();
            this.Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }




    }
}
