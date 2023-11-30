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
        m_DataPengajuanMitra m_DataPengajuanMitra;
        public c_ValidasiMOA(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPengajuanMitra m_DataPengajuanMitra)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataPengajuanMitra = m_DataPengajuanMitra;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_pengajuan_mitra = m_DataPengajuanMitra.getAllPengajuanMitra();
            foreach (object[] pengajuan in data_pengajuan_mitra)
            {
                object[] items = new object[5];
                object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaById((int)pengajuan[4]);
                items[0] = mahasiswa[2];
                items[1] = pengajuan[1];
                items[2] = pengajuan[2];
                items[3] = pengajuan[3];
                items[4] = (int)pengajuan[0];
                result.Add(items);
            }
            return result;
        }
        public string simpanData(List<bool> data_status, List<int> data_id)
        {
            List<int> true_id = new List<int>();
            List<int> false_id = new List<int>();
            for (int i = 0; i<data_id.Count; i++)
            {
                if (data_status[i])
                {
                    true_id.Add((int)data_id[i]);
                }
                else
                {
                    false_id.Add((int)data_id[i]);
                }
            }
            m_DataPengajuanMitra.updateStatusPengajuanMitra(true_id, false_id);
            return "Data Berhasil Disimpan!";
        }
    }
}
