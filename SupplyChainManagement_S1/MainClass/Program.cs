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
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

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
            CultureInfo culture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = culture;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new UI.Main.Frm_Login());
            Application.Run(new UI.Manufaktur.Frm_Dashboard());
        }
    }
}
