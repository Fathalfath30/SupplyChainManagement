using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using SupplyChainManagement_S1.MainScript;
using MySql.Data.MySqlClient;
using SupplyChainManagement_S1.MainClass;

namespace SupplyChainManagement_S1.UI.Master
{
    public partial class Frm_ManajemenBarang : MetroForm
    {
        private DataSet TmpDB;
        private App_Data appDT;

        private string Generate_id()
        {
            string Main_id = "";
            DataRow LastR = TmpDB.Tables["barang"].Rows[TmpDB.Tables["barang"].Rows.Count - 1];
            // BRG012
            if (TmpDB.Tables["barang"].Rows.Count > 0)
            {
                string TmpId = LastR["ID"].ToString();
                Main_id = string.Format("BRG{0:000}", Convert.ToInt32(TmpId.Substring(3)) + 1);
            }
            else
            {
                Main_id = "BRG001";
            }
            return Main_id;
        }

        private void BindTipe()
        {
            DataSet DSetTipe = new DataSet();
            DataTable TTipe = new DataTable("tipe_barang");
        }

        private void BindData()
        {
            TmpDB = new DataSet();
            TmpDB.Tables.Add(appDT.TableBarang());
            Gview_Main.DataSource = TmpDB.Tables["barang"];
            Gview_Main.AutoGenerateColumns = false;
            Gview_Main.Columns["ID"].HeaderText = "ID Barang";
            Gview_Main.Columns["NAME"].HeaderText = "Nama Barang";
            
        }

        /// <summary>
        /// Me-reset form dan reload form
        /// </summary>
        private void RefreshForm()
        {
            Txt_Keyword.Text = "";
            Txt_KodeBarang.Text = Generate_id();
            Txt_NmBarang.Text = "";
            Txt_MaxStock.Text = "0";
            Txt_MinStock.Text = "0";

            Txt_NmBarang.Focus();

            BindData();
            Generate_id();
        }

        public Frm_ManajemenBarang()
        {
            InitializeComponent();

            TmpDB = new DataSet();
            appDT = new App_Data();

            TmpDB.Tables.Add(appDT.TableBarang());
        }

        private void Frm_ManajemenBarang_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }
    }
}
