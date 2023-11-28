using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DataDosen
    {
        m_DataAkunDosen m_DataAkunDosen;
        public c_DataDosen(m_DataAkunDosen m_DataAkunDosen)
        {
            this.m_DataAkunDosen = m_DataAkunDosen;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = this.m_DataAkunDosen.getAllDosen();
            return result;
        }
    }
}
