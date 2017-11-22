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
    public partial class Frm_Produksi : MetroForm
    {
        private App_Data appData;
        /* ----- [ MAIN SCRIPT ] ----- */
        private void initGrid_Produksi()
        {
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
        /* ----- [ GENERATED SCRIPT ] ----- */
        public Frm_Produksi()
        {
            InitializeComponent();
            appData = new App_Data();
        }

        private void Frm_Produksi_Load(object sender, EventArgs e)
        {
            Cmb_Filter_Produksi.SelectedIndex = 0;

            initGrid_Produksi();
            BindGrid_Produksi();
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
    }
}
