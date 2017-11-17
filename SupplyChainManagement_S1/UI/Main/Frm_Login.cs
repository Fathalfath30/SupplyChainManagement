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

namespace SupplyChainManagement_S1.UI.Main
{
    public partial class Frm_Login : MetroForm
    {
        /* ----- [ MAIN SCRIPT ] ----- */
        /// <summary>
        /// Method untuk melakukan otentikasi terhadap user yang
        /// akan menggunakan aplikasi ini.
        /// </summary>
        private void Begin_authentication()
        {
            string strUsername = Txt_Username.Text.Trim();
            string strPassword = Txt_Password.Text.Trim();

            if (strPassword != "admin")
            {
                MessageBox.Show(
                    this,
                    "Password yang anda masukan salah. Silahkan coba kembali.",
                    "Otentikasi gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            switch (strUsername.ToLower())
            {
                case "manufaktur":
                    MessageBox.Show(
                        this,
                        string.Format("Selamat datang {0}, anda login sebagai : Manufaktur",strUsername),
                        "Otentikasi gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    new Manufaktur.Frm_Dashboard().Show();
                    Hide();
                    break;

                default:
                    MessageBox.Show(
                        this,
                        "Username yang anda masukan salah. Silahkan coba kembali.",
                        "Otentikasi gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }

        }
        /* ----- [ GENERATED SCRIPT ] ----- */

        /// <summary>
        /// Constructor Form : Frm_Login
        /// </summary>
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_Username.Text.Trim() == "")
            {
                MessageBox.Show(
                    this,
                    "Username belum di isi, silahkan isi Username terlebih dahulu.",
                    "Form tidak lengkap.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Txt_Username.Focus();
                return;
            }
            else if (Txt_Password.Text.Trim() == "")
            {
                MessageBox.Show(
                   this,
                   "Password belum di isi, silahkan isi Password terlebih dahulu.",
                   "Form tidak lengkap.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                Txt_Password.Focus();
                return;
            }
            else
            {
                Begin_authentication();
            }
        }

        private void Txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Txt_Username.Text.Trim() == "")
                {
                    MessageBox.Show(
                        this,
                        "Username belum di isi, silahkan isi Username terlebih dahulu.",
                        "Form tidak lengkap.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Txt_Username.Focus();
                    return;
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
                       this,
                       "Password belum di isi, silahkan isi Password terlebih dahulu.",
                       "Form tidak lengkap.",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    Txt_Password.Focus();
                    return;
                }
                else
                {
                    Btn_Login.PerformClick();
                }
            }
        }

        private void Lnbl_Lupa_password_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                       this,
                       "Maaf, fitur ini belum dapat digunakan.",
                       "Informasi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }

        private void Btn_Batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
