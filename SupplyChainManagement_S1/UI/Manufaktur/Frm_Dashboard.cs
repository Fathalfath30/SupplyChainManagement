using System;
using System.Data;
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
        private DataSet MainDS;
        private DataTable MainDT;
        /* ----- [ MAIN SCRIPT ] ----- */
        private void initDS()
        {
            MainDS = new DataSet();
            int rIndex = 0;

            // Data Supplier
            MainDT = new DataTable("supplier");
            MainDT.Columns.Add("NamaSupplier", typeof(string));
            MainDT.Columns.Add("NamaBarang", typeof(string));
            MainDT.Columns.Add("HargaBarang", typeof(string));
            MainDT.Columns.Add("StockTersedia", typeof(string));

            for (rIndex = 0; rIndex < appData.Data_Detil_Supplier.GetLength(0); rIndex ++)
            {
                MainDT.Rows.Add(
                    appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                    appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                    appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                    appData.Data_Detil_Supplier[rIndex, 4].ToString()
                    );
            }
            MainDS.Tables.Add(MainDT);

            // Data Produksi
            MainDT = new DataTable("produksi");
            MainDT.Columns.Add("KodeProduksi", typeof(string));
            MainDT.Columns.Add("NamaManufaktur", typeof(string));
            MainDT.Columns.Add("NamaBarang", typeof(string));
            MainDT.Columns.Add("TanggalProduksi", typeof(string));
            MainDT.Columns.Add("JumlahProduksi", typeof(string));
            
            for (rIndex = 0; rIndex < appData.Data_Produksi.GetLength(0); rIndex ++)
            {
                MainDT.Rows.Add(
                    appData.Data_Produksi[rIndex, 0].ToString(),
                    appData.Data_Produksi[rIndex, 2].ToString(),
                    appData.Data_Produksi[rIndex, 3].ToString(),
                    appData.Data_Produksi[rIndex, 4].ToString(),
                    appData.Data_Produksi[rIndex, 5].ToString()
                    );
            }
            MainDS.Tables.Add(MainDT);
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

        private void BindDT_Supplier()
        {
            Gview_Supplier.DataSource = MainDS.Tables["supplier"];
            Gview_Supplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Gview_Supplier.ReadOnly = true;
            Gview_Supplier.AutoGenerateColumns = false;
            Gview_Supplier.AllowDrop = false;
            Gview_Supplier.AllowUserToAddRows = false;
            Gview_Supplier.AllowUserToDeleteRows = false;
            for (int i = 0; i < Gview_Supplier.Columns.Count - 1; i++)
                Gview_Supplier.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        /// <summary>
        /// Melakukan inisialisasi untuk Data Grid View (Gview_Produksi) untuk 
        /// menambahkan kolom.
        /// </summary>
        private void BindDT_Produksi()
        {
            Gview_Produksi.DataSource = MainDS.Tables["produksi"];
            Gview_Produksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Gview_Produksi.ReadOnly = true;
            Gview_Produksi.AutoGenerateColumns = false;
            Gview_Produksi.AllowDrop = false;
            Gview_Produksi.AllowUserToAddRows = false;
            Gview_Produksi.AllowUserToDeleteRows = false;
            for (int i = 0; i < Gview_Produksi.Columns.Count - 1; i++)
                Gview_Produksi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

            // Menginisialisasi Data Set
            initDS();

            // Memasukan DataSet
            BindDT_Produksi();
            BindDT_Supplier();

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

        private void Btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult DResult = MessageBox.Show(
                this,
                "Apakah anda yakin ingin logout dari sistem ?",
                "Konfirmasi",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (DResult == DialogResult.OK)
            {
                Close();
                new UI.Main.Frm_Login().Show();
            }
        }
    }
}
