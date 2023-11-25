using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    internal class m_DataProdi
    {
        public string getNamaProdiById(int id_prodi)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Prodi\" WHERE id_prodi = '{id_prodi}'");
            string result = "";
            while (reader.Read())
            {
                result = reader[1].ToString();
            }
            reader.Close();
            return result;
        }
    }
}
