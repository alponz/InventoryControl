namespace Inventory_Control
{
    partial class FormInventoryAdd
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
            this.textBoxItemAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxItemSellPrice = new System.Windows.Forms.TextBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIC = new Inventory_Control.DataSetIC();
            this.itemTableAdapter = new Inventory_Control.DataSetICTableAdapters.ItemTableAdapter();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxItemDescription = new System.Windows.Forms.TextBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "INVENTORY ADD";
            // 
            // textBoxItemAmount
            // 
            this.textBoxItemAmount.Location = new System.Drawing.Point(107, 131);
            this.textBoxItemAmount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemAmount.Name = "textBoxItemAmount";
            this.textBoxItemAmount.Size = new System.Drawing.Size(121, 25);
            this.textBoxItemAmount.TabIndex = 6;
            this.textBoxItemAmount.Text = "0";
            this.textBoxItemAmount.TextChanged += new System.EventHandler(this.validateTextDouble);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(190, 300);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sell Price";
            // 
            // textBoxItemSellPrice
            // 
            this.textBoxItemSellPrice.Location = new System.Drawing.Point(107, 164);
            this.textBoxItemSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemSellPrice.Name = "textBoxItemSellPrice";
            this.textBoxItemSellPrice.Size = new System.Drawing.Size(121, 25);
            this.textBoxItemSellPrice.TabIndex = 10;
            this.textBoxItemSellPrice.Text = "0";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dataSetIC;
            // 
            // dataSetIC
            // 
            this.dataSetIC.DataSetName = "DataSetIC";
            this.dataSetIC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(286, 300);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 30);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Description";
            // 
            // textBoxItemDescription
            // 
            this.textBoxItemDescription.Location = new System.Drawing.Point(107, 98);
            this.textBoxItemDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemDescription.Name = "textBoxItemDescription";
            this.textBoxItemDescription.Size = new System.Drawing.Size(121, 25);
            this.textBoxItemDescription.TabIndex = 13;
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Location = new System.Drawing.Point(107, 65);
            this.textBoxItemName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(121, 25);
            this.textBoxItemName.TabIndex = 15;
            // 
            // FormInventoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(387, 343);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxItemDescription);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxItemSellPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxItemAmount);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormInventoryAdd";
            this.Text = "FormSalesAdd";
            this.Load += new System.EventHandler(this.FormSalesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxItemAmount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxItemSellPrice;
        private DataSetIC dataSetIC;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private DataSetICTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxItemDescription;
        private System.Windows.Forms.TextBox textBoxItemName;
    }
}