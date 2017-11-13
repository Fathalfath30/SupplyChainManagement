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

namespace SupplyChainManagement_S1.UI.Dashboard
{
    public partial class Frm_DashboardManufaktur : MetroForm
    {
        private DataSet TmpDB;
        private App_Data appDT;

        public Frm_DashboardManufaktur()
        {
            InitializeComponent();
            TmpDB = new DataSet();
            appDT = new App_Data();

            TmpDB.Tables.Add(appDT.TableSupplier());
            TmpDB.Tables.Add(appDT.TableBarang());

            Tmr_RefreshDT.Start();
            Tmr_Refresh_data.Start();
        }

        private void Frm_DashboardManufaktur_Load(object sender, EventArgs e)
        {
            
        }

        private void Frm_DashboardManufaktur_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Tmr_Refresh_koneksi_Tick(object sender, EventArgs e)
        {
            
        }

        private void Tmr_RefreshDT_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("id-ID");
            MLabel_Jam.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime dTime = new DateTime(
                Convert.ToInt32(DateTime.Now.ToString("yyyy")),
                Convert.ToInt32(DateTime.Now.ToString("MM")),
                Convert.ToInt32(DateTime.Now.ToString("dd")));

            MLabel_Tanggal.Text = dTime.ToString("dddd, dd MMMM yyyy", culture);
        }

        private void Tmr_Refresh_data_Tick(object sender, EventArgs e)
        {
            MTile_Supplier.TileCount = TmpDB.Tables["supplier"].Rows.Count;
            MTile_Barang.TileCount = TmpDB.Tables["barang"].Rows.Count;
        }

        private void MTile_Barang_Click(object sender, EventArgs e)
        {
            new UI.Master.Frm_ManajemenBarang().ShowDialog();

        }
    }
}
