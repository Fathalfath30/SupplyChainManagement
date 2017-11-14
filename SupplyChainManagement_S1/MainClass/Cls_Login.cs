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
using MySql;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SupplyChainManagement_S1.MainClass
{
    public class Cls_Login
    {
        private string Fld_Username;
        private string Fld_password;
        private string strConn = Properties.Settings.Default.STR_CONN;

        /// <summary>
        /// Username user.
        /// </summary>
        public string Username
        {
            set { Fld_Username = value.Trim(); }
            get { return Fld_Username.Trim(); }
        }

        /// <summary>
        /// Password user, secara otomatis akan di enkripsi menggunakan
        /// fungsi kriptografi MD5.
        /// </summary>
        public string Password
        {
            set { Fld_password = Cls_Security.GetMD5(value.Trim()); }
            get { return Fld_password.Trim(); }
        }

        /// <summary>
        /// Method untuk memeriska username dan password supplier
        /// </summary>
        /// <returns>bool</returns>
        private bool Supplier_login()
        {
            try
            {
                using (MySqlConnection sqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "SELECT kd_supplier AS 'ID_USER', username AS 'USERNAME', password AS 'PASSWORD', ";
                    Query += "nama_user AS 'NAMA_USER', telp_user 'NOTELP', status_user AS 'STATUS_USER' ";
                    Query += "FROM user_supplier WHERE username=@p1 AND password=@p2";

                    MySqlCommand SqlCmd = new MySqlCommand(Query, sqlConn);
                    SqlCmd.Parameters.AddWithValue("@p1", Username.Trim());
                    SqlCmd.Parameters.AddWithValue("@p2", Password.Trim());
                    sqlConn.Open();
                    MySqlDataReader sReader = SqlCmd.ExecuteReader();

                    if (sReader.Read())
                    {
                        Properties.Settings.Default.S_USER_ID = sReader.GetString("ID_USER");
                        Properties.Settings.Default.S_USER_NAME = sReader.GetString("NAMA_USER");
                        Properties.Settings.Default.S_USERNAME = sReader.GetString("USERNAME");
                        Properties.Settings.Default.S_LEVEL = sReader.GetString("STATUS_USER");
                        Properties.Settings.Default.S_TYPE = "SPL";

                        Properties.Settings.Default.Save();

                        sReader.Close();
                        return true;
                    }
                    else
                    {
                        sReader.Close();
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Fatal Error :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }
        }

        /// <summary>
        /// Method untuk memeriska username dan password manufaktur
        /// </summary>
        /// <returns>bool</returns>
        private bool Manufaktur_login()
        {
            try
            {
                using (MySqlConnection sqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "SELECT kd_manufaktur AS 'ID_USER', username AS 'USERNAME', password AS 'PASSWORD', ";
                    Query += "nama_user AS 'NAMA_USER', telp_user 'NOTELP', status_user AS 'STATUS_USER' ";
                    Query += "FROM user_manufaktur WHERE username=@p1 AND password=@p2";

                    MySqlCommand SqlCmd = new MySqlCommand(Query, sqlConn);
                    SqlCmd.Parameters.AddWithValue("@p1", Username.Trim());
                    SqlCmd.Parameters.AddWithValue("@p2", Password.Trim());
                    sqlConn.Open();
                    MySqlDataReader sReader = SqlCmd.ExecuteReader();

                    if (sReader.Read())
                    {
                        Properties.Settings.Default.S_USER_ID = sReader.GetString("ID_USER");
                        Properties.Settings.Default.S_USER_NAME = sReader.GetString("NAMA_USER");
                        Properties.Settings.Default.S_USERNAME = sReader.GetString("USERNAME");
                        Properties.Settings.Default.S_LEVEL = sReader.GetString("STATUS_USER");
                        Properties.Settings.Default.S_TYPE = "MNF";

                        Properties.Settings.Default.Save();

                        sReader.Close();
                        return true;
                    }
                    else
                    {
                        sReader.Close();
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Fatal Error :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }
        }

        /// <summary>
        /// Memeriksa apakah username dan password tersimpan di dalam 
        /// database.
        /// </summary>
        /// <returns></returns>
        public bool Do_login()
        {
            if (Manufaktur_login())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}