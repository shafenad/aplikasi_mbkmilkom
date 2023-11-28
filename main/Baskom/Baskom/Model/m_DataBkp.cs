using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataBkp
    {
        List<object[]> result = new List<object[]>();
        public List<object[]> getAllBkp()
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_BKP\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }

    }
}
