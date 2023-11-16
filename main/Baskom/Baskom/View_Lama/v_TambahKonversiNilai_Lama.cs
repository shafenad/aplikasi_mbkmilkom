using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.View_Lama
{
    class v_TambahKonversiNilai_Lama
    {
        private c_KonversiNilai c_KonversiNilai = new c_KonversiNilai();

        public v_TambahKonversiNilai_Lama()
        {
            // constructor
        }

        public void klikSimpan()
        {
            string file_laporan_akhir = "dummy";
            int konversinilai_id_mahasiswa = 1;
            int konversinilai_id_matkul = 1;
            bool status_validasi = true;

            c_KonversiNilai.konversiNilai(file_laporan_akhir, konversinilai_id_mahasiswa, konversinilai_id_matkul, status_validasi);
        }
    }
}
