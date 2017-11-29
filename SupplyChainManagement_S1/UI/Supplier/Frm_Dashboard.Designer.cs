namespace SupplyChainManagement_S1.UI.Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            this.MTile_SPBahanBaku = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MLabel_Tanggal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MLabel_Jam = new MetroFramework.Controls.MetroLabel();
            this.MTile_Produksi = new MetroFramework.Controls.MetroTile();
            this.MTile_Distributor = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WebB_GMaps = new System.Windows.Forms.WebBrowser();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.Btn_Logout = new MetroFramework.Controls.MetroButton();
            this.Grid_SPBahanBaku = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SPBahanBaku)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // MTile_SPBahanBaku
            // 
            this.MTile_SPBahanBaku.ActiveControl = null;
            this.MTile_SPBahanBaku.AutoSize = true;
            this.MTile_SPBahanBaku.Location = new System.Drawing.Point(21, 170);
            this.MTile_SPBahanBaku.Name = "MTile_SPBahanBaku";
            this.MTile_SPBahanBaku.Size = new System.Drawing.Size(257, 90);
            this.MTile_SPBahanBaku.Style = MetroFramework.MetroColorStyle.Lime;
            this.MTile_SPBahanBaku.TabIndex = 23;
            this.MTile_SPBahanBaku.Text = "Jadwal Pengiriman";
            this.MTile_SPBahanBaku.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_SPBahanBaku.TileCount = 9999;
            this.MTile_SPBahanBaku.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_shopping;
            this.MTile_SPBahanBaku.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_SPBahanBaku.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_SPBahanBaku.UseSelectable = true;
            this.MTile_SPBahanBaku.UseTileImage = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.MLabel_Tanggal);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.MLabel_Jam);
            this.groupBox1.Location = new System.Drawing.Point(21, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 101);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi";
            // 
            // MLabel_Tanggal
            // 
            this.MLabel_Tanggal.AutoSize = true;
            this.MLabel_Tanggal.Location = new System.Drawing.Point(76, 50);
            this.MLabel_Tanggal.Name = "MLabel_Tanggal";
            this.MLabel_Tanggal.Size = new System.Drawing.Size(167, 19);
            this.MLabel_Tanggal.TabIndex = 5;
            this.MLabel_Tanggal.Text = "Minggu, 31 Desember 2017";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tanggal :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Jam :";
            // 
            // MLabel_Jam
            // 
            this.MLabel_Jam.AutoSize = true;
            this.MLabel_Jam.Location = new System.Drawing.Point(76, 31);
            this.MLabel_Jam.Name = "MLabel_Jam";
            this.MLabel_Jam.Size = new System.Drawing.Size(48, 19);
            this.MLabel_Jam.TabIndex = 2;
            this.MLabel_Jam.Text = "00 : 00";
            // 
            // MTile_Produksi
            // 
            this.MTile_Produksi.ActiveControl = null;
            this.MTile_Produksi.AutoSize = true;
            this.MTile_Produksi.Location = new System.Drawing.Point(21, 266);
            this.MTile_Produksi.Name = "MTile_Produksi";
            this.MTile_Produksi.Size = new System.Drawing.Size(257, 90);
            this.MTile_Produksi.Style = MetroFramework.MetroColorStyle.Silver;
            this.MTile_Produksi.TabIndex = 18;
            this.MTile_Produksi.Text = "Surat Pesan";
            this.MTile_Produksi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Produksi.TileCount = 9999;
            this.MTile_Produksi.TileImage = ((System.Drawing.Image)(resources.GetObject("MTile_Produksi.TileImage")));
            this.MTile_Produksi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Produksi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Produksi.UseSelectable = true;
            this.MTile_Produksi.UseTileImage = true;
            // 
            // MTile_Distributor
            // 
            this.MTile_Distributor.ActiveControl = null;
            this.MTile_Distributor.AutoSize = true;
            this.MTile_Distributor.Location = new System.Drawing.Point(21, 362);
            this.MTile_Distributor.Name = "MTile_Distributor";
            this.MTile_Distributor.Size = new System.Drawing.Size(257, 90);
            this.MTile_Distributor.Style = MetroFramework.MetroColorStyle.Orange;
            this.MTile_Distributor.TabIndex = 21;
            this.MTile_Distributor.Text = "Lacak Kiriman";
            this.MTile_Distributor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Distributor.TileCount = 9999;
            this.MTile_Distributor.TileImage = ((System.Drawing.Image)(resources.GetObject("MTile_Distributor.TileImage")));
            this.MTile_Distributor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Distributor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Distributor.UseSelectable = true;
            this.MTile_Distributor.UseTileImage = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.WebB_GMaps);
            this.groupBox2.Location = new System.Drawing.Point(284, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 246);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lokasi Pengiriman";
            // 
            // WebB_GMaps
            // 
            this.WebB_GMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebB_GMaps.Location = new System.Drawing.Point(3, 16);
            this.WebB_GMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebB_GMaps.Name = "WebB_GMaps";
            this.WebB_GMaps.Size = new System.Drawing.Size(692, 227);
            this.WebB_GMaps.TabIndex = 0;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.AutoSize = true;
            this.metroTile1.Location = new System.Drawing.Point(21, 458);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(257, 90);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 27;
            this.metroTile1.Text = "Lacak Kiriman";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTile1.TileCount = 9999;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // Btn_Logout
            // 
            this.Btn_Logout.Location = new System.Drawing.Point(20, 554);
            this.Btn_Logout.Name = "Btn_Logout";
            this.Btn_Logout.Size = new System.Drawing.Size(258, 33);
            this.Btn_Logout.TabIndex = 28;
            this.Btn_Logout.Text = "Logout";
            this.Btn_Logout.UseSelectable = true;
            // 
            // Grid_SPBahanBaku
            // 
            this.Grid_SPBahanBaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_SPBahanBaku.Location = new System.Drawing.Point(13, 26);
            this.Grid_SPBahanBaku.Name = "Grid_SPBahanBaku";
            this.Grid_SPBahanBaku.Size = new System.Drawing.Size(672, 229);
            this.Grid_SPBahanBaku.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.Grid_SPBahanBaku);
            this.groupBox6.Location = new System.Drawing.Point(284, 63);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(698, 281);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status Pesanan";
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 621);
            this.Controls.Add(this.Btn_Logout);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.MTile_SPBahanBaku);
            this.Controls.Add(this.MTile_Distributor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTile_Produksi);
            this.Name = "Frm_Dashboard";
            this.Text = "Dashboard Supplier";
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_SPBahanBaku)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile MTile_SPBahanBaku;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel MLabel_Tanggal;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel MLabel_Jam;
        private MetroFramework.Controls.MetroTile MTile_Produksi;
        private MetroFramework.Controls.MetroTile MTile_Distributor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser WebB_GMaps;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton Btn_Logout;
        private System.Windows.Forms.DataGridView Grid_SPBahanBaku;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}