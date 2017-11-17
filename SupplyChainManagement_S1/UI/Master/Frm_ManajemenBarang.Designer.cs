namespace SupplyChainManagement_S1.UI.Master
{
    partial class Frm_ManajemenBarang
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
            this.Gview_Main = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Keyword = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Cmb_TipeBarang = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Txt_MaxStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Txt_MinStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Txt_NmBarang = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Txt_KodeBarang = new MetroFramework.Controls.MetroTextBox();
            this.BtnSimpan = new MetroFramework.Controls.MetroButton();
            this.BtnUpdate = new MetroFramework.Controls.MetroButton();
            this.BtnHapus = new MetroFramework.Controls.MetroButton();
            this.BtnRefresh = new MetroFramework.Controls.MetroButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gview_Main)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.Gview_Main);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(294, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 393);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Barang";
            // 
            // Gview_Main
            // 
            this.Gview_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gview_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gview_Main.Location = new System.Drawing.Point(6, 83);
            this.Gview_Main.Name = "Gview_Main";
            this.Gview_Main.Size = new System.Drawing.Size(649, 291);
            this.Gview_Main.TabIndex = 11;
            this.Gview_Main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gview_Main_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.Txt_Keyword);
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(649, 62);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keyword :";
            // 
            // Txt_Keyword
            // 
            // 
            // 
            // 
            this.Txt_Keyword.CustomButton.Image = null;
            this.Txt_Keyword.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.Txt_Keyword.CustomButton.Name = "";
            this.Txt_Keyword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Keyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Keyword.CustomButton.TabIndex = 1;
            this.Txt_Keyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Keyword.CustomButton.UseSelectable = true;
            this.Txt_Keyword.CustomButton.Visible = false;
            this.Txt_Keyword.Lines = new string[0];
            this.Txt_Keyword.Location = new System.Drawing.Point(17, 20);
            this.Txt_Keyword.MaxLength = 32767;
            this.Txt_Keyword.Name = "Txt_Keyword";
            this.Txt_Keyword.PasswordChar = '\0';
            this.Txt_Keyword.PromptText = "Masukan keyword";
            this.Txt_Keyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Keyword.SelectedText = "";
            this.Txt_Keyword.SelectionLength = 0;
            this.Txt_Keyword.SelectionStart = 0;
            this.Txt_Keyword.ShortcutsEnabled = true;
            this.Txt_Keyword.Size = new System.Drawing.Size(206, 23);
            this.Txt_Keyword.TabIndex = 0;
            this.Txt_Keyword.UseSelectable = true;
            this.Txt_Keyword.WaterMark = "Masukan keyword";
            this.Txt_Keyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Keyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Keyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Keyword_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.Cmb_TipeBarang);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.Txt_MaxStock);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.Txt_MinStock);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.Txt_NmBarang);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.Txt_KodeBarang);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 291);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Entry Barang";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(15, 221);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(87, 19);
            this.metroLabel7.TabIndex = 11;
            this.metroLabel7.Text = "Tipe Barang :";
            // 
            // Cmb_TipeBarang
            // 
            this.Cmb_TipeBarang.FormattingEnabled = true;
            this.Cmb_TipeBarang.ItemHeight = 23;
            this.Cmb_TipeBarang.Location = new System.Drawing.Point(15, 243);
            this.Cmb_TipeBarang.Name = "Cmb_TipeBarang";
            this.Cmb_TipeBarang.Size = new System.Drawing.Size(244, 29);
            this.Cmb_TipeBarang.Sorted = true;
            this.Cmb_TipeBarang.TabIndex = 2;
            this.Cmb_TipeBarang.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(170, 197);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(29, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Ton";
            // 
            // Txt_MaxStock
            // 
            // 
            // 
            // 
            this.Txt_MaxStock.CustomButton.Image = null;
            this.Txt_MaxStock.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.Txt_MaxStock.CustomButton.Name = "";
            this.Txt_MaxStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_MaxStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_MaxStock.CustomButton.TabIndex = 1;
            this.Txt_MaxStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_MaxStock.CustomButton.UseSelectable = true;
            this.Txt_MaxStock.CustomButton.Visible = false;
            this.Txt_MaxStock.Lines = new string[0];
            this.Txt_MaxStock.Location = new System.Drawing.Point(15, 195);
            this.Txt_MaxStock.MaxLength = 32767;
            this.Txt_MaxStock.Name = "Txt_MaxStock";
            this.Txt_MaxStock.PasswordChar = '\0';
            this.Txt_MaxStock.PromptText = "Min Stock Dalam Gudang";
            this.Txt_MaxStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_MaxStock.SelectedText = "";
            this.Txt_MaxStock.SelectionLength = 0;
            this.Txt_MaxStock.SelectionStart = 0;
            this.Txt_MaxStock.ShortcutsEnabled = true;
            this.Txt_MaxStock.Size = new System.Drawing.Size(149, 23);
            this.Txt_MaxStock.TabIndex = 9;
            this.Txt_MaxStock.UseSelectable = true;
            this.Txt_MaxStock.WaterMark = "Min Stock Dalam Gudang";
            this.Txt_MaxStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_MaxStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(170, 149);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(29, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Ton";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(14, 173);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(101, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Stock Maximal :";
            // 
            // Txt_MinStock
            // 
            // 
            // 
            // 
            this.Txt_MinStock.CustomButton.Image = null;
            this.Txt_MinStock.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.Txt_MinStock.CustomButton.Name = "";
            this.Txt_MinStock.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_MinStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_MinStock.CustomButton.TabIndex = 1;
            this.Txt_MinStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_MinStock.CustomButton.UseSelectable = true;
            this.Txt_MinStock.CustomButton.Visible = false;
            this.Txt_MinStock.Lines = new string[0];
            this.Txt_MinStock.Location = new System.Drawing.Point(15, 147);
            this.Txt_MinStock.MaxLength = 32767;
            this.Txt_MinStock.Name = "Txt_MinStock";
            this.Txt_MinStock.PasswordChar = '\0';
            this.Txt_MinStock.PromptText = "Min Stock Dalam Gudang";
            this.Txt_MinStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_MinStock.SelectedText = "";
            this.Txt_MinStock.SelectionLength = 0;
            this.Txt_MinStock.SelectionStart = 0;
            this.Txt_MinStock.ShortcutsEnabled = true;
            this.Txt_MinStock.Size = new System.Drawing.Size(149, 23);
            this.Txt_MinStock.TabIndex = 5;
            this.Txt_MinStock.UseSelectable = true;
            this.Txt_MinStock.WaterMark = "Min Stock Dalam Gudang";
            this.Txt_MinStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_MinStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 125);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Stock Minimal :";
            // 
            // Txt_NmBarang
            // 
            // 
            // 
            // 
            this.Txt_NmBarang.CustomButton.Image = null;
            this.Txt_NmBarang.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.Txt_NmBarang.CustomButton.Name = "";
            this.Txt_NmBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_NmBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_NmBarang.CustomButton.TabIndex = 1;
            this.Txt_NmBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_NmBarang.CustomButton.UseSelectable = true;
            this.Txt_NmBarang.CustomButton.Visible = false;
            this.Txt_NmBarang.Lines = new string[0];
            this.Txt_NmBarang.Location = new System.Drawing.Point(15, 99);
            this.Txt_NmBarang.MaxLength = 32767;
            this.Txt_NmBarang.Name = "Txt_NmBarang";
            this.Txt_NmBarang.PasswordChar = '\0';
            this.Txt_NmBarang.PromptText = "Nama Barang";
            this.Txt_NmBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_NmBarang.SelectedText = "";
            this.Txt_NmBarang.SelectionLength = 0;
            this.Txt_NmBarang.SelectionStart = 0;
            this.Txt_NmBarang.ShortcutsEnabled = true;
            this.Txt_NmBarang.Size = new System.Drawing.Size(244, 23);
            this.Txt_NmBarang.TabIndex = 3;
            this.Txt_NmBarang.UseSelectable = true;
            this.Txt_NmBarang.WaterMark = "Nama Barang";
            this.Txt_NmBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_NmBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nama Barang";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kode Barang :";
            // 
            // Txt_KodeBarang
            // 
            // 
            // 
            // 
            this.Txt_KodeBarang.CustomButton.Image = null;
            this.Txt_KodeBarang.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.Txt_KodeBarang.CustomButton.Name = "";
            this.Txt_KodeBarang.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_KodeBarang.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_KodeBarang.CustomButton.TabIndex = 1;
            this.Txt_KodeBarang.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_KodeBarang.CustomButton.UseSelectable = true;
            this.Txt_KodeBarang.CustomButton.Visible = false;
            this.Txt_KodeBarang.Lines = new string[0];
            this.Txt_KodeBarang.Location = new System.Drawing.Point(15, 51);
            this.Txt_KodeBarang.MaxLength = 32767;
            this.Txt_KodeBarang.Name = "Txt_KodeBarang";
            this.Txt_KodeBarang.PasswordChar = '\0';
            this.Txt_KodeBarang.PromptText = "Kode Barang";
            this.Txt_KodeBarang.ReadOnly = true;
            this.Txt_KodeBarang.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_KodeBarang.SelectedText = "";
            this.Txt_KodeBarang.SelectionLength = 0;
            this.Txt_KodeBarang.SelectionStart = 0;
            this.Txt_KodeBarang.ShortcutsEnabled = true;
            this.Txt_KodeBarang.Size = new System.Drawing.Size(244, 23);
            this.Txt_KodeBarang.TabIndex = 0;
            this.Txt_KodeBarang.UseSelectable = true;
            this.Txt_KodeBarang.WaterMark = "Kode Barang";
            this.Txt_KodeBarang.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_KodeBarang.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(23, 360);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(265, 38);
            this.BtnSimpan.TabIndex = 14;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseSelectable = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(23, 404);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(265, 23);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseSelectable = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(23, 433);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(131, 23);
            this.BtnHapus.TabIndex = 16;
            this.BtnHapus.Text = "Hapus";
            this.BtnHapus.UseSelectable = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(157, 433);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(131, 23);
            this.BtnRefresh.TabIndex = 17;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseSelectable = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Frm_ManajemenBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 475);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_ManajemenBarang";
            this.Text = "Manajemen Barang";
            this.Load += new System.EventHandler(this.ManajemenBarang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gview_Main)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Gview_Main;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroTextBox Txt_Keyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox Txt_KodeBarang;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox Txt_MinStock;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox Txt_NmBarang;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox Txt_MaxStock;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox Cmb_TipeBarang;
        private MetroFramework.Controls.MetroButton BtnSimpan;
        private MetroFramework.Controls.MetroButton BtnUpdate;
        private MetroFramework.Controls.MetroButton BtnHapus;
        private MetroFramework.Controls.MetroButton BtnRefresh;
    }
}