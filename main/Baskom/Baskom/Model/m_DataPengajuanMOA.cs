using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    internal class m_DataPengajuanMOA
    {
        public List<object[]> getAllPengajuanMOA()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_PengajuanMOA\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                field_values[4] = reader[4];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public void updateStatusPengajuanMOA(List<object> data_status, List<object> data_id)
        {
            Database.Database.send2BindData(data_status, data_id, $"UPDATE \"Data_PengajuanMOA\" SET status_validasi = ANY(:data_status) WHERE id_mahasiswa = ANY(:data_id)");
        }
    }
}
