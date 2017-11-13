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
        private Cls_DbConnection DbConn;
        private Cls_Login CLogin;

        public Frm_login()
        {
            InitializeComponent();
            DbConn = new Cls_DbConnection();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            DbConn.Hostname = "localhost";
            DbConn.Username = "root";
            DbConn.Password = "";
            DbConn.Database = "db_prototype";

            DbConn.initClass().OpenConnection();
            CLogin = new Cls_Login(DbConn);

            Txt_Username.Focus();
        }

        /// <summary>
        /// Memindahkan user ke dashboardnya masing - masing
        /// jika user berhasil login.
        /// </summary>
        public void Redirect_user()
        {
            switch (Properties.Settings.Default.S_LEVEL)
            {
                case "MNF":
                    new Dashboard.Frm_DashboardManufaktur(DbConn).Show();
                    this.Hide();
                    break;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            CLogin.Username = Txt_Username.Text;
            CLogin.Password = Txt_Password.Text;

            if (CLogin.Do_login())
            {
                MessageBox.Show(
                    this,
                    string.Format("Selamat datang {0}.", Properties.Settings.Default.S_USER_NAME),
                    "Login Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Redirect_user();
            } 
            else
            {
                MessageBox.Show(
                    this,
                    "Maaf, Username atau password yang anda masukan tidak sesuai.\nSilahkan coba lagi.",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Txt_Password.Clear();
                Txt_Password.Focus();
            }
        }

        private void Btn_Batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lnbl_Lupa_password_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Maaf, fitur ini masih dalam pengembangan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Txt_Password.Focus();
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Btn_Login.PerformClick();
        }
    }
}
