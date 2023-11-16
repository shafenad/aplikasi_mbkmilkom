using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataKonversiSks
    {
        private string kompetensi;
        private int konversisks_id_mahasiswa;
        private int konversisks_id_matkul;
        private bool status_validasi;

        public Array[] KonversiSksByIdMahasiswa(int konversisks_id_mahasiswa)
        {
            Array[] result = new Array[1];
            return result;
        }

        public void sendKonversiSks(string kompetensi, int konversisks_id_mahasiswa, int konversisks_id_matkul, Boolean status_validasi) { }

    }
}
