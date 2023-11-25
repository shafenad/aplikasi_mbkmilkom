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
        private int id_dosen;
        private string nip;
        private string nidn;
        private string nama_dosen;
        private string no_wa;
        private string email;
        private string kata_sandi;
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
        public void setDosenById(int id_dosen)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE id_dosen = '{id_dosen}'");
            string[] result = new string[7];
            while (reader.Read())
            {
                this.id_dosen = int.Parse(reader[0].ToString());
                this.nip = reader[1].ToString();
                this.nidn = reader[2].ToString();
                this.nama_dosen = reader[3].ToString();
                this.no_wa = reader[4].ToString();
                this.email = reader[5].ToString();
                this.kata_sandi = reader[6].ToString();
            }
            reader.Close();
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
            this.setDosenById(id_dosen);
            object[] result = new object[6];
            result[0] = this.nip;
            result[1] = this.nidn;
            result[2] = this.nama_dosen;
            result[3] = this.no_wa;
            result[4] = this.email;
            return result;
        }
    }
}
