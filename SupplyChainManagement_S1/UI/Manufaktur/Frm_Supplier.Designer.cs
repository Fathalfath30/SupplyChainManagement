namespace SupplyChainManagement_S1.UI.Manufaktur
{
    partial class Frm_Supplier
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Cmb_Supplier_Sort_Columns = new System.Windows.Forms.GroupBox();
            this.Cmb_Supplier_Sort_By = new MetroFramework.Controls.MetroComboBox();
            this.Cmb_Supplier_Sort_Order = new MetroFramework.Controls.MetroComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Cmb_Filter_Supplier = new MetroFramework.Controls.MetroComboBox();
            this.Grid_Supplier = new System.Windows.Forms.DataGridView();
            this.groupBox6.SuspendLayout();
            this.Cmb_Supplier_Sort_Columns.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.Cmb_Supplier_Sort_Columns);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.Grid_Supplier);
            this.groupBox6.Location = new System.Drawing.Point(23, 63);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(707, 345);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Supplier";
            // 
            // Cmb_Supplier_Sort_Columns
            // 
            this.Cmb_Supplier_Sort_Columns.AutoSize = true;
            this.Cmb_Supplier_Sort_Columns.Controls.Add(this.Cmb_Supplier_Sort_By);
            this.Cmb_Supplier_Sort_Columns.Controls.Add(this.Cmb_Supplier_Sort_Order);
            this.Cmb_Supplier_Sort_Columns.Location = new System.Drawing.Point(290, 22);
            this.Cmb_Supplier_Sort_Columns.Name = "Cmb_Supplier_Sort_Columns";
            this.Cmb_Supplier_Sort_Columns.Size = new System.Drawing.Size(406, 69);
            this.Cmb_Supplier_Sort_Columns.TabIndex = 14;
            this.Cmb_Supplier_Sort_Columns.TabStop = false;
            this.Cmb_Supplier_Sort_Columns.Text = "Filter Supplier";
            this.Cmb_Supplier_Sort_Columns.Visible = false;
            // 
            // Cmb_Supplier_Sort_By
            // 
            this.Cmb_Supplier_Sort_By.FormattingEnabled = true;
            this.Cmb_Supplier_Sort_By.ItemHeight = 23;
            this.Cmb_Supplier_Sort_By.Items.AddRange(new object[] {
            "Nama Supplier",
            "Nama Barang",
            "Harga Satuan",
            "Stock Tersedia"});
            this.Cmb_Supplier_Sort_By.Location = new System.Drawing.Point(11, 20);
            this.Cmb_Supplier_Sort_By.Name = "Cmb_Supplier_Sort_By";
            this.Cmb_Supplier_Sort_By.Size = new System.Drawing.Size(243, 29);
            this.Cmb_Supplier_Sort_By.TabIndex = 0;
            this.Cmb_Supplier_Sort_By.UseSelectable = true;
            // 
            // Cmb_Supplier_Sort_Order
            // 
            this.Cmb_Supplier_Sort_Order.FormattingEnabled = true;
            this.Cmb_Supplier_Sort_Order.ItemHeight = 23;
            this.Cmb_Supplier_Sort_Order.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.Cmb_Supplier_Sort_Order.Location = new System.Drawing.Point(260, 20);
            this.Cmb_Supplier_Sort_Order.Name = "Cmb_Supplier_Sort_Order";
            this.Cmb_Supplier_Sort_Order.Size = new System.Drawing.Size(121, 29);
            this.Cmb_Supplier_Sort_Order.TabIndex = 0;
            this.Cmb_Supplier_Sort_Order.UseSelectable = true;
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.Controls.Add(this.Cmb_Filter_Supplier);
            this.groupBox8.Location = new System.Drawing.Point(10, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(274, 69);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Filter Supplier";
            // 
            // Cmb_Filter_Supplier
            // 
            this.Cmb_Filter_Supplier.AutoCompleteCustomSource.AddRange(new string[] {
            "Tampilkan Semuanya",
            "Kedelai Hitam",
            "Garam",
            "Gula Merah",
            "Kemasan Botol",
            "Kemasan Plastik"});
            this.Cmb_Filter_Supplier.FormattingEnabled = true;
            this.Cmb_Filter_Supplier.ItemHeight = 23;
            this.Cmb_Filter_Supplier.Items.AddRange(new object[] {
            "Tampilkan Semuanya ",
            "Kedelai Hitam ",
            "Garam ",
            "Gula Merah ",
            "Kemasan Botol ",
            "Kemasan Plastik "});
            this.Cmb_Filter_Supplier.Location = new System.Drawing.Point(16, 20);
            this.Cmb_Filter_Supplier.Name = "Cmb_Filter_Supplier";
            this.Cmb_Filter_Supplier.Size = new System.Drawing.Size(243, 29);
            this.Cmb_Filter_Supplier.TabIndex = 0;
            this.Cmb_Filter_Supplier.UseSelectable = true;
            this.Cmb_Filter_Supplier.SelectedIndexChanged += new System.EventHandler(this.Cmb_Filter_Supplier_SelectedIndexChanged);
            // 
            // Grid_Supplier
            // 
            this.Grid_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Supplier.Location = new System.Drawing.Point(10, 96);
            this.Grid_Supplier.Name = "Grid_Supplier";
            this.Grid_Supplier.Size = new System.Drawing.Size(686, 227);
            this.Grid_Supplier.TabIndex = 11;
            this.Grid_Supplier.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.Grid_Supplier_SortCompare);
            // 
            // Frm_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 430);
            this.Controls.Add(this.groupBox6);
            this.MaximizeBox = false;
            this.Name = "Frm_Supplier";
            this.Resizable = false;
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Frm_Supplier_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Cmb_Supplier_Sort_Columns.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox Cmb_Supplier_Sort_Columns;
        private MetroFramework.Controls.MetroComboBox Cmb_Supplier_Sort_By;
        private MetroFramework.Controls.MetroComboBox Cmb_Supplier_Sort_Order;
        private System.Windows.Forms.GroupBox groupBox8;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Supplier;
        private System.Windows.Forms.DataGridView Grid_Supplier;
    }
}