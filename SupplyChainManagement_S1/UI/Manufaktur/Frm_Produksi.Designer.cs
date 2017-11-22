namespace SupplyChainManagement_S1.UI.Manufaktur
{
    partial class Frm_Produksi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grid_Produksi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cmb_Produksi_Sort_Order = new MetroFramework.Controls.MetroComboBox();
            this.Cmb_Produksi_Sort_By = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cmb_Filter_Produksi = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produksi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.Grid_Produksi);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(24, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 312);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Produksi";
            // 
            // Grid_Produksi
            // 
            this.Grid_Produksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Produksi.Location = new System.Drawing.Point(13, 93);
            this.Grid_Produksi.Name = "Grid_Produksi";
            this.Grid_Produksi.Size = new System.Drawing.Size(681, 200);
            this.Grid_Produksi.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.Cmb_Produksi_Sort_Order);
            this.groupBox4.Controls.Add(this.Cmb_Produksi_Sort_By);
            this.groupBox4.Location = new System.Drawing.Point(269, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 69);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Urutkan Berdasarkan :";
            this.groupBox4.Visible = false;
            // 
            // Cmb_Produksi_Sort_Order
            // 
            this.Cmb_Produksi_Sort_Order.FormattingEnabled = true;
            this.Cmb_Produksi_Sort_Order.ItemHeight = 23;
            this.Cmb_Produksi_Sort_Order.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.Cmb_Produksi_Sort_Order.Location = new System.Drawing.Point(310, 20);
            this.Cmb_Produksi_Sort_Order.Name = "Cmb_Produksi_Sort_Order";
            this.Cmb_Produksi_Sort_Order.Size = new System.Drawing.Size(105, 29);
            this.Cmb_Produksi_Sort_Order.TabIndex = 0;
            this.Cmb_Produksi_Sort_Order.UseSelectable = true;
            // 
            // Cmb_Produksi_Sort_By
            // 
            this.Cmb_Produksi_Sort_By.FormattingEnabled = true;
            this.Cmb_Produksi_Sort_By.ItemHeight = 23;
            this.Cmb_Produksi_Sort_By.Items.AddRange(new object[] {
            "Kode Produksi",
            "Nama Manufaktur",
            "Nama Barang",
            "Tanggal Produksi ",
            "Jumlah Produksi"});
            this.Cmb_Produksi_Sort_By.Location = new System.Drawing.Point(10, 20);
            this.Cmb_Produksi_Sort_By.Name = "Cmb_Produksi_Sort_By";
            this.Cmb_Produksi_Sort_By.Size = new System.Drawing.Size(294, 29);
            this.Cmb_Produksi_Sort_By.TabIndex = 0;
            this.Cmb_Produksi_Sort_By.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.Cmb_Filter_Produksi);
            this.groupBox3.Location = new System.Drawing.Point(13, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 69);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter Produksi :";
            // 
            // Cmb_Filter_Produksi
            // 
            this.Cmb_Filter_Produksi.AutoCompleteCustomSource.AddRange(new string[] {
            "Bango BTL 135ML",
            "Bango BTL 275ML",
            "Bango BTL 620ML",
            "Bango RFL 600ML",
            "Bango RFL 220ML",
            "Bango RFL 85ML ",
            "Bango RFL 35ML"});
            this.Cmb_Filter_Produksi.FormattingEnabled = true;
            this.Cmb_Filter_Produksi.ItemHeight = 23;
            this.Cmb_Filter_Produksi.Items.AddRange(new object[] {
            "Tampilkan Semuanya",
            "Bango BTL 135ML",
            "Bango BTL 275ML",
            "Bango BTL 620ML",
            "Bango RFL 600ML",
            "Bango RFL 220ML",
            "Bango RFL 85ML ",
            "Bango RFL 35ML "});
            this.Cmb_Filter_Produksi.Location = new System.Drawing.Point(11, 20);
            this.Cmb_Filter_Produksi.Name = "Cmb_Filter_Produksi";
            this.Cmb_Filter_Produksi.Size = new System.Drawing.Size(231, 29);
            this.Cmb_Filter_Produksi.TabIndex = 1;
            this.Cmb_Filter_Produksi.UseSelectable = true;
            this.Cmb_Filter_Produksi.SelectedIndexChanged += new System.EventHandler(this.Cmb_Filter_Produksi_SelectedIndexChanged);
            // 
            // Frm_Produksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 398);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_Produksi";
            this.Text = "Hasil Produksi";
            this.Load += new System.EventHandler(this.Frm_Produksi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produksi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_Produksi;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox Cmb_Produksi_Sort_Order;
        private MetroFramework.Controls.MetroComboBox Cmb_Produksi_Sort_By;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Produksi;
    }
}