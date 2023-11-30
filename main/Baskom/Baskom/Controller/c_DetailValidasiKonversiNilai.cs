using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DetailValidasiKonversiNilai
    {
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataMataKuliah m_DataMataKuliah;
        public c_DetailValidasiKonversiNilai(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiNilai m_DataKonversiNilai, m_DataMataKuliah m_DataMataKuliah)
        {
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataMataKuliah = m_DataMataKuliah;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_konversi_sks = m_DataKonversiNilai.getAllKonversiNilai();
            foreach (object[] konversi_sks in data_konversi_sks)
            {
                object[] items = new object[5];
                object[] matkul = m_DataMataKuliah.getMataKuliahById((int)konversi_sks[4]);
                items[0] = konversi_sks[1];
                items[1] = konversi_sks[2];
                items[2] = matkul[2];
                items[3] = matkul[3];
                items[4] = konversi_sks[3];
                result.Add(items);
            }
            return result;
        }
    }
}
