//
//    ______    _   _           _  __      _   _     ____   ___  
//   |  ____|  | | | |         | |/ _|    | | | |   |___ \ / _ \ 
//   | |__ __ _| |_| |__   __ _| | |_ __ _| |_| |__   __) | | | |
//   |  __/ _` | __| '_ \ / _` | |  _/ _` | __| '_ \ |__ <| | | |
//   | | | (_| | |_| | | | (_| | | || (_| | |_| | | |___) | |_| |
//   |_|  \__,_|\__|_| |_|\__,_|_|_| \__,_|\__|_| |_|____/ \___/ 
// 
// Licensed under GNU General Public License v3.0
// http://www.gnu.org/licenses/gpl-3.0.txt
// Written by Fathalfath30. Email : fathalfath30@gmail.com
// Follow me on GithHub : https://github.com/Fathalfath30
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SupplyChainManagement_S1.MainClass
{
    /// <summary>
    /// Class Program, class yang akan dijalankan pertama kali 
    /// pada saat user menggunakan aplikasi ini. 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Method utama yang digunakan untuk mengakses aplikasi.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        public static void Main(string[] args)
        {
            Properties.Settings.Default.S_USER_ID = "MNF001";
            Properties.Settings.Default.S_USER_NAME = "Admin Manufaktur A";
            Properties.Settings.Default.S_USERNAME = "manufaktur01";
            Properties.Settings.Default.S_LEVEL = "9";
            Properties.Settings.Default.S_TYPE = "MNF";
            Properties.Settings.Default.Save();

            // var StartupForm = new UI.Dashboard.Frm_DashboardManufaktur();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.Dashboard.Frm_DashboardManufaktur());
            // StartupForm.Focus();
        }
    }
}
