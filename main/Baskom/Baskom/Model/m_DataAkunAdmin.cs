using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunAdmin
    {
        public int id_admin;
        public string kata_sandi;
        public string nama_admin;

        public string[] getAdminByNama(string nama_admin, string kata_sandi)
        {
            string[] result = new string[1];
            return result;
        }

        public void setDataAdmin(int id_admin, string nama_admin, string kata_sandi)
        {
            this.id_admin = id_admin;
            this.nama_admin = nama_admin;
            this.kata_sandi = kata_sandi;
        }
    }
}
