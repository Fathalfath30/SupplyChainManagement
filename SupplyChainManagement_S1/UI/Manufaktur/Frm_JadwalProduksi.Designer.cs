namespace SupplyChainManagement_S1.UI.Manufaktur
{
    partial class Frm_JadwalProduksi
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
            this.Grid_JadwalProduksi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cmb_Filter_Tahun = new MetroFramework.Controls.MetroComboBox();
            this.Cmb_Filter_Bulan = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cmb_Filter_Produksi = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_JadwalProduksi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.Grid_JadwalProduksi);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(20, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 312);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Produksi";
            // 
            // Grid_JadwalProduksi
            // 
            this.Grid_JadwalProduksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_JadwalProduksi.Location = new System.Drawing.Point(13, 93);
            this.Grid_JadwalProduksi.Name = "Grid_JadwalProduksi";
            this.Grid_JadwalProduksi.Size = new System.Drawing.Size(681, 200);
            this.Grid_JadwalProduksi.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.Cmb_Filter_Tahun);
            this.groupBox4.Controls.Add(this.Cmb_Filter_Bulan);
            this.groupBox4.Location = new System.Drawing.Point(269, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 69);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter Bulan dan Tahun";
            // 
            // Cmb_Filter_Tahun
            // 
            this.Cmb_Filter_Tahun.FormattingEnabled = true;
            this.Cmb_Filter_Tahun.ItemHeight = 23;
            this.Cmb_Filter_Tahun.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.Cmb_Filter_Tahun.Location = new System.Drawing.Point(310, 20);
            this.Cmb_Filter_Tahun.Name = "Cmb_Filter_Tahun";
            this.Cmb_Filter_Tahun.Size = new System.Drawing.Size(105, 29);
            this.Cmb_Filter_Tahun.TabIndex = 0;
            this.Cmb_Filter_Tahun.UseSelectable = true;
            // 
            // Cmb_Filter_Bulan
            // 
            this.Cmb_Filter_Bulan.FormattingEnabled = true;
            this.Cmb_Filter_Bulan.ItemHeight = 23;
            this.Cmb_Filter_Bulan.Items.AddRange(new object[] {
            "Tampilkan Semua",
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.Cmb_Filter_Bulan.Location = new System.Drawing.Point(10, 20);
            this.Cmb_Filter_Bulan.Name = "Cmb_Filter_Bulan";
            this.Cmb_Filter_Bulan.Size = new System.Drawing.Size(294, 29);
            this.Cmb_Filter_Bulan.TabIndex = 0;
            this.Cmb_Filter_Bulan.UseSelectable = true;
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
            // 
            // Frm_JadwalProduksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 395);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Frm_JadwalProduksi";
            this.Resizable = false;
            this.Text = "Jadwal Produksi";
            this.Load += new System.EventHandler(this.Frm_JadwalProduksi_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_JadwalProduksi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Grid_JadwalProduksi;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Tahun;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Bulan;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Produksi;
    }
}