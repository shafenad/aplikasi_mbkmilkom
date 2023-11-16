using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Mitra
    {
        private m_DataBkp m_DataBkp = new m_DataBkp();
        private m_DataMitra m_DataMitra = new m_DataMitra();
        private m_DataPengajuanMitra m_DataPengajuanMitra = new m_DataPengajuanMitra();

        public c_Mitra()
        {
            // constructor
        }

        public void melihatMitra() { }
        public void menerimaPengajuanMitra(int id_mahasiswa) { }
        public void showMelihatMitra() { }
        public void showMenerimaPengajuanMitra() { }

        public void tambahMitra(string bkp, string nama_mitra, int id_mahasiswa, bool status_pkl, string no_wa, int jumlah_sks, string nama_dosen, string bukti_penerimaan)
        {
            //tambahMitra
        }

        public void tambahPengajuanMitra(string nama_mitra, string deskripsi_mitra)
        {
            //tambahPengajuanMitra
        }
    }
}
