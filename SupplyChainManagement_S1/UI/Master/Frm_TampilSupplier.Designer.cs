namespace SupplyChainManagement_S1.UI.Master
{
    partial class Frm_TampilSupplier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gview_Main = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Keyword = new MetroFramework.Controls.MetroTextBox();
            this.BtnTambah = new MetroFramework.Controls.MetroButton();
            this.BtnUpdate = new MetroFramework.Controls.MetroButton();
            this.BtnHapus = new MetroFramework.Controls.MetroButton();
            this.BtnKeluar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gview_Main)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gview_Main);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 383);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Supplier";
            // 
            // Gview_Main
            // 
            this.Gview_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gview_Main.Location = new System.Drawing.Point(6, 92);
            this.Gview_Main.Name = "Gview_Main";
            this.Gview_Main.Size = new System.Drawing.Size(923, 285);
            this.Gview_Main.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Keyword);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Data";
            // 
            // Txt_Keyword
            // 
            // 
            // 
            // 
            this.Txt_Keyword.CustomButton.Image = null;
            this.Txt_Keyword.CustomButton.Location = new System.Drawing.Point(295, 1);
            this.Txt_Keyword.CustomButton.Name = "";
            this.Txt_Keyword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Txt_Keyword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Txt_Keyword.CustomButton.TabIndex = 1;
            this.Txt_Keyword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Txt_Keyword.CustomButton.UseSelectable = true;
            this.Txt_Keyword.CustomButton.Visible = false;
            this.Txt_Keyword.Lines = new string[0];
            this.Txt_Keyword.Location = new System.Drawing.Point(11, 22);
            this.Txt_Keyword.MaxLength = 32767;
            this.Txt_Keyword.Name = "Txt_Keyword";
            this.Txt_Keyword.PasswordChar = '\0';
            this.Txt_Keyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Txt_Keyword.SelectedText = "";
            this.Txt_Keyword.SelectionLength = 0;
            this.Txt_Keyword.SelectionStart = 0;
            this.Txt_Keyword.ShortcutsEnabled = true;
            this.Txt_Keyword.Size = new System.Drawing.Size(317, 23);
            this.Txt_Keyword.TabIndex = 1;
            this.Txt_Keyword.UseSelectable = true;
            this.Txt_Keyword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Keyword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Txt_Keyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Keyword_KeyUp);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Location = new System.Drawing.Point(23, 453);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(117, 35);
            this.BtnTambah.TabIndex = 3;
            this.BtnTambah.Text = "Tambah Data";
            this.BtnTambah.UseSelectable = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(146, 453);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(117, 35);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update Data";
            this.BtnUpdate.UseSelectable = true;
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(269, 453);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(117, 35);
            this.BtnHapus.TabIndex = 5;
            this.BtnHapus.Text = "Hapus Data";
            this.BtnHapus.UseSelectable = true;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Location = new System.Drawing.Point(835, 453);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(117, 35);
            this.BtnKeluar.TabIndex = 6;
            this.BtnKeluar.Text = "Keluar";
            this.BtnKeluar.UseSelectable = true;
            // 
            // Frm_TampilSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 511);
            this.Controls.Add(this.BtnKeluar);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnTambah);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_TampilSupplier";
            this.Resizable = false;
            this.Text = "Frm_ManajemenSupplier";
            this.Load += new System.EventHandler(this.Frm_ManajemenSupplier_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gview_Main)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Gview_Main;
        private MetroFramework.Controls.MetroButton BtnTambah;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox Txt_Keyword;
        private MetroFramework.Controls.MetroButton BtnUpdate;
        private MetroFramework.Controls.MetroButton BtnHapus;
        private MetroFramework.Controls.MetroButton BtnKeluar;
    }
}