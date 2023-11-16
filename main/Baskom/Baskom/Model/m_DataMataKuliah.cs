using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataMataKuliah
    {
        private int id_matkul;
        private string kata_kunci;
        private string kode_matkul;
        private string nama_matkul;
        private int sks;

        public m_DataMataKuliah()
        {
            //konstruktor
        }

        public Array[] getMataKuliahByNama(string nama_matkul)
        {
            Array[] result = new Array[1];
            return result;
        }
    }
}
