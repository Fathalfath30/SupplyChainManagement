using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupplyChainManagement_S1.MainClass
{
    public interface Model <T>
    {
        string auto_number();
        int rowCount();
        bool Tambah_data();
        bool Update_data();
        bool Hapus_data();
        List<T> Tampil_data();
        List<T> Cari_data(string keyword);
    }
}