namespace Inventory_Control
{
    partial class FormSales
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIC = new Inventory_Control.DataSetIC();
            this.salesTableAdapter = new Inventory_Control.DataSetICTableAdapters.SalesTableAdapter();
            this.salesIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SALES";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(305, 44);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 30);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(13, 48);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(284, 25);
            this.textBoxSearch.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.SalesDate,
            this.ItemName,
            this.itemAmountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.salesActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.dataSetIC;
            // 
            // dataSetIC
            // 
            this.dataSetIC.DataSetName = "DataSetIC";
            this.dataSetIC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesIDDataGridViewTextBoxColumn
            // 
            this.salesIDDataGridViewTextBoxColumn.DataPropertyName = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.HeaderText = "SalesID";
            this.salesIDDataGridViewTextBoxColumn.Name = "salesIDDataGridViewTextBoxColumn";
            this.salesIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.salesIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // SalesDate
            // 
            this.SalesDate.DataPropertyName = "SalesDate";
            this.SalesDate.HeaderText = "SalesDate";
            this.SalesDate.Name = "SalesDate";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // itemAmountDataGridViewTextBoxColumn
            // 
            this.itemAmountDataGridViewTextBoxColumn.DataPropertyName = "ItemAmount";
            this.itemAmountDataGridViewTextBoxColumn.HeaderText = "ItemAmount";
            this.itemAmountDataGridViewTextBoxColumn.Name = "itemAmountDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // salesActiveDataGridViewCheckBoxColumn
            // 
            this.salesActiveDataGridViewCheckBoxColumn.DataPropertyName = "SalesActive";
            this.salesActiveDataGridViewCheckBoxColumn.HeaderText = "SalesActive";
            this.salesActiveDataGridViewCheckBoxColumn.Name = "salesActiveDataGridViewCheckBoxColumn";
            this.salesActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(689, 44);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(88, 30);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "Add New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(802, 530);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetIC dataSetIC;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DataSetICTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn salesActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button buttonNew;

    }
}

