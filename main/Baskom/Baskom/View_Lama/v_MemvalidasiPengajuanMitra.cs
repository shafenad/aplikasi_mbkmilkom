using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_MemvalidasiPengajuanMitra
    {
        private c_Mitra c_Mitra = new c_Mitra();

        public void klikValidasi()
        {
            int id_mahasiswa = 1;

            c_Mitra.menerimaPengajuanMitra(id_mahasiswa);
        }
    }
}
