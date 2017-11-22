#pragma warning disable 0618
namespace SupplyChainManagement_S1.UI.Manufaktur
{
    partial class Frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MLabel_Tanggal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MLabel_Jam = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grid_Produksi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cmb_Produksi_Sort_Order = new MetroFramework.Controls.MetroComboBox();
            this.Cmb_Produksi_Sort_By = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cmb_Filter_Produksi = new MetroFramework.Controls.MetroComboBox();
            this.Tmr_RefreshDT = new System.Windows.Forms.Timer(this.components);
            this.MTile_SPBahanBaku = new MetroFramework.Controls.MetroTile();
            this.MTile_Distributor = new MetroFramework.Controls.MetroTile();
            this.MTile_JadwalProduksi = new MetroFramework.Controls.MetroTile();
            this.MTile_Produksi = new MetroFramework.Controls.MetroTile();
            this.MTile_Supplier = new MetroFramework.Controls.MetroTile();
            this.Tmr_Refresh_data = new System.Windows.Forms.Timer(this.components);
            this.Btn_Logout = new MetroFramework.Controls.MetroButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Cmb_Supplier_Sort_Columns = new System.Windows.Forms.GroupBox();
            this.Cmb_Supplier_Sort_By = new MetroFramework.Controls.MetroComboBox();
            this.Cmb_Supplier_Sort_Order = new MetroFramework.Controls.MetroComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Cmb_Filter_Supplier = new MetroFramework.Controls.MetroComboBox();
            this.Grid_Supplier = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produksi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.Cmb_Supplier_Sort_Columns.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.MLabel_Tanggal);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.MLabel_Jam);
            this.groupBox1.Location = new System.Drawing.Point(17, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi";
            // 
            // MLabel_Tanggal
            // 
            this.MLabel_Tanggal.AutoSize = true;
            this.MLabel_Tanggal.Location = new System.Drawing.Point(80, 50);
            this.MLabel_Tanggal.Name = "MLabel_Tanggal";
            this.MLabel_Tanggal.Size = new System.Drawing.Size(167, 19);
            this.MLabel_Tanggal.TabIndex = 5;
            this.MLabel_Tanggal.Text = "Minggu, 31 Desember 2017";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(13, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tanggal :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(34, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Jam :";
            // 
            // MLabel_Jam
            // 
            this.MLabel_Jam.AutoSize = true;
            this.MLabel_Jam.Location = new System.Drawing.Point(80, 31);
            this.MLabel_Jam.Name = "MLabel_Jam";
            this.MLabel_Jam.Size = new System.Drawing.Size(48, 19);
            this.MLabel_Jam.TabIndex = 2;
            this.MLabel_Jam.Text = "00 : 00";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.Grid_Produksi);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(281, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 312);
            this.groupBox2.TabIndex = 5;
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
            // Tmr_RefreshDT
            // 
            this.Tmr_RefreshDT.Tick += new System.EventHandler(this.Tmr_RefreshDT_Tick);
            // 
            // MTile_SPBahanBaku
            // 
            this.MTile_SPBahanBaku.ActiveControl = null;
            this.MTile_SPBahanBaku.AutoSize = true;
            this.MTile_SPBahanBaku.Location = new System.Drawing.Point(17, 167);
            this.MTile_SPBahanBaku.Name = "MTile_SPBahanBaku";
            this.MTile_SPBahanBaku.Size = new System.Drawing.Size(258, 98);
            this.MTile_SPBahanBaku.Style = MetroFramework.MetroColorStyle.Lime;
            this.MTile_SPBahanBaku.TabIndex = 6;
            this.MTile_SPBahanBaku.Text = "Surat Pesan Bahan Baku";
            this.MTile_SPBahanBaku.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_SPBahanBaku.TileCount = 9999;
            this.MTile_SPBahanBaku.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_shopping;
            this.MTile_SPBahanBaku.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_SPBahanBaku.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_SPBahanBaku.UseSelectable = true;
            this.MTile_SPBahanBaku.UseTileImage = true;
            this.MTile_SPBahanBaku.Click += new System.EventHandler(this.MTile_Barang_Click);
            // 
            // MTile_Distributor
            // 
            this.MTile_Distributor.ActiveControl = null;
            this.MTile_Distributor.AutoSize = true;
            this.MTile_Distributor.Location = new System.Drawing.Point(17, 583);
            this.MTile_Distributor.Name = "MTile_Distributor";
            this.MTile_Distributor.Size = new System.Drawing.Size(258, 98);
            this.MTile_Distributor.Style = MetroFramework.MetroColorStyle.Orange;
            this.MTile_Distributor.TabIndex = 4;
            this.MTile_Distributor.Text = "Distributor";
            this.MTile_Distributor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Distributor.TileCount = 9999;
            this.MTile_Distributor.TileImage = ((System.Drawing.Image)(resources.GetObject("MTile_Distributor.TileImage")));
            this.MTile_Distributor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Distributor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Distributor.UseSelectable = true;
            this.MTile_Distributor.UseTileImage = true;
            // 
            // MTile_JadwalProduksi
            // 
            this.MTile_JadwalProduksi.ActiveControl = null;
            this.MTile_JadwalProduksi.AutoSize = true;
            this.MTile_JadwalProduksi.Location = new System.Drawing.Point(17, 479);
            this.MTile_JadwalProduksi.Name = "MTile_JadwalProduksi";
            this.MTile_JadwalProduksi.Size = new System.Drawing.Size(258, 98);
            this.MTile_JadwalProduksi.Style = MetroFramework.MetroColorStyle.Green;
            this.MTile_JadwalProduksi.TabIndex = 3;
            this.MTile_JadwalProduksi.Text = "Jadwal Produksi";
            this.MTile_JadwalProduksi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_JadwalProduksi.TileCount = 9999;
            this.MTile_JadwalProduksi.TileImage = ((System.Drawing.Image)(resources.GetObject("MTile_JadwalProduksi.TileImage")));
            this.MTile_JadwalProduksi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_JadwalProduksi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_JadwalProduksi.UseSelectable = true;
            this.MTile_JadwalProduksi.UseTileImage = true;
            // 
            // MTile_Produksi
            // 
            this.MTile_Produksi.ActiveControl = null;
            this.MTile_Produksi.AutoSize = true;
            this.MTile_Produksi.Location = new System.Drawing.Point(17, 375);
            this.MTile_Produksi.Name = "MTile_Produksi";
            this.MTile_Produksi.Size = new System.Drawing.Size(258, 98);
            this.MTile_Produksi.Style = MetroFramework.MetroColorStyle.Silver;
            this.MTile_Produksi.TabIndex = 1;
            this.MTile_Produksi.Text = "Produksi";
            this.MTile_Produksi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Produksi.TileCount = 9999;
            this.MTile_Produksi.TileImage = ((System.Drawing.Image)(resources.GetObject("MTile_Produksi.TileImage")));
            this.MTile_Produksi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Produksi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Produksi.UseSelectable = true;
            this.MTile_Produksi.UseTileImage = true;
            // 
            // MTile_Supplier
            // 
            this.MTile_Supplier.ActiveControl = null;
            this.MTile_Supplier.AutoSize = true;
            this.MTile_Supplier.Location = new System.Drawing.Point(17, 271);
            this.MTile_Supplier.Name = "MTile_Supplier";
            this.MTile_Supplier.Size = new System.Drawing.Size(258, 98);
            this.MTile_Supplier.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTile_Supplier.TabIndex = 0;
            this.MTile_Supplier.Text = "Supplier";
            this.MTile_Supplier.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Supplier.TileCount = 9999;
            this.MTile_Supplier.TileImage = ((System.Drawing.Image)(resources.GetObject("MTile_Supplier.TileImage")));
            this.MTile_Supplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Supplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Supplier.UseSelectable = true;
            this.MTile_Supplier.UseTileImage = true;
            // 
            // Tmr_Refresh_data
            // 
            this.Tmr_Refresh_data.Tick += new System.EventHandler(this.Tmr_Refresh_data_Tick);
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Location = new System.Drawing.Point(17, 687);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(258, 33);
            this.Btn_Logout.TabIndex = 15;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseSelectable = true;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.Cmb_Supplier_Sort_Columns);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.Grid_Supplier);
            this.groupBox6.Location = new System.Drawing.Point(281, 375);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(707, 345);
            this.groupBox6.TabIndex = 16;
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
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 735);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.MTile_SPBahanBaku);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MTile_Distributor);
            this.Controls.Add(this.MTile_JadwalProduksi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTile_Produksi);
            this.Controls.Add(this.MTile_Supplier);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Frm_Dashboard";
            this.Resizable = false;
            this.Text = "Dashboard Manufaktur";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produksi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.Cmb_Supplier_Sort_Columns.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile MTile_Supplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel MLabel_Jam;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel MLabel_Tanggal;
        private MetroFramework.Controls.MetroTile MTile_Distributor;
        private MetroFramework.Controls.MetroTile MTile_JadwalProduksi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer Tmr_RefreshDT;
        private System.Windows.Forms.DataGridView Grid_Produksi;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox Cmb_Produksi_Sort_Order;
        private MetroFramework.Controls.MetroComboBox Cmb_Produksi_Sort_By;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTile MTile_SPBahanBaku;
        private System.Windows.Forms.Timer Tmr_Refresh_data;
        private MetroFramework.Controls.MetroTile MTile_Produksi;
        private MetroFramework.Controls.MetroButton Btn_Logout;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Produksi;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox Cmb_Supplier_Sort_Columns;
        private MetroFramework.Controls.MetroComboBox Cmb_Supplier_Sort_By;
        private MetroFramework.Controls.MetroComboBox Cmb_Supplier_Sort_Order;
        private System.Windows.Forms.GroupBox groupBox8;
        private MetroFramework.Controls.MetroComboBox Cmb_Filter_Supplier;
        private System.Windows.Forms.DataGridView Grid_Supplier;
    }
}
#pragma warning restore 0618