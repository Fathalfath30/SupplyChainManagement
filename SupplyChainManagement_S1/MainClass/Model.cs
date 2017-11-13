using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SupplyChainManagement_S1.MainScript
{
    public interface Model
    {
        string auto_number();
        int rowCount();
        bool Tambah_data();
        bool Update_data();
        bool Hapus_data();
        List<Object> Tampil_data();
        List<Object> Cari_data();
    }
}