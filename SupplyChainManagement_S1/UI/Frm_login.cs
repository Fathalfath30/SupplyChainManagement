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

namespace SupplyChainManagement_S1.UI
{
    public partial class Frm_login : MetroForm
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string Username = Txt_Username.Text;
            string Password = Txt_Password.Text;

            if (Username.Equals("manufaktur", StringComparison.CurrentCultureIgnoreCase) && Password.Equals("manufaktur"))
            {
                MessageBox.Show(
                    null,
                    "Selamat datang, anda login sebagai : Manufaktur",
                    "Login Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                new Dashboard.Frm_DashboardManufaktur().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    null,
                    "Maaf, Username dan Password yang anda masukan tidak sesuai.",
                    "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                Txt_Password.Text = "";
                Txt_Password.Focus();
            }
        }

        private void Btn_Batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Txt_Username.Text.Trim() == "")
                {
                    MessageBox.Show(
                       null,
                       "Harap isi Username terlebih dahulu !",
                       "Form tidak lengkap",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                       );
                    Txt_Username.Focus();
                }
                else
                {
                    Txt_Password.Focus();
                }
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Txt_Password.Text.Trim() == "")
                {
                    MessageBox.Show(
                       null,
                       "Harap isi Password terlebih dahulu !",
                       "Form tidak lengkap",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                       );
                    Txt_Password.Focus();
                }
                else
                {
                    Btn_Login.PerformClick();
                }
            }
        }

        private void Btn_Batal_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
