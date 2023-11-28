using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baskom.Model;
using Npgsql;

namespace Baskom.Controller
{
    internal class c_TambahMataKuliah
    {
        m_DataMataKuliah m_DataMataKuliah;
        public c_TambahMataKuliah(m_DataMataKuliah m_DataMataKuliah)
        {
            this.m_DataMataKuliah = m_DataMataKuliah;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = this.m_DataMataKuliah.getAllMataKuliah();
            return result;
        }
        public string tambahMataKuliahBaru(object[] matkul)
        {
            List<object[]> data_matkul = m_DataMataKuliah.getAllMataKuliah();
            string message = "";
            foreach (object[] item in data_matkul)
            {
                if (item[1].ToString() == matkul[0].ToString())
                {
                    message = "Kode Mata Kuliah Telah Digunakan!";
                    return message;
                }
                else if (item[2].ToString() == matkul[1].ToString())
                {
                    message = "Nama Mata Kuliah Telah Digunakan!";
                    return message;
                }
            }
            m_DataMataKuliah.sendMataKuliah(matkul);
            return message;
        }
    }
}
