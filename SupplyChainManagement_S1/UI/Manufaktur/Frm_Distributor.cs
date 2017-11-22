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
    public partial class Frm_Distributor : MetroForm
    {   
        private App_Data appData;
        /* ----- [ MAIN SCRIPT ] ----- */
        private void InitGrid_Distributor()
        {
            Grid_Distributor.Columns.Add("NamaDistributor", "Nama Distributor");
            Grid_Distributor.Columns.Add("Kapasitas", "Kapasitas");
            Grid_Distributor.Columns.Add("Status", "Status");
            Grid_Distributor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Grid_Distributor.ReadOnly = true;
            Grid_Distributor.AutoGenerateColumns = false;
            Grid_Distributor.AllowDrop = false;
            Grid_Distributor.AllowUserToAddRows = false;
            Grid_Distributor.AllowUserToDeleteRows = false;
            for (int i = 0; i < Grid_Distributor.Columns.Count - 1; i++)
                Grid_Distributor.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void Bind_Distributor()
        {
            for (int rIndex = 0; rIndex < appData.Data_Distributor.GetLength(0); rIndex++)
            {
                Grid_Distributor.Rows.Add(
                    appData.Data_Distributor[rIndex, 1].ToString(),
                    appData.Data_Distributor[rIndex, 4].ToString(),
                    appData.Data_Distributor[rIndex, 5].ToString()
                    );
            }
        }
        /* ----- [ GENERATED SCRIPT ] ----- */
        public Frm_Distributor()
        {
            appData = new App_Data();

            InitializeComponent();

            InitGrid_Distributor();
            Bind_Distributor();
        }

        private void Frm_Distributor_Load(object sender, EventArgs e)
        {

        }
    }
}
