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


namespace SupplyChainManagement_S1.MainClass
{
    public class Cls_Barang : Model<Cls_Barang>
    {
        private string Fld_KdBarang;
        private string Fld_NmBarang;
        private string Fld_StrTipeBarang;
        private int Fld_MinStock;
        private int Fld_MaxStock;
        private int Fld_IntTipeBarang;
        private string strConn = Properties.Settings.Default.STR_CONN;

        public string KodeBarang
        {
            set { Fld_KdBarang = value.Trim(); }
            get { return Fld_KdBarang.Trim(); }
        }

        public string NamaBarang
        {
            set { Fld_NmBarang = value.Trim(); }
            get { return Fld_NmBarang.Trim(); }
        }

        public string sTipeBarang
        {
            set { Fld_StrTipeBarang = value.Trim(); }
            get { return Fld_StrTipeBarang.Trim(); }
        }

        public int MinStock
        {
            set { Fld_MinStock = value; }
            get { return Fld_MinStock; }
        }

        public int MaxStock
        {
            set { Fld_MaxStock = value; }
            get { return Fld_MaxStock; }
        }

        public int iTipeBarang
        {
            set { Fld_IntTipeBarang = value; }
            get { return Fld_IntTipeBarang; }
        }

        /// <summary>
        /// Mendapatkan Kode Barang.
        /// </summary>
        /// <returns></returns>
        public string auto_number()
        {
            using (MySqlConnection SqlConn = new MySqlConnection(strConn))
            {
                string Main_id = "BRG001";
                try
                {
                    string Query = "SELECT RIGHT(kd_barang, 3) AS KODE_BARANG FROM barang ORDER BY kd_barang DESC LIMIT 1";
                    MySqlCommand MySqlCmd = new MySqlCommand(Query, SqlConn);
                    SqlConn.Open();
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
                    MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            using (MySqlConnection SqlConn = new MySqlConnection(strConn))
            {
                int rCount = 0;
                try
                {
                    string Query = "SELECT COUNT(kd_barang) AS ROW_COUNT FROM barang;";
                    MySqlCommand MySqlCmd = new MySqlCommand(Query, SqlConn);
                    SqlConn.Open();
                    MySqlDataReader MysqlReader = MySqlCmd.ExecuteReader();
                    if (MysqlReader.Read())
                        rCount = MysqlReader.GetInt32("ROW_COUNT");

                    MysqlReader.Close();
                    return rCount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                return rCount;
            }

        }

        public bool Tambah_data()
        {
            try
            {
                using (MySqlConnection SqlConn= new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "INSERT INTO barang (kd_barang, nm_barang, min_stock, max_stock, tipe_barang) VALUES ";
                    Query += "(@p1, @p2, @p3, @p4, @p5);";
                    MySqlCommand SqlCmd = new MySqlCommand(Query, SqlConn);
                    SqlCmd.Parameters.AddWithValue("@p1", KodeBarang);
                    SqlCmd.Parameters.AddWithValue("@p2", NamaBarang);
                    SqlCmd.Parameters.AddWithValue("@p3", MinStock);
                    SqlCmd.Parameters.AddWithValue("@p4", MaxStock);
                    SqlCmd.Parameters.AddWithValue("@p5", iTipeBarang);
                    SqlConn.Open();
                    return (SqlCmd.ExecuteNonQuery() > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }
        }

        public bool Update_data()
        {
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "UPDATE barang SET nm_barang=@p2, min_stock=@p3, max_stock=@p4, tipe_barang=@p5  ";
                    Query += "WHERE kd_barang=@p1";
                    MySqlCommand SqlCmd = new MySqlCommand(Query, SqlConn);
                    SqlCmd.Parameters.AddWithValue("@p1", KodeBarang);
                    SqlCmd.Parameters.AddWithValue("@p2", NamaBarang);
                    SqlCmd.Parameters.AddWithValue("@p3", MinStock);
                    SqlCmd.Parameters.AddWithValue("@p4", MaxStock);
                    SqlCmd.Parameters.AddWithValue("@p5", iTipeBarang);
                    SqlConn.Open();
                    return (SqlCmd.ExecuteNonQuery() > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }
        }

        public bool Hapus_data()
        {
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(strConn))
                {
                    string Query = "DELETE FROM barang WHERE kd_barang=@p1";
                    MySqlCommand SqlCmd = new MySqlCommand(Query, SqlConn);
                    SqlCmd.Parameters.AddWithValue("@p1", KodeBarang);
                    SqlConn.Open();
                    return (SqlCmd.ExecuteNonQuery() > 0) ? true : false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }
        }

        public List<Cls_Barang> Tampil_data()
        {
            List<Cls_Barang> DbData = new List<Cls_Barang>();
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "SELECT ";
                    Query += "kd_barang AS 'KODE_BARANG', nm_barang AS 'NAMA_BARANG', min_stock AS 'STOCK_MINIMAL', ";
                    Query += "max_stock AS 'STOCK_MAXIMAL', tipe_barang AS 'INT_TIPE_BARANG', ";
                    Query += "(CASE WHEN tipe_barang = 0 THEN 'Bahan Baku' WHEN tipe_barang = 1 THEN 'Barang Jadi' ";
                    Query += "WHEN tipe_barang = 2 THEN 'MRO' ELSE 'n/a' END) AS 'STR_TIPE_BARANG' ";
                    Query += "FROM barang";

                    MySqlCommand SqlCmd = new MySqlCommand(Query, SqlConn);
                    SqlConn.Open();
                    MySqlDataReader sReader = SqlCmd.ExecuteReader();
                    DbData.Clear();

                    while(sReader.Read())
                    {
                        Cls_Barang CBarang = new Cls_Barang();
                        CBarang.KodeBarang = sReader.GetString("KODE_BARANG");
                        CBarang.NamaBarang = sReader.GetString("NAMA_BARANG");
                        CBarang.MinStock = sReader.GetInt32("STOCK_MINIMAL");
                        CBarang.MaxStock = sReader.GetInt32("STOCK_MAXIMAL");
                        CBarang.iTipeBarang = sReader.GetInt32("INT_TIPE_BARANG");
                        CBarang.sTipeBarang = sReader.GetString("STR_TIPE_BARANG");
                        DbData.Add(CBarang);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return DbData;
        }

        public List<Cls_Barang> Cari_data(string keyword)
        {
            List<Cls_Barang> DbData = new List<Cls_Barang>();
            try
            {
                using (MySqlConnection SqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "SELECT * FROM (SELECT ";
                    Query += "kd_barang AS 'KODE_BARANG', nm_barang AS 'NAMA_BARANG', min_stock AS 'STOCK_MINIMAL', ";
                    Query += "max_stock AS 'STOCK_MAXIMAL', tipe_barang AS 'INT_TIPE_BARANG', ";
                    Query += "(CASE WHEN tipe_barang = 0 THEN 'Bahan Baku' WHEN tipe_barang = 1 THEN 'Barang Jadi' ";
                    Query += "WHEN tipe_barang = 2 THEN 'MRO' ELSE 'n/a' END) AS 'STR_TIPE_BARANG' ";
                    Query += "FROM barang) AS TmpTable ";
                    Query += "WHERE KODE_BARANG LIKE '%{0}%' OR STR_TIPE_BARANG LIKE '%{1}%' ";
                    Query += "OR NAMA_BARANG LIKE '%{2}%' ";
                    Query += "OR STOCK_MINIMAL LIKE '%{3}%' OR STOCK_MAXIMAL LIKE '%{4}%' ";
                    MySqlCommand SqlCmd = new MySqlCommand(string.Format(Query,
                        keyword, keyword, keyword, keyword, keyword), SqlConn);
                    SqlCmd.Parameters.AddWithValue("@p1", keyword.Trim());
                    System.Diagnostics.Debug.WriteLine(SqlCmd.CommandText);
                    SqlConn.Open();

                    MySqlDataReader sReader = SqlCmd.ExecuteReader();
                    DbData.Clear();

                    while (sReader.Read())
                    {
                        Cls_Barang CBarang = new Cls_Barang();
                        CBarang.KodeBarang = sReader.GetString("KODE_BARANG");
                        CBarang.NamaBarang = sReader.GetString("NAMA_BARANG");
                        CBarang.MinStock = sReader.GetInt32("STOCK_MINIMAL");
                        CBarang.MaxStock = sReader.GetInt32("STOCK_MAXIMAL");
                        CBarang.iTipeBarang = sReader.GetInt32("INT_TIPE_BARANG");
                        CBarang.sTipeBarang = sReader.GetString("STR_TIPE_BARANG");
                        DbData.Add(CBarang);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Telah terjadi kesalahan :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            return DbData;
        }
    }
}