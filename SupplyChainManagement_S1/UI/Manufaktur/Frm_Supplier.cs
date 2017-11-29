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
    public partial class Frm_Supplier : MetroForm
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
        /* ----- [ GENERATED SCRIPT ] ----- */
        public Frm_Supplier()
        {
            InitializeComponent();
        }

        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            appData = new App_Data();

            InitGrid_Supplier();
            BindGrid_Supplier();
            Cmb_Filter_Supplier.SelectedIndex = 0;
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
    }
}
