using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataPengajuanMitra
    {
        private string deskripsi_mitra;
        private int id_pengajuan;
        private string nama_mitra;
        private bool? status_validasi = null;

        public m_DataPengajuanMitra()
        {
            // constructor
        }

        public void getPengajuanMitra() { }
        public void sendPengajuanMitra(string nama_mitra, string deskripsi_mitra) { }
    }
}
