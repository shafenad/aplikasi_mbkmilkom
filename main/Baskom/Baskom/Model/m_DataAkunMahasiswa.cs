using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunMahasiswa
    {
        m_DataProdi m_DataProdi = new();
        private int id_mahasiswa;
        private string nim;
        private string nama_mahasiswa;
        private int tahun_masuk;
        private bool status_mahasiswa;
        private string no_wa;
        private int batch_mbkm;
        private string email;
        private string kata_sandi;
        private int id_prodi;

        public bool cekLoginMahasiswa(string nim, string kata_sandi)
        {
            string[] data_mahasiswa = getMahasiswaByNim(nim);
            if (data_mahasiswa[1] == nim)
            {
                if (data_mahasiswa[8] == kata_sandi)
                {
                    this.id_mahasiswa = int.Parse(data_mahasiswa[0]);
                    this.nim = data_mahasiswa[1];
                    this.nama_mahasiswa = data_mahasiswa[2];
                    this.tahun_masuk = int.Parse(data_mahasiswa[3]);
                    this.status_mahasiswa = int.Parse(data_mahasiswa[4]) == 1? true:false;
                    this.no_wa = data_mahasiswa[5];
                    this.batch_mbkm = int.Parse(data_mahasiswa[6]);
                    this.email = data_mahasiswa[7];
                    this.kata_sandi = data_mahasiswa[8];
                    this.id_prodi = int.Parse(data_mahasiswa[9]);
                    return true;
                }
                return false;
            }
            return false;
        }
        public string[] getMahasiswaByNim(string nim)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Mahasiswa\" WHERE nim = '{nim}'");
            string[] result = new string[10];
            while (reader.Read())
            {
                result[0] = reader[0].ToString();
                result[1] = reader[1].ToString();
                result[2] = reader[2].ToString();
                result[3] = reader[3].ToString();
                result[4] = reader[4].ToString();
                result[5] = reader[5].ToString();
                result[6] = reader[6].ToString();
                result[7] = reader[7].ToString();
                result[8] = reader[8].ToString();
                result[9] = reader[9].ToString();
            }
            reader.Close();
            return result;
        }
        public List<object> getAllMahasiswa()
        {
            List<object> result = new List<object>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Mahasiswa\";");
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
        public object[] getAttributes()
        {
            string nama_prodi = this.m_DataProdi.getNamaProdiById(id_prodi);
            object[] result = new object[10];
            result[0] = id_mahasiswa;
            result[1] = nim;
            result[2] = nama_mahasiswa;
            result[3] = tahun_masuk;
            result[4] = status_mahasiswa;
            result[5] = no_wa;
            result[6] = batch_mbkm;
            result[7] = email;
            result[8] = kata_sandi;
            result[9] = nama_prodi;
            return result;
        }
        public void sendMahasiswa(object[] mahasiswa)
        {
            string query = $"INSERT INTO \"Data_Akun_Mahasiswa\" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi) VALUES ('{mahasiswa[0]}','{mahasiswa[1]}',{mahasiswa[2]},{mahasiswa[3]},'{mahasiswa[4]}',{mahasiswa[5]},'{mahasiswa[6]}','{mahasiswa[7]}',{mahasiswa[8]});";
            Database.Database.sendData(query);
        }
    }
}
