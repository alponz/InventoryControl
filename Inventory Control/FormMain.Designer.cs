namespace Inventory_Control
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelMenuInventory = new System.Windows.Forms.Label();
            this.labelMenuSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // labelMenuInventory
            // 
            this.labelMenuInventory.AutoSize = true;
            this.labelMenuInventory.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelMenuInventory.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuInventory.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMenuInventory.Location = new System.Drawing.Point(86, 142);
            this.labelMenuInventory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMenuInventory.Name = "labelMenuInventory";
            this.labelMenuInventory.Size = new System.Drawing.Size(159, 25);
            this.labelMenuInventory.TabIndex = 3;
            this.labelMenuInventory.Text = "Go to INVENTORY";
            this.labelMenuInventory.Click += new System.EventHandler(this.labelMenuInventory_Click);
            this.labelMenuInventory.MouseLeave += new System.EventHandler(this.labelMenuInventory_MouseLeave);
            this.labelMenuInventory.MouseHover += new System.EventHandler(this.labelMenuInventory_MouseHover);
            // 
            // labelMenuSales
            // 
            this.labelMenuSales.AutoSize = true;
            this.labelMenuSales.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuSales.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMenuSales.Location = new System.Drawing.Point(109, 192);
            this.labelMenuSales.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMenuSales.Name = "labelMenuSales";
            this.labelMenuSales.Size = new System.Drawing.Size(112, 25);
            this.labelMenuSales.TabIndex = 4;
            this.labelMenuSales.Text = "Go to SALES";
            this.labelMenuSales.Click += new System.EventHandler(this.labelMenuSales_Click);
            this.labelMenuSales.MouseLeave += new System.EventHandler(this.labelMenuSales_MouseLeave);
            this.labelMenuSales.MouseHover += new System.EventHandler(this.labelMenuSales_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(331, 343);
            this.Controls.Add(this.labelMenuSales);
            this.Controls.Add(this.labelMenuInventory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMenuInventory;
        private System.Windows.Forms.Label labelMenuSales;
    }
}