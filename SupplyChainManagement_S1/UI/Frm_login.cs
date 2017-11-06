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

            DbConn.OpenConnection();
        }
    }
}
