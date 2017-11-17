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

namespace SupplyChainManagement_S1.UI 
{
    public partial class Frm_login : MetroForm
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            Txt_Username.Focus();
        }

        /// <summary>
        /// Memindahkan user ke dashboardnya masing - masing
        /// jika user berhasil login.
        /// </summary>
        public void Redirect_user()
        {
            switch (Properties.Settings.Default.S_TYPE)
            {
                case "MNF":
                    new Dashboard.Frm_DashboardManufaktur().Show();
                    this.Hide();
                    break;
            }
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text != "admin")
            {
                MessageBox.Show(
                    this,
                    "Password salah",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            switch (Txt_Username.Text)
            {
                case "manufaktur":
                    new Dashboard.Frm_DashboardManufaktur().Show();
                    this.Hide();
                    break;

                case "distributor":
                    
                    break;

                case "supplier":
                    break;

                default:
                    MessageBox.Show(
                        this,
                        "Username salah",
                        "Login Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
            }
        }

        private void Btn_Batal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lnbl_Lupa_password_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this, 
                "Maaf, fitur ini masih dalam pengembangan.", 
                "Informasi", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
                );
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
