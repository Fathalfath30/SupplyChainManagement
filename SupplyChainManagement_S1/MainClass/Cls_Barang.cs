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
    public class Cls_Barang : Model
    {
        private string Fld_KdBarang;
        private string Fld_NmBarang;
        private int Fld_MinStock;
        private int Fld_MaxStock;
        private int Fld_TipeBarang;

        public string KodeBarang
        {
            set { Fld_KdBarang = value.Trim(); }
            get { return Fld_NmBarang.Trim(); }
        }

        public string NamaBarang
        {
            set { Fld_NmBarang = value.Trim(); }
            get { return Fld_NmBarang.Trim(); }
        }

        public int MinStock
        {
            set { Fld_MinStock = value; }
            get { return MinStock; }
        }

        public int MaxStock
        {
            set { Fld_MaxStock = value; }
            get { return Fld_MaxStock; }
        }

        public int TipeBarang
        {
            set { Fld_TipeBarang = value; }
            get { return Fld_TipeBarang; }
        }

        /// <summary>
        /// Mendapatkan Kode Barang.
        /// </summary>
        /// <returns></returns>
        public string auto_number()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(""))
            {
                string Main_id = "BRG001";
                try
                {
                    string Query = "SELECT RIGHT(kd_barang, 3) AS KODE_BARANG FROM barang ORDER BY kd_barang DESC LIMIT 1";
                    MySqlCommand MySqlCmd = new MySqlCommand(Query, sqlConn);
                    sqlConn.Open();
                    MySqlDataReader MysqlReader = MySqlCmd.ExecuteReader();
                    if (MysqlReader.Read())
                    {
                        int Last_id = MysqlReader.GetInt32("KODE_BARANG");
                        Main_id = string.Format("BRG{0:000}", Last_id + 1);
                        return Main_id;
                    }
                    MysqlReader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Application.Exit();
                }

                return Main_id;
            }

        }

        /// <summary>
        /// Mendapatkan Jumlah data barang
        /// </summary>
        /// <returns>Jumlah data barang</returns>
        public int rowCount()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(""))
            {
                int rCount = 0;
                try
                {
                    string Query = "SELECT COUNT(kd_barang) AS ROW_COUNT FROM barang;";
                    MySqlCommand MySqlCmd = new MySqlCommand(Query, sqlConn);
                    sqlConn.Open();
                    MySqlDataReader MysqlReader = MySqlCmd.ExecuteReader();
                    if (MysqlReader.Read())
                        rCount = MysqlReader.GetInt32("ROW_COUNT");

                    MysqlReader.Close();
                    return rCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    Application.Exit();
                }
                return rCount;
            }

        }

        public bool Tambah_data()
        {
            throw new NotImplementedException();
        }

        public bool Update_data()
        {
            throw new NotImplementedException();
        }

        public bool Hapus_data()
        {
            throw new NotImplementedException();
        }

        public List<object> Tampil_data()
        {
            throw new NotImplementedException();
        }

        public List<object> Cari_data()
        {
            throw new NotImplementedException();
        }
    }
}