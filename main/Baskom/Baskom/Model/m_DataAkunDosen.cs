using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunDosen
    {
        private Array[] getDosen()
        {
            Array[] result = new Array[1];
            return result;
        }

        public string[] getDosenById(int id_dosen)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE id_dosen = '{id_dosen}'");
            string[] result = new string[7];
            while (reader.Read())
            {
                result[0] = reader[0].ToString();
                result[1] = reader[1].ToString();
                result[2] = reader[2].ToString();
                result[3] = reader[3].ToString();
                result[4] = reader[4].ToString();
                result[5] = reader[5].ToString();
                result[6] = reader[6].ToString();
            }
            reader.Close();
            return result;
        }

        private Array[] getDosenByNidn(string nidn)
        {
            Array[] result = new Array[1];
            return result;
        }
    }
}
