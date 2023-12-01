using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_KonversiNilai
    {
        m_DataKonversiSks m_DataKonversiSks;
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataMataKuliah m_DataMataKuliah;

        public c_KonversiNilai(m_DataKonversiSks m_DataKonversiSks, m_DataKonversiNilai m_DataKonversiNilai, m_DataMataKuliah dataMataKuliah)
        {
            this.m_DataKonversiSks = m_DataKonversiSks;
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataMataKuliah = dataMataKuliah;
        }

        public List<object[]> getDataSksByIdMhs(int id_mahasiswa)
        {
            List<object[]> result = this.m_DataKonversiSks.getAllKonversiSksByIdMhs(id_mahasiswa);
            return result;
        }

        public List<object[]> getDataSksByIdSks(List<int> id_sks)
        {
            List<object[]> result = this.m_DataKonversiSks.getAllKonversiSksByIdSks(id_sks);
            return result;
        }

        public List<object[]> getDataNilaiByIdSks(List<int> id_sks)
        {
            List<object[]> result = this.m_DataKonversiNilai.getAllKonversiNilaiByIdSks(id_sks);
            return result;
        }

        public List<object[]> getMataKuliah(List<int> id_matkul)
        {
            List<object[]> result = this.m_DataMataKuliah.getAllMatkulByIdMatkul(id_matkul);
            return result;
        }

        public void tambahKonversiNilai(object[] konversiNilaiBaru)
        {
            m_DataKonversiNilai.sendDataKonversiNilai(konversiNilaiBaru);
        }
    }
}
