using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_TambahPengajuanMitra_Lama
    {
        private c_Mitra c_Mitra = new c_Mitra();

        public void klikSimpan()
        {
            string nama_mitra = "dummy";
            string deskripsi_mitra = "dummy";

            c_Mitra.tambahPengajuanMitra(nama_mitra, deskripsi_mitra);
        }
    }
}
