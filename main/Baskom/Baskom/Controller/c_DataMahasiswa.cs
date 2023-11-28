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
        public c_DataMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = this.m_DataAkunMahasiswa.getAllMahasiswa();
            return result;
        }
    }
}
