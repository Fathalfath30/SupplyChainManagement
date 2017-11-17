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
using MySql.Data.MySqlClient;

namespace SupplyChainManagement_S1.MainClass
{
    public class App_Data
    {
        public string[,] TipeBarnag = {
                {"", "-Pilih Item-" },
                {"0", "Bahan Baku"},
                {"1", "Barang Jadi"},
            };

        public string[,] Data_Barang = {
                {"BRG001", "Kedelai Hitam", "Bahan Baku", "10", "50"},
                {"BRG002", "Garam", "Bahan Baku", "10", "35"},
                {"BRG003", "Gula Merah", "10", "Bahan Baku", "35"},
                {"BRG004", "Kemasan Plastik", "Bahan Baku", "10", "50"},
                {"BRG005", "Kemasan Botol", "Bahan Baku", "10", "50"},
                {"BRG006", "Bango BTL 135ML", "Barang Jadi", "10", "50"},
                {"BRG007", "Bango BTL 275ML", "Barang Jadi", "10", "50"},
                {"BRG008", "Bango BTL 620ML", "Barang Jadi", "10", "50"},
                {"BRG009", "Bango RFL 600ML", "Barang Jadi", "10", "50"},
                {"BRG010", "Bango RFL 220ML", "Barang Jadi", "10", "50"},
                {"BRG011", "Bango RFL 85ML", "Barnag Jadi", "10", "50"},
                {"BRG012", "Bango RFL 35ML", "Barnag Jadi", "10", "50"},

            };

        public string[,] Data_Supplier = {
                {"SUP001", "Poktan Marsudi Tani", "Sumber Agung, Ngajuk, Jawa Timur", "+9999999999999"},
                {"SUP002", "PT. UGM", "Sleman Jogjakarta", "+9999999999999"},
                {"SUP003", "PT. Dolphin", "Cikupa, Tangerang", "+9999999999999"},
                {"SUP004", "PT. Garam Briket Kuda Laut", "Pati, Jawa Tengah", "+9999999999999"},
                {"SUP005", "PT. Berlina TBK", "Tangerang, Banten", "+9999999999999"},
                {"SUP006", "PT. Sentral Jawa", "Banyumas, Jawa Tengah", "+9999999999999"},
                {"SUP007", "PT. Anugrah Bergula", "Cilacap, Jawa Tengah", "+9999999999999" }
            };

        public string[,] Detil_Supplier = {
                {"SUP001", "Poktan Marsudi Tani", "Kedelai Hitam", "Sumber Agung, Ngajuk, Jawa Timur", "250 Ton", "Rp. 000.000.000","+9999999999999" },
                {"SUP002", "PT. UGM", "Kedelai Hitam", "Sleman Jogjakarta", "120 Ton", "Rp. 000.000.000","+9999999999999" },
                {"SUP003", "PT. Dolphin", "Garam", "Cikupa, Tangerang", "75 Ton", "Rp. 000.000.000","+9999999999999" },
                {"SUP004", "PT. Garam Briket Kuda Laut", "Garam", "Pati, Jawa Tengah", "540 Ton", "Rp. 000.000.000","+9999999999999" },
                {"SUP005", "PT. Berlina TBK", "Kemasan Plastik", "Tangerang, Banten", "750 Lembar","Rp. 000.000.000","+9999999999999" },
                {"SUP005", "PT. Berlina TBK", "Kemasan Botol", "Tangerang, Banten", "960 Lembar", "Rp. 000.000.000","+9999999999999" },
                {"SUP006", "PT. Sentral Jawa", "Gula Merah", "Banyumas, Jawa Tengah", "162 Ton", "Rp. 000.000.000","+9999999999999" },
                {"SUP007", "PT. Anugrah Bergula", "Gula Merah", "Cilacap, Jawa Tengah", "120 Ton","Rp. 000.000.000","+9999999999999" },
            };

        public string[,] Data_Manufaktur = {
                {"MNF001", "Manufaktur A", "Jl. BSD Boulevard Barat Green Office Park, Jawa Timur", "+9999999999999"},
                {"MNF002", "Manufaktur B", "Wantilan, Subang, Jawa Barat", "+9999999999999"},
                {"MNF003", "Manufaktur C", "Jababeka, Cikarang", "+9999999999999"},
            };

        public string[,] Data_Produksi =
        {
                {"PRD001", "MNF001", "Manufaktur A", "Bango BTL 135ML", "15 November 2017", "15"},
                {"PRD002", "MNF002", "Manufaktur B", "Bango BTL 275ML", "15 November 2017", "25"},
                {"PRD003", "MNF003", "Manufaktur C", "Bango BTL 620ML", "15 November 2017", "25"},
                {"PRD004", "MNF001", "Manufaktur A", "Bango RFL 600ML", "15 November 2017", "25"},
                {"PRD005", "MNF002", "Manufaktur B", "Bango RFL 220ML", "15 November 2017", "35"},
                {"PRD006", "MNF003", "Manufaktur C", "Bango RFL 85ML", "15 November 2017", "45"},
                {"PRD007", "MNF003", "Manufaktur C", "Bango RFL 35ML", "15 November 2017", "51"},
        };

        public string[,] Data_SpBahanBaku =
        {
            {"SPM001", "SUP001", "Poktan Marsudi Tani", "12 November 2017", "Kedelai Hitam", "Rp. 76.000.000", "Rp. 10.000.000", "Sedang Proses"},
            {"SPM002", "SUP001", "Poktan Marsudi Tani", "10 Januari 2017", "Kedelai Hitam", "Rp. 35.000.000", "Rp. 0", "Sudah Diterima"},
        };

        public string[,] Data_Distributor =
        {
            {"DST001", "Distributor A", "Rawa Belong, Jakarta Barat", "+9999999999999" , "250 Ton"},
            {"DST001", "Distributor B", "Palmerah, Jakarta Barat", "+9999999999999" , "150 Ton"},
            {"DST001", "Distributor C", "Osaka, Jepang.", "+9999999999999" , "650 Ton"},
            {"DST001", "Distributor D", "Singapura", "+9999999999999" , "550 Ton"},
        };
    }
}
