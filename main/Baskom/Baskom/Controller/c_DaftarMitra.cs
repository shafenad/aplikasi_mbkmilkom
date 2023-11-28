using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DaftarMitra
    {
        m_DataMitra m_DataMitra;
        m_DataBkp m_DataBkp;
        public c_DaftarMitra(m_DataMitra m_DataMitra, m_DataBkp m_DataBkp)
        {
            this.m_DataMitra = m_DataMitra;
            this.m_DataBkp = m_DataBkp;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_mitra = m_DataMitra.getAllMitra();
            List<object[]> data_bkp = m_DataBkp.getAllBkp();
            object[] item = new object[3];
            foreach (object[] mitra in data_mitra)
            {
                item[0] = mitra[1];
                item[1] = mitra[2];
                item[2] = data_bkp[(int)mitra[3]][1];
                result.Add(item);
            }
            return result;
        }
    }
}
