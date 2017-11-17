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
        private App_Data AData;

        private void BindData()
        {
            Gview_Main.Rows.Clear();
            for (int i = 0; i < AData.Data_Produksi.GetLength(0); i ++)
            {
                Gview_Main.Rows.Add(
                    AData.Data_Produksi[i, 0],
                    AData.Data_Produksi[i, 1],
                    AData.Data_Produksi[i, 2],
                    AData.Data_Produksi[i, 3],
                    AData.Data_Produksi[i, 4],
                    AData.Data_Produksi[i, 5]
                    );
            }
        }

        public Frm_Dashboard()
        {
            InitializeComponent();
            AData = new App_Data();
        }

        private void Frm_Manufaktur_Dashboard_Load(object sender, EventArgs e)
        {
            Tmr_RefreshDT.Start();
            Tmr_Refresh_data.Start();

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

        private void Frm_Manufaktur_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            CultureInfo culture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = culture;
        }

        private void Tmr_RefreshDT_Tick(object sender, EventArgs e)
        {
            MLabel_Jam.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime dTime = new DateTime(
                Convert.ToInt32(DateTime.Now.ToString("yyyy")),
                Convert.ToInt32(DateTime.Now.ToString("MM")),
                Convert.ToInt32(DateTime.Now.ToString("dd")));

            MLabel_Tanggal.Text = dTime.ToString("dddd, dd MMMM yyyy") ;

        }

        private void MTile_Barang_Click(object sender, EventArgs e)
        {
            Tmr_Refresh_data.Stop();
            Tmr_Refresh_data.Start();
        }

        private void Tmr_Refresh_data_Tick(object sender, EventArgs e)
        {
            MTile_Barang.TileCount = AData.Data_Barang.GetLength(0);
            MTile_Barang.Refresh();

            MTile_Supplier.TileCount = AData.Data_Supplier.GetLength(0);
            MTile_Supplier.Refresh();

            MTile_BarangJadi.TileCount = AData.Data_Produksi.GetLength(0);
            MTile_BarangJadi.Refresh();

            MTile_SPBahanBaku.TileCount = AData.Data_SpBahanBaku.GetLength(0);
            MTile_SPBahanBaku.Refresh();

            MTile_Distributor.TileCount = AData.Data_Distributor.GetLength(0);
            MTile_Distributor.Refresh();
        }

        private void Frm_DashboardManufaktur_Shown(object sender, EventArgs e)
        {
            Activate();
            BindData();
        }

        private void MTile_Supplier_Click(object sender, EventArgs e)
        {
            Tmr_Refresh_data.Stop();
            Tmr_Refresh_data.Start();
        }

        private void MTile_BarangJadi_Click(object sender, EventArgs e)
        {
            
        }

        private void MTile_SPBahanBaku_Click(object sender, EventArgs e)
        {

            Tmr_Refresh_data.Stop();
            Tmr_Refresh_data.Start();
        }
    }
}
