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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void labelMenuInventory_Click(object sender, EventArgs e)
        {
            FormInventory frm = new FormInventory();
            frm.ShowDialog();
        }

        private void labelMenuSales_Click(object sender, EventArgs e)
        {
            FormSales frm = new FormSales();
            frm.ShowDialog();
        }

        private void labelMenuInventory_MouseHover(object sender, EventArgs e)
        {
            labelMenuInventory.BackColor = SystemColors.MenuHighlight;
            labelMenuInventory.ForeColor = SystemColors.Desktop;
        }

        private void labelMenuSales_MouseHover(object sender, EventArgs e)
        {
            labelMenuSales.BackColor = SystemColors.MenuHighlight;
            labelMenuSales.ForeColor = SystemColors.Desktop;
        }

        private void labelMenuInventory_MouseLeave(object sender, EventArgs e)
        {
            labelMenuInventory.BackColor = SystemColors.Desktop;
            labelMenuInventory.ForeColor = SystemColors.MenuHighlight;
        }

        private void labelMenuSales_MouseLeave(object sender, EventArgs e)
        {
            labelMenuSales.BackColor = SystemColors.Desktop;
            labelMenuSales.ForeColor = SystemColors.MenuHighlight;
        }
    }
}
