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
    public partial class Frm_Dashboard : MetroForm
    {
        private App_Data appData;
        /* ----- [ MAIN SCRIPT ] ----- */
        private void InitGrid_Supplier()
        {
            Grid_Supplier.Columns.Add("NamaSupplier", "Nama Supplier");
            Grid_Supplier.Columns.Add("NamaBarang", "Nama Barang");
            Grid_Supplier.Columns.Add("HargaBarang", "Harga Barang");
            Grid_Supplier.Columns.Add("StockTersedia", "Stock Tersedia");
            Grid_Supplier.Columns.Add("TipeStock", "Tipe Stock");
            Grid_Supplier.Columns["HargaBarang"].DefaultCellStyle.Format = "c2";

            Grid_Supplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Supplier.ReadOnly = true;
            Grid_Supplier.AutoGenerateColumns = false;
            Grid_Supplier.AllowDrop = false;
            Grid_Supplier.AllowUserToAddRows = false;
            Grid_Supplier.AllowUserToDeleteRows = false;
            for (int i = 0; i < Grid_Supplier.Columns.Count - 1; i++)
                Grid_Supplier.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void BindGrid_Supplier()
        {
            Grid_Supplier.Rows.Clear();
            for (int rIndex = 0; rIndex < appData.Data_Detil_Supplier.GetLength(0); rIndex++)
            {
                Grid_Supplier.Rows.Add(
                    appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                    appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                    Convert.ToInt32(appData.Data_Detil_Supplier[rIndex, 5]),
                    appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                    appData.Data_Detil_Supplier[rIndex, 2].ToString()
                    );
            }
        }
        private void initGrid_Produksi() {
            Grid_Produksi.Columns.Add("KodeProduksi", "Kode Produksi");
            Grid_Produksi.Columns.Add("NamaManufaktur", "Nama Manufaktur");
            Grid_Produksi.Columns.Add("NamaBarang", "Nama Barang");
            Grid_Produksi.Columns.Add("TanggalProduksi", "Tanggal Produksi");
            Grid_Produksi.Columns.Add("JumlahProduksi", "Jumlah Produksi");
            Grid_Produksi.Columns["KodeProduksi"].Visible = false;
            Grid_Produksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Produksi.ReadOnly = true;
            Grid_Produksi.AutoGenerateColumns = false;
            Grid_Produksi.AllowDrop = false;
            Grid_Produksi.AllowUserToAddRows = false;
            Grid_Produksi.AllowUserToDeleteRows = false;
            for (int i = 0; i < Grid_Produksi.Columns.Count - 1; i++)
                Grid_Produksi.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void BindGrid_Produksi()
        {
            for (int rIndex = 0; rIndex < appData.Data_Produksi.GetLength(0); rIndex++)
            {
                Grid_Produksi.Rows.Add(
                    appData.Data_Produksi[rIndex, 0].ToString(),
                    appData.Data_Produksi[rIndex, 2].ToString(),
                    appData.Data_Produksi[rIndex, 3].ToString(),
                    appData.Data_Produksi[rIndex, 4].ToString(),
                    appData.Data_Produksi[rIndex, 5].ToString()
                    );
            }
        }
        private void InitComboBox()
        {
            Cmb_Filter_Produksi.SelectedIndex = 0;
            Cmb_Filter_Supplier.SelectedIndex = 0;
        }
        private void RefreshDateTime()
        {
            MLabel_Jam.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime dTime = new DateTime(
                Convert.ToInt32(DateTime.Now.ToString("yyyy")),
                Convert.ToInt32(DateTime.Now.ToString("MM")),
                Convert.ToInt32(DateTime.Now.ToString("dd")));

            MLabel_Tanggal.Text = dTime.ToString("dddd, dd MMMM yyyy");
        }
        private void RefreshMetroTile()
        {
            MTile_Supplier.TileCount = appData.Data_Supplier.GetLength(0);
            MTile_Supplier.Refresh();


            MTile_Produksi.TileCount = appData.Data_Produksi.GetLength(0);
            MTile_Produksi.Refresh();

            MTile_SPBahanBaku.TileCount = appData.Data_SpBahanBaku.GetLength(0);
            MTile_SPBahanBaku.Refresh();

            MTile_JadwalProduksi.TileCount = appData.Data_Jadwal_Produksi.GetLength(0);
            MTile_JadwalProduksi.Refresh();

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
            InitGrid_Supplier();
            BindGrid_Supplier();

            initGrid_Produksi();
            BindGrid_Produksi();

            InitComboBox();

            Tmr_RefreshDT.Start();
            Tmr_Refresh_data.Start();

            CultureInfo culture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = culture;
        }

        private void Grid_Supplier_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 2)
            {
                if (double.Parse(e.CellValue1.ToString()) > double.Parse(e.CellValue2.ToString()))
                {
                    e.SortResult = 1;
                }
                else if (double.Parse(e.CellValue1.ToString()) < double.Parse(e.CellValue2.ToString()))
                {
                    e.SortResult = -1;
                }
                else
                {
                    e.SortResult = 0;
                }
                e.Handled = true;
            }
        }

        private void Tmr_Refresh_data_Tick(object sender, EventArgs e)
        {
            RefreshMetroTile();
        }

        private void Tmr_RefreshDT_Tick(object sender, EventArgs e)
        {
            RefreshDateTime();
        }

        private void Cmb_Filter_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grid_Supplier.Rows.Clear();
            if (Cmb_Filter_Supplier.SelectedIndex == 0)
            {
                BindGrid_Supplier();
            } 
            else
            {
                int rIndex;
                switch (Cmb_Filter_Supplier.SelectedIndex)
                {
                    case 1:
                        rIndex = 0;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );

                        rIndex = 1;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );
                        break;
                    case 2:
                        rIndex = 1;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );

                        rIndex = 2;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );
                        break;
                    case 3:
                        rIndex = 6;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );

                        rIndex = 7;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );
                        break;
                    case 4:
                        rIndex = 5;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );
                        break;
                    case 5:
                        rIndex = 4;
                        Grid_Supplier.Rows.Add(
                            appData.Data_Detil_Supplier[rIndex, 1].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 5].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 4].ToString(),
                            appData.Data_Detil_Supplier[rIndex, 2].ToString()
                            );
                        break;
                }
            }
        }

        private void Cmb_Filter_Produksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grid_Produksi.Rows.Clear();
            if (Cmb_Filter_Produksi.SelectedIndex < 1)
            {
                BindGrid_Produksi();
            }
            else
            {
                int rIndex = Cmb_Filter_Produksi.SelectedIndex - 1;
                Grid_Produksi.Rows.Add(
                    appData.Data_Produksi[rIndex, 0].ToString(),
                    appData.Data_Produksi[rIndex, 2].ToString(),
                    appData.Data_Produksi[rIndex, 3].ToString(),
                    appData.Data_Produksi[rIndex, 4].ToString(),
                    appData.Data_Produksi[rIndex, 5].ToString()
                );
            }
        }

        private void MTile_Barang_Click(object sender, EventArgs e)
        {
            new Frm_SPBahanBaku().ShowDialog();
        }

        private void MTile_Supplier_Click(object sender, EventArgs e)
        {
            new Frm_Supplier().ShowDialog();
        }

        private void MTile_Produksi_Click(object sender, EventArgs e)
        {
            new Frm_Produksi().ShowDialog();
        }

        private void MTile_JadwalProduksi_Click(object sender, EventArgs e)
        {
            new Frm_JadwalProduksi().ShowDialog();
        }

        private void MTile_Distributor_Click(object sender, EventArgs e)
        {
            new Frm_Distributor().ShowDialog();
        }
    }
}
