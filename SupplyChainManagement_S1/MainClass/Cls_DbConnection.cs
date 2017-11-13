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

namespace SupplyChainManagement_S1.MainScript
{
    public class Cls_DbConnection
    {
        /// <summary>
        /// Mysql Connection.
        /// </summary>
        private MySqlConnection Fld_SqlConnection;

        /// <summary>
        /// String koneksi.
        /// </summary>
        private string Fld_ConnString;

        /// <summary>
        /// Nama host dari Server MySql
        /// </summary>
        private string Fld_SqlHostname;

        /// <summary>
        /// Username yang digunakan.
        /// </summary>
        private string Fld_SqlUsername;

        /// <summary>
        /// Password yang digunakan
        /// </summary>
        private string Fld_SqlPassword;

        /// <summary>
        /// Nama database yang akan digunakan.
        /// </summary>
        private string Fld_SqlDatabase;

        /// <summary>
        /// Nomor Port Server MySql.
        /// </summary>
        private int Fld_SqlPort = 3306;

        /// <summary>
        /// Mendapatkan koneksi database.
        /// </summary>
        public MySqlConnection Connection
        {
            get { return this.Fld_SqlConnection; }
        }

        /// <summary>
        /// Status koneksi aplikasi dengan server database.
        /// </summary>
        public bool ConnectionStatus
        {
            get { return (this.Fld_SqlConnection.State == ConnectionState.Open) ? true : false; }
        }

        /// <summary>
        /// Host Database Server (MySql) default : localhost / 127.0.0.1
        /// </summary>
        public string Hostname
        {
            get { return this.Fld_SqlHostname.Trim(); }
            set { this.Fld_SqlHostname = value.Trim(); }
        }

        /// <summary>
        /// Username database
        /// </summary>
        public string Username
        {
            get { return this.Fld_SqlUsername.Trim(); }
            set { this.Fld_SqlUsername = value.Trim(); }
        }

        /// <summary>
        /// Password user
        /// </summary>
        public string Password
        {
            get { return this.Fld_SqlPassword.Trim(); }
            set { this.Fld_SqlPassword = value.Trim(); }
        }

        /// <summary>
        /// Nama database
        /// </summary>
        public string Database
        {
            get { return this.Fld_SqlDatabase.Trim(); }
            set { this.Fld_SqlDatabase = value.Trim(); }
        }

        /// <summary>
        /// Nomor port server database
        /// </summary>
        public int Port
        {
            get { return this.Fld_SqlPort; }
            set { this.Fld_SqlPort = value; }
        }

        /// <summary>
        /// String koneksi
        /// </summary>
        public string ConnString
        {
            set { Fld_ConnString = value.Trim(); }
            get { return Fld_ConnString.Trim(); }
        }

        public Cls_DbConnection()
        {
            Fld_SqlConnection = new MySqlConnection();
        }

        public void closeConnection()
        {
            if (this.Fld_SqlConnection.State != ConnectionState.Closed)
                this.Fld_SqlConnection.Close();
        }

        public Cls_DbConnection initClass()
        {
            Fld_ConnString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", Hostname, Port, Database, Username, Password);
            return this;
        }

        /// <summary>
        /// Membuka koneksi dengan database server.
        /// </summary>
        public void OpenConnection()
        {
            if (Fld_SqlConnection.State != ConnectionState.Open)
            {
                try
                {
                    Fld_SqlConnection.ConnectionString = Fld_ConnString;
                    Fld_SqlConnection.Open();
                    //MessageBox.Show(null, "Berhasil terkoneksi dengan database server", "Koneksi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    DialogResult DlgResult = MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    switch (DlgResult)
                    {
                        case DialogResult.Retry:
                            this.OpenConnection();
                            break;
                        case DialogResult.Cancel:
                        default:
                            Application.Exit();
                            break;
                    }

                }
            }
        }
    }
}