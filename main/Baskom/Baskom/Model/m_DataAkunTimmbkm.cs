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
            string[] timmbkm = getTimmbkmByNidn(nidn);
            try
            {
                object[] dosen = this.m_DataAkunDosen.getDosenById(int.Parse(timmbkm[2]));
                if (dosen[6].ToString() == kata_sandi)
                {
                    this.id_timmbkm = timmbkm[0];
                    this.nidn = nidn;
                    this.timmbkm_id_dosen = int.Parse(timmbkm[2]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
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
        public void sendTimmbkm(string nidn, string id_dosen)
        {
            string query = $"INSERT INTO \"Data_Akun_Timmbkm\" (nidn,id_dosen) VALUES ('{nidn}',{id_dosen});";
            Database.Database.sendData(query);
        }
    }
}
