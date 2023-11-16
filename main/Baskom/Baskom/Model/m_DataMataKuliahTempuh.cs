using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataMataKuliahTempuh
    {
        private int matkultempuh_id_mahasiswa;
        private int matkultempuh_id_matkul;

        public m_DataMataKuliahTempuh()
        {
            //Konstruktor
        }

        public Array[] getMatkulByIdMahasiswa(int matkultempuh_id_mahasiswa)
        {
            Array[] result = new Array[1];
            return result;
        }

        public void sendMatkulByIdMahasiswa(int matkultempuh_id_mahasiswa, int matkultempuh_id_matkul) { }
    }
}
