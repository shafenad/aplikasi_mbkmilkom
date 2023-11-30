using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_PenerimaanMitra
    {
        m_DataBkp m_DataBkp;
        m_DataAkunDosen m_DataAkunDosen;
        m_DataMitra m_DataMitra;
        m_DataPenerimaanMitra m_DataPenerimaanMitra;
        public c_PenerimaanMitra(m_DataBkp m_DataBkp, m_DataAkunDosen m_DataAkunDosen, m_DataMitra m_DataMitra, m_DataPenerimaanMitra m_DataPenerimaanMitra)
        {
            this.m_DataBkp = m_DataBkp;
            this.m_DataAkunDosen = m_DataAkunDosen;
            this.m_DataMitra = m_DataMitra;
            this.m_DataPenerimaanMitra = m_DataPenerimaanMitra;
        }

        public List<object[]> getAllDataBKP()
        {
            List<object[]> result = this.m_DataBkp.getAllBkp();
            return result;
        }
        public List<object[]> getAllDataDosen()
        {
            List<object[]> result = this.m_DataAkunDosen.getAllDosen();
            return result;
        }
        public List<object[]> getAllDataMitra()
        {
            List<object[]> result = this.m_DataMitra.getAllMitra();
            return result;
        }
        public List<object[]> getAllPenerimaanMitra()
        {
            List<object[]> result = this.m_DataPenerimaanMitra.getAllPenerimaanMitra();
            return result;
        }
        public object[] getDataBKPbyId(int id_bkp)
        {
            return m_DataBkp.getBkpById(id_bkp);
        }        
        public object[] getMitrabyId(int id_mitra)
        {
            return m_DataMitra.getMitraById(id_mitra);
        }        
        public object[] getDPAbyId(int id_dosen)
        {
            return m_DataAkunDosen.getDosenById(id_dosen);
        }
        public string tambahPenerimaanMitra(object[] penerimaan_mitra_baru)
        {
            string message = "";
            List<object[]> penerimaan_mitra = m_DataPenerimaanMitra.getAllPenerimaanMitra();
            foreach (object[] item in penerimaan_mitra)
            {
                if ((string)item[2] == (string)penerimaan_mitra_baru[1])
                {
                    message = "Nomor Whatsapp Telah Digunakan!";
                    MessageBox.Show(message);
                    return message;
                }
            }
            m_DataPenerimaanMitra.sendPenerimaan(penerimaan_mitra_baru);
            return message;
        }
    }
}
