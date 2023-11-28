using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baskom.Model;

namespace Baskom.Controller
{
    internal class c_TambahMitraProgam
    {
        m_DataMitra m_DataMitra;
        m_DataProgram m_DataProgram;
        m_DataDetailMitra m_DataDetailMitra;
        public c_TambahMitraProgam(m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataDetailMitra m_DataDetailMitra)
        {
            this.m_DataMitra = m_DataMitra;
            this.m_DataProgram = m_DataProgram;
            this.m_DataDetailMitra = m_DataDetailMitra;
        }
        public List<object[]> initMitra()
        {
            List<object[]> mitra = this.m_DataMitra.getAllMitra();
            return mitra;
        }
        public List<object[]> initProgram()
        {
            List<object[]> program = this.m_DataProgram.getAllProgram();
            return program;
        }
        public List<object[]> initDetailMitra()
        {
            List<object[]> detail_mitra = this.m_DataDetailMitra.getAllDetailMitra();
            foreach (object[] item in detail_mitra)
            {
                object[] program = this.m_DataProgram.getProgramById((int)item[0]);
                object[] mitra = this.m_DataMitra.getMitraById((int)item[1]);
                item[0] = program[1];
                item[1] = mitra[1];
            }
            return detail_mitra;
        }
        public string tambahDetailMitraBaru(string nama_program, string nama_mitra)
        {
            string message = "";
            object[] program = this.m_DataProgram.getProgramByNama(nama_program);
            object[] mitra = this.m_DataMitra.getMitraByNama(nama_mitra);
            List<object[]> detail_mitra = this.m_DataDetailMitra.getAllDetailMitra();
            foreach (object[] item in detail_mitra)
            {
                if (item[0].ToString() == program[0].ToString() && item[1].ToString() == mitra[0].ToString())
                {
                    return "Detail Mitra Telah Tersedia!";
                }
            }
            this.m_DataDetailMitra.sendDetailMitra((int)program[0], (int)mitra[0]);
            return message;
        }
    }
}
