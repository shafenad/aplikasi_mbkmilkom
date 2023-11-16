using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataPenerimaan
    {
        private int id_penerimaan;
        private string bukti_penerimaan;
        private int jumlah_sks;
        private string no_wa;
        private int penerimaan_id_bkp;
        private int penerimaan_id_dosen;
        private int penerimaan_id_mahasiswa;
        private int penerimaan_id_mitra;
        private bool status_pkl;

        public m_DataPenerimaan()
        {
            //konstruktor
        }

        public void sendPenerimaan(string bukti_penerimaan, int jumlah_sks, string no_wa, Boolean status_pkl, int penerimaan_id_bkp, int penerimaan_id_dosen, int penerimaan_id_mahasiswa, int penerimaan_id_mitra) { }

    }
}
