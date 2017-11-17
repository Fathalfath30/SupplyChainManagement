using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using SupplyChainManagement_S1.MainClass;
using System.Globalization;
using System.Threading;

namespace SupplyChainManagement_S1.UI.Manufaktur
{
    public partial class Frm_Dashboard : MetroForm
    {
        /* ----- [ MAIN SCRIPT ] ----- */



        /* ----- [ GENERATED SCRIPT ] ----- */
        public Frm_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Dashboard_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = culture;
        }
    }
}
