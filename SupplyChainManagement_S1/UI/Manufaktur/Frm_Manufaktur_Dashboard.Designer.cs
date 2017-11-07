namespace SupplyChainManagement_S1.UI.Manufaktur
{
    partial class Frm_Manufaktur_Dashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MLabel_Tanggal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MLabel_Jam = new MetroFramework.Controls.MetroLabel();
            this.MLabel_Status_koneksi = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tmr_Refresh_koneksi = new System.Windows.Forms.Timer(this.components);
            this.Tmr_RefreshDT = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.MTile_Barang = new MetroFramework.Controls.MetroTile();
            this.MTile_Distributor = new MetroFramework.Controls.MetroTile();
            this.MTile_Pembelian = new MetroFramework.Controls.MetroTile();
            this.MTile_Stock = new MetroFramework.Controls.MetroTile();
            this.MTile_Supplier = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.MLabel_Tanggal);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.MLabel_Jam);
            this.groupBox1.Controls.Add(this.MLabel_Status_koneksi);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi";
            // 
            // MLabel_Tanggal
            // 
            this.MLabel_Tanggal.AutoSize = true;
            this.MLabel_Tanggal.Location = new System.Drawing.Point(85, 47);
            this.MLabel_Tanggal.Name = "MLabel_Tanggal";
            this.MLabel_Tanggal.Size = new System.Drawing.Size(167, 19);
            this.MLabel_Tanggal.TabIndex = 5;
            this.MLabel_Tanggal.Text = "Minggu, 31 Desember 2017";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 47);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Tanggal :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(39, 28);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Jam :";
            // 
            // MLabel_Jam
            // 
            this.MLabel_Jam.AutoSize = true;
            this.MLabel_Jam.Location = new System.Drawing.Point(85, 28);
            this.MLabel_Jam.Name = "MLabel_Jam";
            this.MLabel_Jam.Size = new System.Drawing.Size(48, 19);
            this.MLabel_Jam.TabIndex = 2;
            this.MLabel_Jam.Text = "00 : 00";
            // 
            // MLabel_Status_koneksi
            // 
            this.MLabel_Status_koneksi.AutoSize = true;
            this.MLabel_Status_koneksi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.MLabel_Status_koneksi.Location = new System.Drawing.Point(85, 66);
            this.MLabel_Status_koneksi.Name = "MLabel_Status_koneksi";
            this.MLabel_Status_koneksi.Size = new System.Drawing.Size(80, 19);
            this.MLabel_Status_koneksi.TabIndex = 1;
            this.MLabel_Status_koneksi.Text = "Terhubung";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Status :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(287, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 327);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Bahan Baku Terendah";
            // 
            // Tmr_Refresh_koneksi
            // 
            this.Tmr_Refresh_koneksi.Tick += new System.EventHandler(this.Tmr_Refresh_koneksi_Tick);
            // 
            // Tmr_RefreshDT
            // 
            this.Tmr_RefreshDT.Tick += new System.EventHandler(this.Tmr_RefreshDT_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 215);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.metroComboBox2);
            this.groupBox4.Controls.Add(this.metroComboBox1);
            this.groupBox4.Location = new System.Drawing.Point(264, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(425, 69);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Urutkan Berdasarkan :";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(306, 21);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(105, 29);
            this.metroComboBox2.TabIndex = 1;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(6, 21);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(294, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.metroTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 69);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keyword :";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(6, 21);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Masukan keyword";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(218, 29);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Masukan keyword";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MTile_Barang
            // 
            this.MTile_Barang.ActiveControl = null;
            this.MTile_Barang.AutoSize = true;
            this.MTile_Barang.Location = new System.Drawing.Point(23, 170);
            this.MTile_Barang.Name = "MTile_Barang";
            this.MTile_Barang.Size = new System.Drawing.Size(258, 98);
            this.MTile_Barang.Style = MetroFramework.MetroColorStyle.Lime;
            this.MTile_Barang.TabIndex = 6;
            this.MTile_Barang.Text = "Barang";
            this.MTile_Barang.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Barang.TileCount = 9999;
            this.MTile_Barang.TileImage = global::SupplyChainManagement_S1.Properties.Resources.goods;
            this.MTile_Barang.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Barang.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Barang.UseSelectable = true;
            this.MTile_Barang.UseTileImage = true;
            // 
            // MTile_Distributor
            // 
            this.MTile_Distributor.ActiveControl = null;
            this.MTile_Distributor.AutoSize = true;
            this.MTile_Distributor.Location = new System.Drawing.Point(23, 586);
            this.MTile_Distributor.Name = "MTile_Distributor";
            this.MTile_Distributor.Size = new System.Drawing.Size(258, 98);
            this.MTile_Distributor.Style = MetroFramework.MetroColorStyle.Orange;
            this.MTile_Distributor.TabIndex = 4;
            this.MTile_Distributor.Text = "Distributor";
            this.MTile_Distributor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Distributor.TileCount = 9999;
            this.MTile_Distributor.TileImage = global::SupplyChainManagement_S1.Properties.Resources.truck;
            this.MTile_Distributor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Distributor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Distributor.UseSelectable = true;
            this.MTile_Distributor.UseTileImage = true;
            // 
            // MTile_Pembelian
            // 
            this.MTile_Pembelian.ActiveControl = null;
            this.MTile_Pembelian.AutoSize = true;
            this.MTile_Pembelian.Location = new System.Drawing.Point(23, 482);
            this.MTile_Pembelian.Name = "MTile_Pembelian";
            this.MTile_Pembelian.Size = new System.Drawing.Size(258, 98);
            this.MTile_Pembelian.Style = MetroFramework.MetroColorStyle.Green;
            this.MTile_Pembelian.TabIndex = 3;
            this.MTile_Pembelian.Text = "Pembelian";
            this.MTile_Pembelian.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Pembelian.TileCount = 9999;
            this.MTile_Pembelian.TileImage = global::SupplyChainManagement_S1.Properties.Resources.po;
            this.MTile_Pembelian.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Pembelian.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Pembelian.UseSelectable = true;
            this.MTile_Pembelian.UseTileImage = true;
            // 
            // MTile_Stock
            // 
            this.MTile_Stock.ActiveControl = null;
            this.MTile_Stock.AutoSize = true;
            this.MTile_Stock.Location = new System.Drawing.Point(23, 378);
            this.MTile_Stock.Name = "MTile_Stock";
            this.MTile_Stock.Size = new System.Drawing.Size(258, 98);
            this.MTile_Stock.Style = MetroFramework.MetroColorStyle.Silver;
            this.MTile_Stock.TabIndex = 1;
            this.MTile_Stock.Text = "Stock";
            this.MTile_Stock.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Stock.TileCount = 9999;
            this.MTile_Stock.TileImage = global::SupplyChainManagement_S1.Properties.Resources.product;
            this.MTile_Stock.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Stock.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Stock.UseSelectable = true;
            this.MTile_Stock.UseTileImage = true;
            // 
            // MTile_Supplier
            // 
            this.MTile_Supplier.ActiveControl = null;
            this.MTile_Supplier.AutoSize = true;
            this.MTile_Supplier.Location = new System.Drawing.Point(23, 274);
            this.MTile_Supplier.Name = "MTile_Supplier";
            this.MTile_Supplier.Size = new System.Drawing.Size(258, 98);
            this.MTile_Supplier.Style = MetroFramework.MetroColorStyle.Blue;
            this.MTile_Supplier.TabIndex = 0;
            this.MTile_Supplier.Text = "Supplier";
            this.MTile_Supplier.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Supplier.TileCount = 9999;
            this.MTile_Supplier.TileImage = global::SupplyChainManagement_S1.Properties.Resources.supplier;
            this.MTile_Supplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Supplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Supplier.UseSelectable = true;
            this.MTile_Supplier.UseTileImage = true;
            // 
            // Frm_Manufaktur_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 709);
            this.Controls.Add(this.MTile_Barang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MTile_Distributor);
            this.Controls.Add(this.MTile_Pembelian);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTile_Stock);
            this.Controls.Add(this.MTile_Supplier);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Frm_Manufaktur_Dashboard";
            this.Resizable = false;
            this.Text = "Dashboard Manufaktur";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Manufaktur_Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Manufaktur_Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile MTile_Supplier;
        private MetroFramework.Controls.MetroTile MTile_Stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel MLabel_Status_koneksi;
        private MetroFramework.Controls.MetroLabel MLabel_Jam;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel MLabel_Tanggal;
        private MetroFramework.Controls.MetroTile MTile_Distributor;
        private MetroFramework.Controls.MetroTile MTile_Pembelian;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer Tmr_Refresh_koneksi;
        private System.Windows.Forms.Timer Tmr_RefreshDT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTile MTile_Barang;
    }
}