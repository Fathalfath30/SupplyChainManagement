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

namespace SupplyChainManagement_S1.MainClass
{
    public class App_Data
    {

        /// <summary>
        /// Data tipe barang.
        /// <para>Tipe_Barang[n, 0] : Kode tipe barang.</para>
        /// <para>Tipe_Barang[n, 1] : Nama tipe barang.</para>
        /// </summary>
        public string[,] Tipe_Barang = {
            {"", "-Pilih Tipe Barang-" },
            {"0", "Bahan Baku"},
            {"1", "Barang Jadi"}
        };

        /// <summary>
        /// Data barang.
        /// <para>Data_Barang[n, 0] : Kode Barang</para>
        /// <para>Data_Barang[n, 1] : Nama Barang</para>
        /// <para>Data_Barang[n, 2] : Jenis Barang</para>
        /// <para>Data_Barang[n, 3] : Stock Minimal</para>
        /// <para>Data_Barang[n, 4] : Stock Maximal</para>
        /// </summary>
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
            {"BRG011", "Bango RFL 85ML", "Barang Jadi", "10", "50"},
            {"BRG012", "Bango RFL 35ML", "Barang Jadi", "10", "50"},
        };

        /// <summary>
        /// Data Supplier
        /// <para>Data_Supplier[n , 0] : Kode Supplier</para>
        /// <para>Data_Supplier[n , 1] : Nama Supplier</para>
        /// <para>Data_Supplier[n , 2] : Kota Supplier</para>
        /// <para>Data_Supplier[n , 3] : Telp supplier</para>
        /// </summary>
        public string[,] Data_Supplier = {
            {"SUP001", "Poktan Marsudi Tani", "Sumber Agung, Ngajuk, Jawa Timur", "+9999999999999"},
            {"SUP002", "PT. UGM", "Sleman Jogjakarta", "+9999999999999"},
            {"SUP003", "PT. Dolphin", "Cikupa, Tangerang", "+9999999999999"},
            {"SUP004", "PT. Garam Briket Kuda Laut", "Pati, Jawa Tengah", "+9999999999999"},
            {"SUP005", "PT. Berlina TBK", "Tangerang, Banten", "+9999999999999"},
            {"SUP006", "PT. Sentral Jawa", "Banyumas, Jawa Tengah", "+9999999999999"},
            {"SUP007", "PT. Anugrah Bergula", "Cilacap, Jawa Tengah", "+9999999999999" }
        };

        /// <summary>
        /// Data Detil Supplier
        /// <para>Data_Detil_Supplier[n, 0] : Kode Supplier</para>
        /// <para>Data_Detil_Supplier[n, 1] : Nama Supplier</para>
        /// <para>Data_Detil_Supplier[n, 2] : Nama Barang</para>
        /// <para>Data_Detil_Supplier[n, 3] : Alamat</para>
        /// <para>Data_Detil_Supplier[n, 4] : Stock Tersdia</para>
        /// <para>Data_Detil_Supplier[n, 5] : Telp</para>
        /// </summary>
        public string[,] Data_Detil_Supplier = {
            {"SUP001", "Poktan Marsudi Tani", "Kedelai Hitam", "Sumber Agung, Ngajuk, Jawa Timur", "250 Ton", "21000000","+9999999999999" },
            {"SUP002", "PT. UGM", "Kedelai Hitam", "Sleman Jogjakarta", "120 Ton", "20253000","+9999999999999" },
            {"SUP003", "PT. Dolphin", "Garam", "Cikupa, Tangerang", "75 Ton", "35615000","+9999999999999" },
            {"SUP004", "PT. Garam Briket Kuda Laut", "Garam", "Pati, Jawa Tengah", "540 Ton", "34256000","+9999999999999" },
            {"SUP005", "PT. Berlina TBK", "Kemasan Plastik", "Tangerang, Banten", "750 Lembar","750","+9999999999999" },
            {"SUP005", "PT. Berlina TBK", "Kemasan Botol", "Tangerang, Banten", "960 Lembar", "1000","+9999999999999" },
            {"SUP006", "PT. Sentral Jawa", "Gula Merah", "Banyumas, Jawa Tengah", "162 Ton", "26345000","+9999999999999" },
            {"SUP007", "PT. Anugrah Bergula", "Gula Merah", "Cilacap, Jawa Tengah", "120 Ton","21525000","+9999999999999" },
        };

        /// <summary>
        /// Data Produksi
        /// <para>Data_Produksi[n, 0] : Kode Produksi</para>
        /// <para>Data_Produksi[n, 1] : Kode Manufaktur</para>
        /// <para>Data_Produksi[n, 2] : Nama Manufaktur</para>
        /// <para>Data_Produksi[n, 3] : Nama Barang</para>
        /// <para>Data_Produksi[n, 4] : Tanggal Produksi</para>
        /// <para>Data_Produksi[n, 5] : Jumlah Produksi</para>
        /// </summary>
        public string[,] Data_Produksi = {
                {"PRD001", "MNF001", "Manufaktur A", "Bango BTL 135ML", "15 November 2017", "15"},
                {"PRD002", "MNF002", "Manufaktur B", "Bango BTL 275ML", "15 November 2017", "25"},
                {"PRD003", "MNF003", "Manufaktur C", "Bango BTL 620ML", "15 November 2017", "25"},
                {"PRD004", "MNF001", "Manufaktur A", "Bango RFL 600ML", "15 November 2017", "25"},
                {"PRD005", "MNF002", "Manufaktur B", "Bango RFL 220ML", "15 November 2017", "35"},
                {"PRD006", "MNF003", "Manufaktur C", "Bango RFL 85ML", "15 November 2017", "45"},
                {"PRD007", "MNF003", "Manufaktur C", "Bango RFL 35ML", "15 November 2017", "51"},
        };

