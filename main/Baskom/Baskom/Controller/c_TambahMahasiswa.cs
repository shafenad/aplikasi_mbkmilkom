using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baskom.Model;

namespace Baskom.Controller
{
    internal class c_TambahMahasiswa
    {
        private List<object>? array_data;
        private m_DataAkunMahasiswa m_DataAkunMahasiswa;
        private m_DataProdi m_DataProdi;
        public c_TambahMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa,m_DataProdi m_DataProdi)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataProdi = m_DataProdi;
        }

        public string tambahMahasiswaBaru(object[] mahasiswa)
        {
            this.array_data = this.m_DataAkunMahasiswa.getAllMahasiswa();
            string message = "";
            foreach (object[] item in this.array_data)
            {
                if (item[1].ToString() == mahasiswa[0].ToString())
                {
                    message = "NIM Telah Digunakan!";
                    return message;
                }
                else if (item[5].ToString() == mahasiswa[4].ToString())
                {
                    message = "Nomor WhatsApp Telah Digunakan!";
                    return message;
                }
                else if (item[7].ToString() == mahasiswa[6].ToString())
                {
                    message = "Email Telah Digunakan!";
                    return message;
                }
            }
            int id_prodi = m_DataProdi.getIdProdiByNama(mahasiswa[8].ToString());
            mahasiswa[8] = id_prodi;
            m_DataAkunMahasiswa.sendMahasiswa(mahasiswa);
            return message;
        }
    }
}
