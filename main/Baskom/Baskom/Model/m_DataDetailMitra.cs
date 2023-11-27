using Baskom.Controller;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataDetailMitra
    {
        public List<object> getAllDetailMitra()
        {
            List<object> result = new List<object>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Detail_Mitra\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public void sendDetailMitra(int id_program, int id_mitra)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Detail_Mitra\" (id_program, id_mitra) VALUES ({id_program},{id_mitra});");
        }
    }
}
