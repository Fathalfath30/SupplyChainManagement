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

namespace SupplyChainManagement_S1.MainScript
{
    public class Cls_Login
    {
        private string Fld_Username;
        private string Fld_password;
        private Cls_DbConnection DbConn;

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
        /// Constrcutor
        /// </summary>
        /// <param name="ClsDbConn"></param>
        public Cls_Login(Cls_DbConnection ClsDbConn)
        {
            DbConn = ClsDbConn;
        }

        /// <summary>
        /// Memeriksa apakah username dan password tersimpan di dalam 
        /// database.
        /// </summary>
        /// <returns></returns>
        public bool Do_login()
        {
            try
            {
                string Query = "SELECT" +
                      " id_user AS 'ID_USER', nama_user AS 'NAMA_USER', username AS 'USERNAME', password AS 'PASSWORD', level_user AS 'LEVEL_USER'" +
                      " FROM user WHERE username=@p1 AND password=@p2 LIMIT 1";
                MySqlConnection MySqlConn = DbConn.Connection;
                MySqlCommand MySqlCmd = new MySqlCommand(Query, MySqlConn);
                MySqlCmd.Parameters.AddWithValue("@p1", Username);
                MySqlCmd.Parameters.AddWithValue("@p2", Password);

                if (MySqlConn.State == ConnectionState.Closed)
                    MySqlConn.Open();

                MySqlDataReader MySqlReader = MySqlCmd.ExecuteReader();
                if (MySqlReader.Read())
                {
                    Properties.Settings.Default.S_USER_ID = MySqlReader.GetString("ID_USER");
                    Properties.Settings.Default.S_USER_NAME = MySqlReader.GetString("NAMA_USER");
                    Properties.Settings.Default.S_USERNAME = MySqlReader.GetString("USERNAME");
                    Properties.Settings.Default.S_LEVEL = MySqlReader.GetString("LEVEL_USER");
                    Properties.Settings.Default.Save();

                    MySqlReader.Close();
                    return true;
                }
                else
                {
                    MySqlReader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Fatal Error :\n{0}",ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}