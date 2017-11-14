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
            Gview_Barang.Rows.Clear();
            Gview_Barang.Refresh();
        }

        private void ResetFormBarang()
        {
            Txt_KodeBarang.Text = "";
            Txt_NamaBarang.Text = "";
            Txt_StockTersedia.Text = "0";
        }

        private void RefreshForm()
        {
            BindData();
            ResetFormBarang();
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
            Gview_Barang.ReadOnly = true;
            Gview_Barang.AllowUserToAddRows = false;
            Gview_Barang.AllowUserToDeleteRows = false;
            Gview_Barang.AllowUserToResizeColumns = true;
            Gview_Barang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Gview_Barang.Columns.Add("KodeBarang", "Kode Barang");
            Gview_Barang.Columns.Add("NamaBarang", "Nama barang");
            Gview_Barang.Columns.Add("StockTersedia", "Stock Tersedia");
            RefreshForm();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            string[,] DataBarang = CBarang.CariBarang(Txt_KodeBarang.Text);
            Txt_KodeBarang.Text = DataBarang[0, 0];
            Txt_NamaBarang.Text = DataBarang[0, 1];
            Txt_StockTersedia.Text = "0";
        }

        private void Txt_KodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Txt_KodeBarang.Text.Trim() == "")
                {
                    MessageBox.Show(
                        this, 
                        "Isi kode barang terlebih dahulu!", "Form Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                    Txt_KodeBarang.Focus();

                } else
                {
                    BtnCari.PerformClick();
                }
            }
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {

            if (Txt_KodeBarang.Text.Trim() == "")
            {
                Txt_KodeBarang.Focus();
                goto DataKosong;
            }
            else if (Txt_NamaBarang.Text.Trim() == "")
            {
                Txt_NamaBarang.Focus();
                goto DataKosong;
            } 
            else if (Txt_StockTersedia.Text.Trim() == "")
            {
                Txt_StockTersedia.Focus();
                goto DataKosong;
            }
            else
            {
                if (Gview_Barang.Rows.Count > 0)
                {
                    bool status = false;
                    int gIndex = 0;
                    for (gIndex = 0; gIndex < Gview_Barang.Rows.Count; gIndex++)
                    {
                        status = ((string)Gview_Barang.Rows[gIndex].Cells[0].Value == Txt_KodeBarang.Text.Trim()) ? true : false;
                        if (status)
                            break;
                    }

                    if (status)
                    {
                        int Last_stock = Convert.ToInt32(Gview_Barang.Rows[gIndex].Cells["StockTersedia"].Value);
                        Gview_Barang.Rows[gIndex].Cells[2].Value = Last_stock + Convert.ToInt32(Txt_StockTersedia.Text);
                    }
                    else
                    {
                        Gview_Barang.Rows.Add(Txt_KodeBarang.Text, Txt_NamaBarang.Text, Txt_StockTersedia.Text);
                    }
                }
                else
                {
                    Gview_Barang.Rows.Add(Txt_KodeBarang.Text, Txt_NamaBarang.Text, Txt_StockTersedia.Text);
                }
            }
            ResetFormBarang();
            return;
            DataKosong:
            MessageBox.Show(
                this, 
                "Terdapat data yang kosong, silahkan periksa kembali form anda.", 
                "Form Error", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error
                );
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFormBarang();
        }

        private void BtnUpdate2_Click(object sender, EventArgs e)
        {
            if (Txt_KodeBarang.Text.Trim() == "")
            {
                Txt_KodeBarang.Focus();
                goto DataKosong;
            }
            else if (Txt_NamaBarang.Text.Trim() == "")
            {
                Txt_NamaBarang.Focus();
                goto DataKosong;
            }
            else if (Txt_StockTersedia.Text.Trim() == "")
            {
                Txt_StockTersedia.Focus();
                goto DataKosong;
            }
            else
            {
                if (Gview_Barang.Rows.Count > 0)
                {
                    bool status = false;
                    int gIndex = 0;
                    for (gIndex = 0; gIndex < Gview_Barang.Rows.Count; gIndex++)
                    {
                        status = ((string)Gview_Barang.Rows[gIndex].Cells[0].Value == Txt_KodeBarang.Text.Trim()) ? true : false;
                        if (status)
                        {
                            Gview_Barang.Rows[gIndex].Cells[0].Value = Txt_KodeBarang.Text;
                            Gview_Barang.Rows[gIndex].Cells[1].Value = Txt_NamaBarang.Text;
                            Gview_Barang.Rows[gIndex].Cells[2].Value = Txt_StockTersedia.Text;
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show(
                    this,
                    "Tidak ada data yang di update.",
                    "Form Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
            }

            return;
            DataKosong:
            MessageBox.Show(
                this,
                "Terdapat data yang kosong, silahkan periksa kembali form anda.",
                "Form Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
    }
}
