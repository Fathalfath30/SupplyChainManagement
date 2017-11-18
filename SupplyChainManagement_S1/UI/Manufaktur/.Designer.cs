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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MLabel_Tanggal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.MLabel_Jam = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gview_Main = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Tmr_RefreshDT = new System.Windows.Forms.Timer(this.components);
            this.MTile_Barang = new MetroFramework.Controls.MetroTile();
            this.MTile_Distributor = new MetroFramework.Controls.MetroTile();
            this.MTile_SPBahanBaku = new MetroFramework.Controls.MetroTile();
            this.MTile_BarangJadi = new MetroFramework.Controls.MetroTile();
            this.MTile_Supplier = new MetroFramework.Controls.MetroTile();
            this.Tmr_Refresh_data = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gview_Main)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.Gview_Main);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(281, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 327);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barang Produksi Siap Dikirim";
            // 
            // Gview_Main
            // 
            this.Gview_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gview_Main.Location = new System.Drawing.Point(13, 93);
            this.Gview_Main.Name = "Gview_Main";
            this.Gview_Main.Size = new System.Drawing.Size(681, 215);
            this.Gview_Main.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.metroComboBox2);
            this.groupBox4.Controls.Add(this.metroComboBox1);
            this.groupBox4.Location = new System.Drawing.Point(269, 18);
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
            this.metroComboBox2.Location = new System.Drawing.Point(310, 20);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(105, 29);
            this.metroComboBox2.TabIndex = 1;
            this.metroComboBox2.UseSelectable = true;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(10, 20);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(294, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.metroTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 18);
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
            this.metroTextBox1.Location = new System.Drawing.Point(17, 20);
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
            // Tmr_RefreshDT
            // 
            this.Tmr_RefreshDT.Tick += new System.EventHandler(this.Tmr_RefreshDT_Tick);
            // 
            // MTile_Barang
            // 
            this.MTile_Barang.ActiveControl = null;
            this.MTile_Barang.AutoSize = true;
            this.MTile_Barang.Location = new System.Drawing.Point(17, 167);
            this.MTile_Barang.Name = "MTile_Barang";
            this.MTile_Barang.Size = new System.Drawing.Size(258, 98);
            this.MTile_Barang.Style = MetroFramework.MetroColorStyle.Lime;
            this.MTile_Barang.TabIndex = 6;
            this.MTile_Barang.Text = "Barang";
            this.MTile_Barang.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_Barang.TileCount = 9999;
            this.MTile_Barang.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_goods;
            this.MTile_Barang.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Barang.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Barang.UseSelectable = true;
            this.MTile_Barang.UseTileImage = true;
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
            this.MTile_Distributor.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_truck;
            this.MTile_Distributor.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Distributor.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Distributor.UseSelectable = true;
            this.MTile_Distributor.UseTileImage = true;
            // 
            // MTile_SPBahanBaku
            // 
            this.MTile_SPBahanBaku.ActiveControl = null;
            this.MTile_SPBahanBaku.AutoSize = true;
            this.MTile_SPBahanBaku.Location = new System.Drawing.Point(17, 479);
            this.MTile_SPBahanBaku.Name = "MTile_SPBahanBaku";
            this.MTile_SPBahanBaku.Size = new System.Drawing.Size(258, 98);
            this.MTile_SPBahanBaku.Style = MetroFramework.MetroColorStyle.Green;
            this.MTile_SPBahanBaku.TabIndex = 3;
            this.MTile_SPBahanBaku.Text = "Jadwal Produksi";
            this.MTile_SPBahanBaku.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_SPBahanBaku.TileCount = 9999;
            this.MTile_SPBahanBaku.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_calendar;
            this.MTile_SPBahanBaku.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_SPBahanBaku.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_SPBahanBaku.UseSelectable = true;
            this.MTile_SPBahanBaku.UseTileImage = true;
            // 
            // MTile_BarangJadi
            // 
            this.MTile_BarangJadi.ActiveControl = null;
            this.MTile_BarangJadi.AutoSize = true;
            this.MTile_BarangJadi.Location = new System.Drawing.Point(17, 375);
            this.MTile_BarangJadi.Name = "MTile_BarangJadi";
            this.MTile_BarangJadi.Size = new System.Drawing.Size(258, 98);
            this.MTile_BarangJadi.Style = MetroFramework.MetroColorStyle.Silver;
            this.MTile_BarangJadi.TabIndex = 1;
            this.MTile_BarangJadi.Text = "Barang Jadi";
            this.MTile_BarangJadi.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MTile_BarangJadi.TileCount = 9999;
            this.MTile_BarangJadi.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_product;
            this.MTile_BarangJadi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_BarangJadi.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_BarangJadi.UseSelectable = true;
            this.MTile_BarangJadi.UseTileImage = true;
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
            this.MTile_Supplier.TileImage = global::SupplyChainManagement_S1.Properties.Resources.icon_supplier;
            this.MTile_Supplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.MTile_Supplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.MTile_Supplier.UseSelectable = true;
            this.MTile_Supplier.UseTileImage = true;
            // 
            // Tmr_Refresh_data
            // 
            this.Tmr_Refresh_data.Tick += new System.EventHandler(this.Tmr_Refresh_data_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(281, 393);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(707, 327);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Supplier Dengan Harga Termurah";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 215);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.metroComboBox3);
            this.groupBox6.Controls.Add(this.metroComboBox4);
            this.groupBox6.Location = new System.Drawing.Point(270, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(425, 69);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Urutkan Berdasarkan :";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(310, 20);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(105, 29);
            this.metroComboBox3.TabIndex = 1;
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.ItemHeight = 23;
            this.metroComboBox4.Location = new System.Drawing.Point(10, 20);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(294, 29);
            this.metroComboBox4.TabIndex = 0;
            this.metroComboBox4.UseSelectable = true;
            // 
            // groupBox7
            // 
            this.groupBox7.AutoSize = true;
            this.groupBox7.Controls.Add(this.metroTextBox2);
            this.groupBox7.Location = new System.Drawing.Point(12, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(252, 69);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Keyword :";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(17, 20);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Masukan keyword";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(218, 29);
            this.metroTextBox2.TabIndex = 0;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Masukan keyword";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 687);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(258, 33);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Logout";
            this.metroButton1.UseSelectable = true;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 735);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MTile_Barang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MTile_Distributor);
            this.Controls.Add(this.MTile_SPBahanBaku);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MTile_BarangJadi);
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
            ((System.ComponentModel.ISupportInitialize)(this.Gview_Main)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTile MTile_SPBahanBaku;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer Tmr_RefreshDT;
        private System.Windows.Forms.DataGridView Gview_Main;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTile MTile_Barang;
        private System.Windows.Forms.Timer Tmr_Refresh_data;
        private MetroFramework.Controls.MetroTile MTile_BarangJadi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
#pragma warning restore 0618