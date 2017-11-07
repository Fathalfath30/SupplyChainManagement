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

        public string auto_number()
        {
            throw new NotImplementedException();
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