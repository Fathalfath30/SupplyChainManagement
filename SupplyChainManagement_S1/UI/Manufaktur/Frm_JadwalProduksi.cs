using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using SupplyChainManagement_S1.MainClass;
using System.Globalization;
using System.Threading;
using System.ComponentModel;

namespace SupplyChainManagement_S1.UI.Manufaktur
{
    public partial class Frm_JadwalProduksi : MetroForm
    {
        private App_Data appData;
        /* ----- [ MAIN SCRIPT ] ----- */
        private void InitCmb_Tahun()
        {
            Cmb_Filter_Tahun.Items.Clear();
            Cmb_Filter_Tahun.Items.Add("Tampilkan Semua");
            for (int Y = DateTime.Now.Year; Y > (DateTime.Now.Year - 10); Y--)
                Cmb_Filter_Tahun.Items.Add(Y);
        }

        private void InitGrid_Jadwal_Produksi()
        {
            
            Grid_JadwalProduksi.Columns.Add("NamaManufaktur", "Nama Manufaktur");
            Grid_JadwalProduksi.Columns.Add("NamaBarang", "Nama Barang");
            Grid_JadwalProduksi.Columns.Add("TanggalProduksi", "Tanggal");
            Grid_JadwalProduksi.Columns.Add("Target", "Target");
            Grid_JadwalProduksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_JadwalProduksi.ReadOnly = true;
            Grid_JadwalProduksi.AutoGenerateColumns = false;
            Grid_JadwalProduksi.AllowDrop = false;
            Grid_JadwalProduksi.AllowUserToAddRows = false;
            Grid_JadwalProduksi.AllowUserToDeleteRows = false;
            for (int i = 0; i < Grid_JadwalProduksi.Columns.Count - 1; i++)
                Grid_JadwalProduksi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void BindGrid_Jadwal_Produksi()
        {
            Grid_JadwalProduksi.Rows.Clear();
            for (int rIndex = 0; rIndex < appData.Data_Distributor.GetLength(0); rIndex++)
            {
                Grid_JadwalProduksi.Rows.Add(
                    appData.Data_Jadwal_Produksi[rIndex, 1].ToString(),
                    appData.Data_Jadwal_Produksi[rIndex, 2].ToString(),
                    appData.Data_Jadwal_Produksi[rIndex, 3].ToString(),
                    appData.Data_Jadwal_Produksi[rIndex, 4].ToString()
                    );
            }
        }

        /* ----- [ GENERATED SCRIPT ] ----- */
        public Frm_JadwalProduksi()
        {
            appData = new App_Data();
            InitializeComponent();

            InitGrid_Jadwal_Produksi();
            BindGrid_Jadwal_Produksi();
        }

        private void Frm_JadwalProduksi_Load(object sender, EventArgs e)
        {
            InitCmb_Tahun();
            Cmb_Filter_Produksi.SelectedIndex = 0;
            Cmb_Filter_Bulan.SelectedIndex = 0;
            Cmb_Filter_Tahun.SelectedIndex = 0;
        }
    }
}
