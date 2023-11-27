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
        List<object> mitra = new List<object>();
        List<object> program = new List<object>();
        List<object> detail_mitra = new List<object>();
        public c_TambahMitraProgam(m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataDetailMitra m_DataDetailMitra)
        {
            this.m_DataMitra = m_DataMitra;
            this.m_DataProgram = m_DataProgram;
            this.m_DataDetailMitra = m_DataDetailMitra;
        }
        public List<object> initMitra()
        {
            this.mitra = this.m_DataMitra.getAllMitra();
            return this.mitra;
        }
        public List<object> initProgram()
        {
            this.program = this.m_DataProgram.getAllProgram();
            return this.program;
        }
        public List<object> initDetailMitra()
        {
            this.detail_mitra = this.m_DataDetailMitra.getAllDetailMitra();
            foreach (object[] item in this.detail_mitra)
            {
                this.program = this.m_DataProgram.getProgramById((int)item[0]);
                this.mitra = this.m_DataMitra.getMitraById((int)item[1]);
                item[0] = program[1];
                item[1] = mitra[1];
            }
            return this.detail_mitra;
        }
        public string tambahDetailMitraBaru(string nama_program, string nama_mitra)
        {
            string message = "";
            this.program = this.m_DataProgram.getProgramByNama(nama_program);
            this.mitra = this.m_DataMitra.getMitraByNama(nama_mitra);
            this.detail_mitra = this.m_DataDetailMitra.getAllDetailMitra();
            foreach (object[] item in this.detail_mitra)
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
