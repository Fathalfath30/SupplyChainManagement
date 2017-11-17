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

namespace SupplyChainManagement_S1.UI.Master
{
    public partial class Frm_ManajemenBarang : MetroForm
    {
        private Cls_Barang CBarang;
        private App_Data AData = new App_Data();

        /* ---------- [START] Method Utama ---------- */
        private void BindMainData(bool search = false)
        {
            Gview_Main.Rows.Clear();
            for (int i = 0; i < AData.Data_Barang.GetLength(0); i++)
            {
                Gview_Main.Rows.Add(
                    AData.Data_Barang[i, 0],
                    AData.Data_Barang[i, 1],
                    AData.Data_Barang[i, 2],
                    AData.Data_Barang[i, 3],
                    AData.Data_Barang[i, 4]
                    );
            }
        }

        private void BindTipeBarang()
        {
            DataTable Dtbl_TipeBarang = new DataTable("TipeBarang");
            Dtbl_TipeBarang.Columns.Add("ID");
            Dtbl_TipeBarang.Columns.Add("NAME");
            Dtbl_TipeBarang.Rows.Add("999", "-Pilih Salah Satu-");
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
            Txt_KodeBarang.Text = "BRG013";

            Txt_NmBarang.Focus();
            BindMainData();
        }

        private void LockForm()
        {
            if (Properties.Settings.Default.S_LEVEL == "9")
                return;

            MessageBox.Show(
                this,
                "Perhatian : Hak anda terbatas, anda hanya dapat melihat data saja.",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

            Txt_KodeBarang.Enabled = false;
            Txt_NmBarang.Enabled = false;
            Txt_MaxStock.Enabled = false;
            Txt_MinStock.Enabled = false;
            Cmb_TipeBarang.Enabled = false;
            BtnSimpan.Enabled = false;
            BtnUpdate.Enabled = false;
            BtnHapus.Enabled = false;

        }
        /* ---------- [END] Method Utama ---------- */


        public Frm_ManajemenBarang()
        {
            InitializeComponent();
            BindTipeBarang();
            CBarang = new Cls_Barang();

        }

        private void ManajemenBarang_Load(object sender, EventArgs e)
        {
            Gview_Main.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Gview_Main.ReadOnly = true;
            Gview_Main.AutoGenerateColumns = false;
            Gview_Main.AllowDrop = false;
            Gview_Main.AllowUserToAddRows = false;
            Gview_Main.AllowUserToDeleteRows = false;

            Gview_Main.Columns.Add("KodeBarang", "Kode Barang");
            Gview_Main.Columns.Add("NamaBarang", "Nama Barang");
            Gview_Main.Columns.Add("TipeBarang", "Tipe Barang");
            Gview_Main.Columns.Add("MinStock", "Stock Minimal");
            Gview_Main.Columns.Add("MaxStock", "Stock Maximal");

            for (int i = 0; i < Gview_Main.Columns.Count - 1; i++)
                Gview_Main.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            RefreshForm();
            LockForm();

            
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
            else if ((string)Cmb_TipeBarang.SelectedValue == "999")
            {
                Cmb_TipeBarang.Focus();
                goto EmptyData;
            }
            else
            {
                MessageBox.Show(
                        this,
                        "Data Behasil ditambahkan.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                RefreshForm();
            }

            return;
            EmptyData:
            MessageBox.Show(null, "Terdapat data yang kosong, silahkan periksa kembali form anda.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Txt_Keyword_KeyUp(object sender, KeyEventArgs e)
        {
            BindMainData(true);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
            else if ((string)Cmb_TipeBarang.SelectedValue == "999")
            {
                Cmb_TipeBarang.Focus();
                goto EmptyData;
            }
            else
            {
                CBarang = new Cls_Barang();
                CBarang.KodeBarang = Txt_KodeBarang.Text;
                CBarang.NamaBarang = Txt_NmBarang.Text;
                CBarang.MinStock = Convert.ToInt32(Txt_MinStock.Text);
                CBarang.MaxStock = Convert.ToInt32(Txt_MaxStock.Text);
                CBarang.iTipeBarang = Convert.ToInt32((string)Cmb_TipeBarang.SelectedValue);
                MessageBox.Show(
                        this,
                        "Data Behasil di update.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                RefreshForm();
            }

            return;
            EmptyData:
            MessageBox.Show(null, "Terdapat data yang kosong, silahkan periksa kembali form anda.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        private void Gview_Main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Gview_Main.SelectedCells.Count > 0)
            {
                DataGridViewRow R = Gview_Main.Rows[e.RowIndex];
                Txt_KodeBarang.Text = R.Cells["KodeBarang"].Value.ToString();
                Txt_NmBarang.Text = R.Cells["NamaBarang"].Value.ToString();
                Txt_MinStock.Text = R.Cells["MinStock"].Value.ToString();
                Txt_MaxStock.Text = R.Cells["MaxStock"].Value.ToString();
                Cmb_TipeBarang.SelectedValue = R.Cells["iTipeBarang"].Value.ToString();
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DialogResult Drs = MessageBox.Show(
                this,
                "Apakah anda yakin ingin menghapus data ini ?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (Drs == DialogResult.Yes)
            {
                MessageBox.Show(
                        this,
                        "Data Behasil di hapus.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                RefreshForm();
            }
         }
    }
}
