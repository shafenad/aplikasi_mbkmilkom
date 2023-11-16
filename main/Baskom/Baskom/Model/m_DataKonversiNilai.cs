using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataKonversiNilai
    {
        private string file_laporan_akhir;
        private int konversinilai_id_mahasiswa;
        private int konversinilai_id_matkul;
        private bool status_validasi;

        public m_DataKonversiNilai()
        {
            //konstruktor
        }

        public Array[] getKonversiNilaiByIdMahasiswa(int konversinilai_id_mahasiswa)
        {
            Array[] result = new Array[1];
            return result;
        }

        public void sendKonversiNilai(string file_laporan_akhir, int konversinilai_id_mahasiswa, int konversinilai_id_matkul, Boolean status_validasi) { }

    }
}
