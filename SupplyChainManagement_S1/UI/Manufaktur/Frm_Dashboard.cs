using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using SupplyChainManagement_S1.MainClass;
using System.Globalization;
using System.Threading;

namespace SupplyChainManagement_S1.UI.Manufaktur
{
    public partial class Frm_Dashboard : MetroForm
    {
        private App_Data appData;

        /* ----- [ MAIN SCRIPT ] ----- */
        /// <summary>
        /// Melakukan inisialisasi untuk Data Grid View (Gview_Main) untuk 
        /// menambahkan kolom.
        /// </summary>
        private void initGview_Main()
        {
            Gview_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Gview_Main.ReadOnly = true;
            Gview_Main.AutoGenerateColumns = false;
            Gview_Main.AllowDrop = false;
            Gview_Main.AllowUserToAddRows = false;
            Gview_Main.AllowUserToDeleteRows = false;
            Gview_Main.Columns.Add("KodeProduksi", "Kode Produksi");
            Gview_Main.Columns.Add("KodeManufaktur", "Kode Manufaktur");
            Gview_Main.Columns.Add("NamaManufaktur", "Nama Manufaktur");
            Gview_Main.Columns.Add("NamaBarang", "Nama Barang");
            Gview_Main.Columns.Add("TanggalProduksi", "Tanggal Produksi");
            Gview_Main.Columns.Add("JumlahProduksi", "Jumlah Produksi");

            for (int i = 0; i < Gview_Main.Columns.Count - 1; i++)
                Gview_Main.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        /// <summary>
        /// Memunculkan data untuk Data Grid View (Gview_Main)
        /// </summary>
        private void BindGview_Main()
        {
            Gview_Main.Rows.Clear();
            for (int i = 0; i < appData.Data_Produksi.GetLength(0); i++)
            {
                Gview_Main.Rows.Add(
                    appData.Data_Produksi[i, 0],
                    appData.Data_Produksi[i, 1],
                    appData.Data_Produksi[i, 2],
                    appData.Data_Produksi[i, 3],
                    appData.Data_Produksi[i, 4],
                    appData.Data_Produksi[i, 5]
                    );
            }
        }
        /// <summary>
        /// Method untuk menampilkan waktu dan tanggal di aplikasi
        /// </summary>
        private void RefreshDateTime()
        {
            MLabel_Jam.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime dTime = new DateTime(
                Convert.ToInt32(DateTime.Now.ToString("yyyy")),
                Convert.ToInt32(DateTime.Now.ToString("MM")),
                Convert.ToInt32(DateTime.Now.ToString("dd")));

            MLabel_Tanggal.Text = dTime.ToString("dddd, dd MMMM yyyy");
        }
        /// <summary>
        /// Method untuk merefresh jumlah data yang ada dan ditampilkan di
        /// MetroTile
        /// </summary>
        private void RefreshMetroTile()
        {
            MTile_Barang.TileCount = appData.Data_Barang.GetLength(0);
            MTile_Barang.Refresh();

            MTile_Supplier.TileCount = appData.Data_Supplier.GetLength(0);
            MTile_Supplier.Refresh();

            MTile_BarangJadi.TileCount = appData.Data_Produksi.GetLength(0);
            MTile_BarangJadi.Refresh();

            MTile_SPBahanBaku.TileCount = appData.Data_SpBahanBaku.GetLength(0);
            MTile_SPBahanBaku.Refresh();

            MTile_Distributor.TileCount = appData.Data_Distributor.GetLength(0);
            MTile_Distributor.Refresh();
        }

        /* ----- [ GENERATED SCRIPT ] ----- */
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            appData = new App_Data();

            CultureInfo culture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = culture;

            initGview_Main();
            BindGview_Main();

            Tmr_RefreshDT.Start();
            Tmr_Refresh_data.Start();
        }

        private void Tmr_RefreshDT_Tick(object sender, EventArgs e)
        {
            RefreshDateTime();
        }

        private void Tmr_Refresh_data_Tick(object sender, EventArgs e)
        {
            RefreshMetroTile();
        }
    }
}
