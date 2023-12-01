using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataPenerimaanMitra
    {
        public List<object[]> getAllPenerimaanMitra()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Penerimaan_Mitra\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                field_values[4] = reader[4];
                field_values[5] = reader[5];
                field_values[6] = reader[6];
                field_values[7] = reader[7];
                field_values[8] = reader[8];
                field_values[9] = reader[9];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public object[] getPenerimaanMitraById(int id_penerimaan)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Penerimaan_Mitra\" WHERE id_penerimaan = {id_penerimaan}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
                result[5] = reader[5];
                result[6] = reader[6];
                result[7] = reader[7];
                result[8] = reader[8];
                result[9] = reader[9];
            }
            reader.Close();
            return result;
        }
        public object[] getPenerimaanMitraByIdMhs(int id_mahasiswa)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Penerimaan_Mitra\" WHERE id_mahasiswa = {id_mahasiswa}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
                result[5] = reader[5];
                result[6] = reader[6];
                result[7] = reader[7];
                result[8] = reader[8];
                result[9] = reader[9];
            }
            reader.Close();
            return result;
        }

        public int getJumlahSKSByIdMhs(int id_mahasiswa)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Penerimaan_Mitra\" WHERE id_mahasiswa = {id_mahasiswa}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
                result[5] = reader[5];
                result[6] = reader[6];
                result[7] = reader[7];
                result[8] = reader[8];
                result[9] = reader[9];
            }
            reader.Close();
            return int.Parse(result[3].ToString());
        }

        public void sendPenerimaan(object[] penerimaan_mitra)
        {
            int status_pkl;
            if (penerimaan_mitra[0] == "True")
            {
                status_pkl = 1;
            }
            else
            {
                status_pkl = 0;
            }

            string query = $"INSERT INTO \"Data_Penerimaan_Mitra\" (status_pkl, no_wa, jumlah_sks, bukti_penerimaan, id_bkp, id_mitra, id_dosen, id_mahasiswa, id_program) VALUES ({status_pkl}, '{penerimaan_mitra[1]}', {int.Parse(penerimaan_mitra[2].ToString())}, '{penerimaan_mitra[3]}', {penerimaan_mitra[4]}, {penerimaan_mitra[5]}, {penerimaan_mitra[6]}, {penerimaan_mitra[7]}, {penerimaan_mitra[8]});";
            Database.Database.sendData(query);
        }
    }
}
