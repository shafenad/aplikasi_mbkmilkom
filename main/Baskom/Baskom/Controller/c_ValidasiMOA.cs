using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_ValidasiMOA
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataPengajuanMOA m_DataPengajuanMOA;
        public c_ValidasiMOA(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPengajuanMOA m_DataPengajuanMOA)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataPengajuanMOA = m_DataPengajuanMOA;
        }
        public List<object[]> initDataGridView()
        {
            object[] items = new object[4];
            List<object[]> result = new List<object[]>();
            List<object[]> data_mahasiswa = m_DataAkunMahasiswa.getAllMahasiswa();
            List<object[]> data_pengajuan_moa = m_DataPengajuanMOA.getAllPengajuanMOA();
            foreach (object[] pengajuan in data_pengajuan_moa)
            {
                items[0] = data_mahasiswa[(int)pengajuan[4]][2];
                items[1] = pengajuan[1];
                items[2] = pengajuan[2];
                items[3] = pengajuan[3];
                items[4] = pengajuan[0];
                result.Add(items);
            }
            return result;
        }
        public string simpanData(List<object> data_status, List<object> data_id)
        {
            m_DataPengajuanMOA.updateStatusPengajuanMOA(data_status, data_id);
            return "Data Berhasil Disimpan!";
        }
    }
}
