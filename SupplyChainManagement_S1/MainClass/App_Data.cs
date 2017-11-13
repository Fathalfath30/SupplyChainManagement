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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using SupplyChainManagement_S1.MainScript;
using MySql.Data.MySqlClient;

namespace SupplyChainManagement_S1.MainClass
{
    public class App_Data
    {

        public DataTable TableTipeBarang()
        {
            DataTable DTable = new DataTable("tipe_barang");

            DTable.Columns.Add(new DataColumn("ID", typeof(string)));
            DTable.Columns.Add(new DataColumn("NAME", typeof(string)));

            string[,] tData = {
                {"", "-Pilih Item-" },
                {"0", "Bahan Baku"},
                {"1", "Barang Jadi"},
                {"2", "MRO" }

            };

            for (int i = 0; i < tData.GetLength(0); i++)
            {
                DataRow DRows = DTable.NewRow();
                DRows["ID"] = tData[i, 0];
                DRows["NAME"] = tData[i, 1];

                DTable.Rows.Add(DRows);
            }

            return DTable;
        }

        public DataTable TableBarang()
        {
            DataTable DTable = new DataTable("barang");

            DTable.Columns.Add(new DataColumn("ID", typeof(string)));
            DTable.Columns.Add(new DataColumn("NAME", typeof(string)));
            DTable.Columns.Add(new DataColumn("MIN_STOCK", typeof(string)));
            DTable.Columns.Add(new DataColumn("MAX_STOCK", typeof(string)));
            DTable.Columns.Add(new DataColumn("TIPE_BARANG", typeof(string)));

            string[,] tData = {
                {"BRG001", "Kedelai Hitam", "10", "50", "0"},
                {"BRG002", "Garam", "10", "35", "0"},
                {"BRG003", "Gula Merah", "10", "35", "0"},
                {"BRG004", "Kemasan Plastik", "10", "50", "0"},
                {"BRG005", "Kemasan Botol", "10", "50", "0"},
                {"BRG006", "Bango BTL 135ML", "10", "50", "2"},
                {"BRG007", "Bango BTL 275ML", "10", "50", "2"},
                {"BRG008", "Bango BTL 620ML", "10", "50", "2"},
                {"BRG009", "Bango RFL 600ML", "10", "50", "2"},
                {"BRG010", "Bango RFL 220ML", "10", "50", "2"},
                {"BRG011", "Bango RFL 85ML", "10", "50", "2"},
                {"BRG012", "Bango RFL 35ML", "10", "50", "2"},

            };

            for (int i = 0; i < tData.GetLength(0); i++)
            {
                DataRow DRows = DTable.NewRow();
                DRows["ID"] = tData[i, 0];
                DRows["NAME"] = tData[i, 1];
                DRows["MIN_STOCK"] = tData[i, 2];
                DRows["MAX_STOCK"] = tData[i, 3];
                DRows["TIPE_BARANG"] = tData[i, 4];

                DTable.Rows.Add(DRows);
            }

            return DTable;
        }

        /// <summary>
        /// Method yang digunakan untuk menginisialisasi data supplier
        /// </summary>
        public DataTable TableSupplier()
        {
            DataTable DTable = new DataTable("supplier");

            DTable.Columns.Add(new DataColumn("ID", typeof(string)));
            DTable.Columns.Add(new DataColumn("NAME", typeof(string)));
            DTable.Columns.Add(new DataColumn("ADDR", typeof(string)));
            DTable.Columns.Add(new DataColumn("PHONE", typeof(string)));

            string[,] tData = {
                {"SUP001", "Poktan Marsudi Tani", "Sumber Agung, Ngajuk, Jawa Timur", "+9999999999999"},
                {"SUP002", "PT. UGM", "Sleman Jogjakarta", "+9999999999999"},
                {"SUP003", "PT. Dolphin", "Cikupa, Tangerang", "+9999999999999"},
                {"SUP004", "PT. Garam Briket Kuda Laut", "Pati, Jawa Tengah", "+9999999999999"},
                {"SUP005", "PT. Berlina TBK", "Tangerang, Banten", "+9999999999999"},
                {"SUP006", "PT. Sentral Jawa", "Banyumas, Jawa Tengah", "+9999999999999"},
                {"SUP007", "PT. Anugrah Bergula", "Cilacap, Jawa Tengah", "+9999999999999" }
            };

            for (int i = 0; i < tData.GetLength(0); i++)
            {
                DataRow DRows = DTable.NewRow();
                DRows["ID"] = tData[i, 0];
                DRows["NAME"] = tData[i, 1];
                DRows["ADDR"] = tData[i, 2];
                DRows["PHONE"] = tData[i, 3];

                DTable.Rows.Add(DRows);
            }
            return DTable;
        }
    }
}
