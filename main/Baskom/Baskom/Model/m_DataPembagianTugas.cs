using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataPembagianTugas
    {
        public List<object[]> getAllPembagianTugas()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pembagian_Tugas\";");
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
        public object[] getPembagianTugasByIdSks(int id_konversi_sks)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pembagian_Tugas\" WHERE id_konversi_sks = {id_konversi_sks}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
            }
            reader.Close();
            return result;
        }
        public object[] getPembagianTugasByIdNilai(int id_konversi_nilai)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pembagian_Tugas\" WHERE id_konversi_nilai = {id_konversi_nilai}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
            }
            reader.Close();
            return result;
        }
    }
}
