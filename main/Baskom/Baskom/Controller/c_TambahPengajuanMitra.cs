using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahPengajuanMitra
    {
        private m_DataPengajuanMitra m_DataPengajuanMitra;
        private m_Data_Status_Validasi_Mitra m_Data_Status_Validasi_Mitra;

        public c_TambahPengajuanMitra(m_DataPengajuanMitra m_DataPengajuanMitra, m_Data_Status_Validasi_Mitra m_Data_Status_Validasi_Mitra)
        {
            this.m_DataPengajuanMitra = m_DataPengajuanMitra;
            this.m_Data_Status_Validasi_Mitra = m_Data_Status_Validasi_Mitra;
        }


        public List<object[]> getAllDataPengajuan()
        {
            List<object[]> result = this.m_DataPengajuanMitra.getAllPengajuanMitra();
            return result;
        }

        public List<object[]> getDataStatus()
        {
            List<object[]> result = m_Data_Status_Validasi_Mitra.getAllDataStatus();
            return result;
        }

        public void tambahPengajuanMitra(object[] pengajuan_mitra_baru)
        {
            List<object[]> pengajuan_mitra = m_DataPengajuanMitra.getAllPengajuanMitra();
            foreach (object[] item in pengajuan_mitra)
            {
                if (((string)item[1]).ToLower() == ((string)pengajuan_mitra_baru[0]).ToLower())
                {
                    string message = "Mitra Sudah Terdaftar!";
                    MessageBox.Show(message);
                }
            }
            m_DataPengajuanMitra.sendPengajuan(pengajuan_mitra_baru);
        }

        public void updateStatus(int id_status, int id_pengajuan)
        {
            m_DataPengajuanMitra.updateStatusPengajuanMitra(id_status, id_pengajuan);
        }
    }
}
