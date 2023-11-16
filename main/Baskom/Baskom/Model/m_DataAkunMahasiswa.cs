using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunMahasiswa
    {
        private int batch_mbkm;
        private string email;
        private string fakultas;
        private int id_mahasiswa;
        private string kata_sandi;
        private string nama_mahasiswa;
        private string nim;
        private string no_wa;
        private string program_studi;
        private bool status_mahasiswa;
        private int tahun_masuk;

        public m_DataAkunMahasiswa()
        {
            // constructor
        }

        private Array[] getMahasiswa()
        {
            Array[] result = new Array[1];
            return result;
        }

        private Array[] getMahasiswaById(int namanya1)
        {
            Array[] result = new Array[1];
            return result;
        }

        public string[] getMahasiswaByNim(string nim, string kata_sandi)
        {
            string[] result = new string[1];
            return result;
        }
    }
}
