using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataKonversiNilai
    {
        public List<object[]> getAllKonversiNilai()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_Nilai\";");
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

        public List<object[]> getAllKonversiNilaiByIdSks(List<int> list_id_konversi_sks)
        {
            List<object[]> result = new List<object[]>();

            foreach (int id_sks in list_id_konversi_sks)
            {
                NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_Nilai\" WHERE id_konversi_sks = {id_sks};");
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
            }
            return result;
        }

        public void sendDataKonversiNilai(object[] dataKonversiNilai)
        {
            string query = $"INSERT INTO \"Data_Konversi_Nilai\" (nilai,file_laporan_akhir,status_validasi,id_konversi_sks) VALUES ({dataKonversiNilai[0]},'{dataKonversiNilai[1]}',{dataKonversiNilai[2]},{dataKonversiNilai[3]});";
            Database.Database.sendData(query);
        }
    }
}
