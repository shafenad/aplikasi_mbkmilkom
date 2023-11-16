using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_TambahMitra_Lama
    {
        private c_Mitra c_Mitra = new c_Mitra();

        public void klikSimpan()
        {
            string bkp = "dummy";
            string nama_mitra = "dummy";
            int id_mahasiswa = 1;
            bool status_pkl = true;
            string no_wa = "dummy";
            int jumlah_sks = 1;
            string nama_dosen = "dummy";
            string bukti_penerimaan = "dummy";


            c_Mitra.tambahMitra(bkp, nama_mitra, id_mahasiswa, status_pkl, no_wa, jumlah_sks, nama_dosen, bukti_penerimaan);
        }
    }
}
