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

namespace SupplyChainManagement_S1.UI.Dashboard
{
    public partial class Frm_DashboardManufaktur : MetroForm
    {
        private Cls_Barang CBarang;
        private Cls_Supplier CSupplier;

        public Frm_DashboardManufaktur()
        {
            InitializeComponent();
            CBarang = new Cls_Barang();
            CSupplier = new Cls_Supplier();
        }

        private void Frm_Manufaktur_Dashboard_Load(object sender, EventArgs e)
        {
            Tmr_RefreshDT.Start();
            Tmr_Refresh_data.Start();

            MTile_Barang.Focus();
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
            new Frm_ManajemenBarang().ShowDialog();
            Tmr_Refresh_data.Start();
        }

        private void Tmr_Refresh_data_Tick(object sender, EventArgs e)
        {
            MTile_Barang.TileCount = CBarang.rowCount();
            MTile_Barang.Refresh();

            MTile_Supplier.TileCount = CSupplier.rowCount();
            MTile_Supplier.Refresh();
        }

        private void Frm_DashboardManufaktur_Shown(object sender, EventArgs e)
        {
            Activate();
        }

        private void MTile_Supplier_Click(object sender, EventArgs e)
        {

            Tmr_Refresh_data.Stop();
            new Frm_TampilSupplier().ShowDialog();
            Tmr_Refresh_data.Start();
        }
    }
}
