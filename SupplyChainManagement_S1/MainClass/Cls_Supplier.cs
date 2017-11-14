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
    public class Cls_Supplier : Model<Cls_Supplier>
    {
        private string strConn = Properties.Settings.Default.STR_CONN;
        private string _KodeSupplier;
        private string _KodeBarang;
        private string _NamaSupplier;
        private string _NamaBarang;
        private string _Kota;
        private string _Telp;
        private int _StockTersedia;
        private int _HargaBarang;

        public string KodeSupplier
        {
            set { _KodeSupplier = value.Trim(); }
            get { return _KodeSupplier.Trim(); }
        }
        public string KodeBarang
        {
            set { _NamaSupplier = value.Trim(); }
            get { return _NamaSupplier.Trim(); }
        }
        public string NamaSupplier
        {
            set { _NamaSupplier = value.Trim(); }
            get { return _NamaSupplier.Trim(); }
        }

        public string NamaBarang
        {
            set { _NamaBarang = value.Trim(); }
            get { return _NamaBarang.Trim(); }
        }
        public string Kota
        {
            set { _Kota = value.Trim(); }
            get { return _Kota.Trim(); }
        }
        public string Telp
        {
            set { _Telp = value.Trim(); }
            get { return _Telp.Trim(); }
        }
        public int StockTersedia
        {
            set { _StockTersedia = value; }
            get { return _StockTersedia; }
        }
        public int HargaBarang
        {
            set { _HargaBarang = value; }
            get { return _HargaBarang; }
        }

        public string auto_number()
        {
            throw new NotImplementedException();
        }

        public int rowCount()
        {
            int row = 0;
            try
            {
                using (MySqlConnection sqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "SELECT count(a.kd_supplier) AS Rows ";
                    Query += "FROM supplier a ";
                    Query += "INNER JOIN detil_supplier b ON a.kd_supplier = b.kd_supplier ";
                    Query += "INNER JOIN barang c ON b.kd_barang = c.kd_barang;";
                    MySqlCommand SqlCmd = new MySqlCommand(Query, sqlConn);
                    sqlConn.Open();
                    MySqlDataReader sReader = SqlCmd.ExecuteReader();
                    while (sReader.Read())
                    {
                        row = sReader.GetInt32("Rows");
                    }
                    sqlConn.Dispose();
                    sReader.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Fatal Error :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return 0;
            }
            return row;
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

        public List<Cls_Supplier> Tampil_data()
        {
            List<Cls_Supplier> appData = new List<Cls_Supplier>();

            try
            {
                using (MySqlConnection sqlConn = new MySqlConnection(strConn))
                {
                    string Query;
                    Query = "SELECT a.kd_supplier AS 'KODE_SUPPLIER', nm_supplier AS 'NAMA_SUPPLIER', ";
                    Query += "kota AS 'KOTA_SUPPLIER', c.kd_barang AS 'KODE_BARANG', nm_barang AS 'NAMA_BARANG', ";
                    Query += "stock_tersedia AS 'STOCK_TERSEDIA', harga_satuan AS 'HARGA_SATUAN' ";
                    Query += "FROM supplier a ";
                    Query += "INNER JOIN detil_supplier b ON a.kd_supplier = b.kd_supplier ";
                    Query += "INNER JOIN barang c ON b.kd_barang = c.kd_barang ";
                    Query += "ORDER BY nm_supplier ASC; ";
                    MySqlCommand SqlCmd = new MySqlCommand(Query, sqlConn);
                    sqlConn.Open();
                    MySqlDataReader sReader = SqlCmd.ExecuteReader();
                    while (sReader.Read())
                    {
                        Cls_Supplier CSupplier = new Cls_Supplier();
                        CSupplier.KodeSupplier = sReader.GetString("KODE_SUPPLIER");
                        CSupplier.KodeBarang = sReader.GetString("KODE_BARANG");
                        CSupplier.NamaSupplier = sReader.GetString("NAMA_SUPPLIER");
                        CSupplier.NamaBarang = sReader.GetString("NAMA_BARANG");
                        CSupplier.StockTersedia = sReader.GetInt32("STOCK_TERSEDIA");
                        CSupplier.HargaBarang = sReader.GetInt32("HARGA_SATUAN");
                    }
                    sqlConn.Dispose();
                    sReader.Dispose();
                }

                return appData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, string.Format("Fatal Error :\n{0}", ex.Message), "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        public List<Cls_Supplier> Cari_data(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
