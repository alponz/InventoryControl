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
    public partial class FormInventoryAdd : Form
    {
        public FormInventoryAdd()
        {
            InitializeComponent();
        }

        private void FormSalesAdd_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dataSetIC.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.dataSetIC.Item);

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
            
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.itemTableAdapter.Insert(textBoxItemName.Text, textBoxItemDescription.Text, Convert.ToDouble(textBoxItemAmount.Text), true, Convert.ToDecimal(textBoxItemSellPrice.Text));
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
