using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahDosenTimmbkm
    {
        private List<object>? array_data;
        private m_DataAkunTimmbkm m_DataAkunTimmbkm;
        private m_DataAkunDosen m_DataAkunDosen;
        public c_TambahDosenTimmbkm(m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen)
        {
            this.m_DataAkunTimmbkm = m_DataAkunTimmbkm;
            this.m_DataAkunDosen = m_DataAkunDosen;
        }
        public string tambahDosenBaru(object[] dosen)
        {
            this.array_data = this.m_DataAkunDosen.getAllDosen();
            string message = "";
            foreach (object[] item in this.array_data)
            {
                if (item[1].ToString() == dosen[0].ToString())
                {
                    message = "NIP Telah Digunakan!";
                    return message;
                }
                else if (item[2].ToString() == dosen[1].ToString())
                {
                    message = "NIDN Telah Digunakan!";
                    return message;
                }
                else if (item[3].ToString() == dosen[2].ToString())
                {
                    message = "Nama Telah Digunakan!";
                    return message;
                }                
                else if (item[4].ToString() == dosen[3].ToString())
                {
                    message = "Nomor WhatsApp Telah Digunakan!";
                    return message;
                }
                else if (item[5].ToString() == dosen[4].ToString())
                {
                    message = "Email Telah Digunakan!";
                    return message;
                }
            }
            this.m_DataAkunDosen.sendDosen(dosen);
            return message;
        }
        public void tambahTimmbkmBaru(object[] dosen)
        {
            object[] dosen_lama = this.m_DataAkunDosen.getDosenByNidn(dosen[1].ToString());
            this.m_DataAkunTimmbkm.sendTimmbkm(dosen[1].ToString(),dosen_lama[0].ToString());
        }
    }
}
