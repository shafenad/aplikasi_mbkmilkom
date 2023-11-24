using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunTimmbkm
    {
        private string id_timmbkm;
        private string nidn;
        private int timmbkm_id_dosen;
        private m_DataAkunDosen m_DataAkunDosen = new m_DataAkunDosen();

        public bool cekLoginTimmbkm(string nidn, string kata_sandi)
        {
            string[] dataTimmbkm = getTimmbkmByNidn(nidn);
            string[] dataDosen = this.m_DataAkunDosen.getDosenById(int.Parse(dataTimmbkm[2]));
            if (dataDosen[6] == kata_sandi)
            {
                this.id_timmbkm = dataTimmbkm[0];
                this.nidn = nidn;
                this.timmbkm_id_dosen = int.Parse(dataTimmbkm[2]);
                return true;
            }
            return false;
        }
        public string[] getTimmbkmByNidn(string nidn)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Timmbkm\" WHERE nidn = '{nidn}'");
            string[] result = new string[3];
            while (reader.Read())
            {
                result[0] = reader[0].ToString();
                result[1] = reader[1].ToString();
                result[2] = reader[2].ToString();
            }
            reader.Close();
            return result;
        }
        public object[] getDosenAttributes()
        {
            return m_DataAkunDosen.getAttributes(this.timmbkm_id_dosen);
        }
    }
}