        /// <summary>
        /// Data Distributor
        /// <para>Data_Distributor[n, 0] : Kode Distributor</para>
        /// <para>Data_Distributor[n, 1] : Nama distributor</para>
        /// <para>Data_Distributor[n, 2] : Alamat Distributor</para>
        /// <para>Data_Distributor[n, 3] : Telp Distributor</para>
        /// <para>Data_Distributor[n, 4] : Kapastias Gudang</para>
        /// </summary>
        public string[,] Data_Distributor =
        {
            {"DST001", "Distributor A", "Rawa Belong, Jakarta Barat", "+9999999999999" , "250 Ton", "Siap Kirim" },
            {"DST002", "Distributor B", "Palmerah, Jakarta Barat", "+9999999999999" , "150 Ton", "Siap Kirim"},
            {"DST003", "Distributor C", "Osaka, Jepang.", "+9999999999999" , "650 Ton", "Sedang Mengirim"},
            {"DST004", "Distributor D", "Singapura", "+9999999999999" , "550 Ton", "Siap Kirim"},
        };
        /// <summary>
        /// Data Surat Pesan Bahan Baku
        /// <para>Data_SpBahanBaku[n, 0] : Kode </para>
        /// <para>Data_SpBahanBaku[n, 1] : Data Supplier</para>
        /// <para>Data_SpBahanBaku[n, 2] : Nama Supplier</para>
        /// <para>Data_SpBahanBaku[n, 3] : Tanggal SP</para>
        /// <para>Data_SpBahanBaku[n, 4] : Bahan Baku</para>
        /// <para>Data_SpBahanBaku[n, 5] : Harga Beli</para>
        /// <para>Data_SpBahanBaku[n, 6] : DP</para>
        /// <para>Data_SpBahanBaku[n, 7] : Jumlah Pesanan</para>
        /// <para>Data_SpBahanBaku[n, 8] : Status Pesanan</para>
        /// </summary>
        public string[,] Data_SpBahanBaku =
        {
            {"SPM001", "SUP001", "Poktan Marsudi Tani", "12 November 2017", "Kedelai Hitam", "76000000", "10000000", "20", "Sedang Proses", "Mobil Box A"},
            {"SPM002", "SUP001", "Poktan Marsudi Tani", "10 Januari 2017", "Kedelai Hitam", "35000000", "0", "20", "Sudah Diterima", "Mobil Box B"},
        };

        /// <summary>
        /// Data Jadwal Produksi
        /// Data_Jadwal_Produksi[n , 0] : Kode Jadwal
        /// Data_Jadwal_Produksi[n , 1] : Nama Manufaktur
        /// Data_Jadwal_Produksi[n , 2] : Nama Barang
        /// Data_Jadwal_Produksi[n , 3] : Tanggal Produksi
        /// Data_Jadwal_Produksi[n , 4] : Target Produksi
        /// </summary>
        public string[,] Data_Jadwal_Produksi = {
            {"JRD001", "Manufaktur A", "Bango BTL 135ML", "27 November 2018", "25" },
            {"JRD002", "Manufaktur A", "Bango BTL 275ML", "27 November 2018", "35" },
            {"JRD003", "Manufaktur A", "Bango BTL 620ML", "27 November 2018", "21" },
            {"JRD004", "Manufaktur A", "Bango BTL 600ML", "27 November 2018", "26" },
            {"JRD005", "Manufaktur A", "Bango BTL 220ML", "27 November 2018", "21" },
            {"JRD006", "Manufaktur A", "Bango BTL 85ML", "27 November 2018", "61" },
            {"JRD007", "Manufaktur A", "Bango BTL 35ML", "27 November 2018", "25" },
            {"JRD008", "Manufaktur A", "Bango BTL 135ML", "29 November 2018", "35" },
            {"JRD009", "Manufaktur A", "Bango BTL 275ML", "29 November 2018", "55" },
            {"JRD010", "Manufaktur A", "Bango BTL 620ML", "29 November 2018", "45" },
            {"JRD011", "Manufaktur A", "Bango BTL 600ML", "29 November 2018", "24" },
            {"JRD012", "Manufaktur A", "Bango BTL 220ML", "29 November 2018", "21" },
            {"JRD013", "Manufaktur A", "Bango BTL 85ML", "29 November 2018", "11" },
            {"JRD014", "Manufaktur A", "Bango BTL 35ML", "29 November 2018", "21" }
        };
    }
}
