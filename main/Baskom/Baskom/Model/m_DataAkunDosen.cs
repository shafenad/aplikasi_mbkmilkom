using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunDosen
    {
        private string email;
        private int id_dosen;
        private string jabatan;
        private string kata_sandi;
        private string nama_dosen;
        private string nidn;
        private string nip;
        private string no_wa;

        private Array[] getDosen()
        {
            Array[] result = new Array[1];
            return result;
        }

        private Array[] getDosenById(int id_dosen)
        {
            Array[] result = new Array[1];
            return result;
        }

        private Array[] getDosenByNidn(string nidn)
        {
            Array[] result = new Array[1];
            return result;
        }
    }
}
