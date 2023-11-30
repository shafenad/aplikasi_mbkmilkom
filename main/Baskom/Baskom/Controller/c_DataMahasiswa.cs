using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DataMahasiswa
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataPembagianTugas m_DataPembagianTugas;
        m_DataAkunTimmbkm m_DataAkunTimmbkm;
        m_DataAkunDosen m_DataAkunDosen;
        public c_DataMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataPembagianTugas = m_DataPembagianTugas;
            this.m_DataAkunTimmbkm = m_DataAkunTimmbkm;
            this.m_DataAkunDosen = m_DataAkunDosen;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new();
            List<object[]> data_mahasiswa = this.m_DataAkunMahasiswa.getAllMahasiswa();
            foreach (object[] mahasiswa in data_mahasiswa)
            {
                object[] items = new object[2];  
                object[] pembagian_tugas = this.m_DataPembagianTugas.getPembagianTugasByIdMhs((int)mahasiswa[0]);
                items[0] = mahasiswa[2];
                items[1] = mahasiswa[1];
                result.Add(items);
            }
            return result;
        }
        public List<string> getAllNamaTimmbkm()
        {
            List<string> result = new List<string>();
            List<object[]> data_timmbkm = m_DataAkunTimmbkm.getAllTimmbkm();
            foreach (object[] timmbkm in data_timmbkm)
            {
                string nama = (string)m_DataAkunDosen.getDosenById((int)timmbkm[2])[3];
                result.Add(nama);
            }

            return result;
        }
    }
}
