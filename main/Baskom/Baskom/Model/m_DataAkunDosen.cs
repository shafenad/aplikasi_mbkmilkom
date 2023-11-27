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
        object[] dosen = new object[7];
        public object[] getDosenById(int id_dosen)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE id_dosen = {id_dosen}");
            while (reader.Read())
            {
                this.dosen[0] = reader[0];
                this.dosen[1] = reader[1];
                this.dosen[2] = reader[2];
                this.dosen[3] = reader[3];
                this.dosen[4] = reader[4];
                this.dosen[5] = reader[5];
                this.dosen[6] = reader[6];
            }
            reader.Close();
            return this.dosen;
        }
        public object[] getDosenByNidn(string nidn)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE nidn = '{nidn}'");
            while (reader.Read())
            {
                this.dosen[0] = reader[0];
                this.dosen[1] = reader[1];
                this.dosen[2] = reader[2];
                this.dosen[3] = reader[3];
                this.dosen[4] = reader[4];
                this.dosen[5] = reader[5];
                this.dosen[6] = reader[6];
            }
            reader.Close();
            return this.dosen;
        }
        public List<object> getAllDosen()
        {
            List<object> result = new List<object>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\";");
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
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public object[] getAttributes(int id_dosen)
        {
            object[] dosen = getDosenById(id_dosen);
            this.dosen[0] = dosen[0];
            this.dosen[1] = dosen[1];
            this.dosen[2] = dosen[2];
            this.dosen[3] = dosen[3];
            this.dosen[4] = dosen[4];
            this.dosen[5] = dosen[5];
            this.dosen[6] = dosen[6];
            return this.dosen;
        }
        public void sendDosen(object[] dosen)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Akun_Dosen\" (nip, nidn, nama_dosen, no_wa, email, kata_sandi) VALUES ('{dosen[0]}','{dosen[1]}','{dosen[2]}','{dosen[3]}','{dosen[4]}','{dosen[5]}');");
        }
    }
}
