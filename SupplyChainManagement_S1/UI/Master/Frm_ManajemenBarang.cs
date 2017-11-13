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

namespace SupplyChainManagement_S1.UI.Master
{
    public partial class Frm_ManajemenBarang : MetroForm
    {
        private Cls_DbConnection CDatabase;
        private Cls_Barang CBarang;

        /* ---------- [START] Method Utama ---------- */
        private void BindTipeBarang()
        {
            DataTable Dtbl_TipeBarang = new DataTable("TipeBarang");
            Dtbl_TipeBarang.Columns.Add("ID");
            Dtbl_TipeBarang.Columns.Add("NAME");
            Dtbl_TipeBarang.Rows.Add("", "-Pilih Salah Satu-");
            Dtbl_TipeBarang.Rows.Add("0", "Bahan Baku");
            Dtbl_TipeBarang.Rows.Add("1", "MRO");
            Dtbl_TipeBarang.Rows.Add("2", "Barang Jadi");

            DataSet dSet = new DataSet("DS_TipeBarang");
            dSet.Tables.Add(Dtbl_TipeBarang);

            DataView Dview = dSet.Tables["TipeBarang"].DefaultView;
            Cmb_TipeBarang.DataSource = Dview;
            Cmb_TipeBarang.ValueMember = "ID";
            Cmb_TipeBarang.DisplayMember = "NAME";

        }

        private void RefreshForm()
        {
            Txt_Keyword.Text = "";
            Txt_KodeBarang.Text = "";
            Txt_NmBarang.Text = "";
            Txt_MinStock.Text = "1";
            Txt_MaxStock.Text = "100";

            BindTipeBarang();
            Txt_KodeBarang.Text = CBarang.auto_number();

            Txt_NmBarang.Focus();
        }
        /* ---------- [END] Method Utama ---------- */


        public Frm_ManajemenBarang(Cls_DbConnection CDbConnection)
        {
            InitializeComponent();
            BindTipeBarang();

            CDatabase = CDbConnection;
            CBarang = new Cls_Barang(CDatabase.Connection);

        }

        private void ManajemenBarang_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (Txt_KodeBarang.Text.Trim() == "")
            {
                Txt_KodeBarang.Focus();
                goto EmptyData;
            }
            else if (Txt_NmBarang.Text.Trim() == "")
            {
                Txt_NmBarang.Focus();
                goto EmptyData;
            }
            else if (Txt_MinStock.Text.Trim() == "")
            {
                Txt_MinStock.Focus();
                goto EmptyData;
            }
            else if (Txt_MaxStock.Text.Trim() == "")
            {
                Txt_MaxStock.Focus();
                goto EmptyData;
            }
            else
            {

            }

            EmptyData:
            MessageBox.Show(null, "Terdapat data yang kosong, silahkan periksa kembali form anda.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
