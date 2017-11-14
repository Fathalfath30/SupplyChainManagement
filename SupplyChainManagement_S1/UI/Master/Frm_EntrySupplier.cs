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
using System.Threading;
using System.Globalization;


namespace SupplyChainManagement_S1.UI.Master
{
    public partial class Frm_EntrySupplier : MetroForm
    {
        Cls_Supplier CSupplier;
        Cls_Barang CBarang;

        /* ---------- [START] Method Utama ---------- */
        private void BindData()
        {
            
        }

        private void RefreshForm()
        {
            BindData();
        }
        /* ---------- [END] Method Utama ---------- */
        public Frm_EntrySupplier()
        {
            InitializeComponent();
            CSupplier = new Cls_Supplier();
            CBarang = new Cls_Barang();
        }

        private void Frm_TambahSupplier_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
