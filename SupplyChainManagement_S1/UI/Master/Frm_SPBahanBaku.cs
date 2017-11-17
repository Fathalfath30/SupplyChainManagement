using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using SupplyChainManagement_S1.MainClass;
using System.Globalization;
using SupplyChainManagement_S1.UI.Master;
using System.Threading;

namespace SupplyChainManagement_S1.UI.Master
{
    public partial class Frm_SPBahanBaku : MetroForm
    {
        App_Data AData = new App_Data();
        private void BindData()
        {
            Gview_Main.Rows.Clear();
            for (int i = 0; i < AData.Data_SpBahanBaku.GetLength(0); i++)
            {
                /*
             "SPM001", "SUP001", "Poktan Marsudi Tani", "12 November 2017", "Kedelai Hitam", "Rp. 10.000.000", "Rp. 76.000.000", "Sedang Proses"
             */
                Gview_Main.Rows.Add(
                    AData.Data_SpBahanBaku[i, 0],
                    AData.Data_SpBahanBaku[i, 1],
                    AData.Data_SpBahanBaku[i, 2],
                    AData.Data_SpBahanBaku[i, 3],
                    AData.Data_SpBahanBaku[i, 4],
                    AData.Data_SpBahanBaku[i, 5],
                    AData.Data_SpBahanBaku[i, 6],
                    AData.Data_SpBahanBaku[i, 7]
                    );
            }
        }

        public Frm_SPBahanBaku()
        {
            InitializeComponent();
        }

        private void Frm_SPManufaktur_Load(object sender, EventArgs e)
        {
            
            Gview_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Gview_Main.ReadOnly = true;
            Gview_Main.AutoGenerateColumns = false;
            Gview_Main.AllowDrop = false;
            Gview_Main.AllowUserToAddRows = false;
            Gview_Main.AllowUserToDeleteRows = false;
            Gview_Main.Columns.Add("KodeSP", "Kode Surat Pesan");
            Gview_Main.Columns.Add("KodeSupplier", "Kode Kode Supplier");
            Gview_Main.Columns.Add("NamaSupplier", "Nama Supplier");
            Gview_Main.Columns.Add("TanggalProduksi", "Tanggal Produksi");
            Gview_Main.Columns.Add("NamaBarang", "Nama Barang");
            Gview_Main.Columns.Add("Dp", "DP");
            Gview_Main.Columns.Add("JumlahBayar", "Jumlah Bayar");
            Gview_Main.Columns.Add("StatusPesanan", "Status");

            for (int i = 0; i < Gview_Main.Columns.Count - 1; i++)
                Gview_Main.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            BindData();
        }
    }
}

