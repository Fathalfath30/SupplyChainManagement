using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using SupplyChainManagement_S1.MainClass;
using MySql.Data.MySqlClient;

namespace SupplyChainManagement_S1.UI.Master
{
    public partial class Frm_ManajemenSupplier : MetroForm
    {
        private Cls_Supplier CSupplier;

        /* ---------- [START] Method Utama ---------- */
        private void BindMainData(bool search = false)
        {
            if (search && Txt_Keyword.Text != "")
            {
                Gview_Main.DataSource = CSupplier.Cari_data(Txt_Keyword.Text);
            }
            else
            {
                Gview_Main.DataSource = CSupplier.Tampil_data();
            }
            Gview_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Gview_Main.ReadOnly = true;
            Gview_Main.AutoGenerateColumns = false;
            Gview_Main.AllowDrop = false;
            Gview_Main.AllowUserToAddRows = false;
            Gview_Main.AllowUserToDeleteRows = false;

            Gview_Main.Columns["KodeSupplier"].HeaderText = "Kode Barang";
            Gview_Main.Columns["KodeBarang"].HeaderText = "Nama Barang";
            Gview_Main.Columns["NamaSupplier"].HeaderText = "Tipe Barang";
            Gview_Main.Columns["NamaBarang"].HeaderText = "Stock Minimal";
            Gview_Main.Columns["StockTersedia"].HeaderText = "Stock Maximal";
            Gview_Main.Columns["HargaBarang"].HeaderText = "Harga Barang";
            Gview_Main.Columns["HargaBarang"].DefaultCellStyle.Format = "c";
            for (int i = 0; i < Gview_Main.Columns.Count - 1; i++)
                Gview_Main.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void RefreshForm()
        {

        }

        private void LockForm()
        {
            if (Properties.Settings.Default.S_LEVEL == "9")
                return;

            MessageBox.Show(
                this,
                "Perhatian : Hak anda terbatas, anda hanya dapat melihat data saja.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

        }
        /* ---------- [END] Method Utama ---------- */
        public Frm_ManajemenSupplier()
        {
            InitializeComponent();
            CSupplier = new Cls_Supplier();
        }

        private void Frm_ManajemenSupplier_Load(object sender, EventArgs e)
        {

        }
    }
}
