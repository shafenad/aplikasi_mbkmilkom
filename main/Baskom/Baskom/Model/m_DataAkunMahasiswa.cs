using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunMahasiswa
    {
        private int? id_mahasiswa;
        private string? nim;
        private string? nama_mahasiswa;
        private int? tahun_masuk;
        private bool? status_mahasiswa;
        private string? no_wa;
        private int? batch_mbkm;
        private string? email;
        private string? kata_sandi;
        private int? id_prodi;

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
        private Array[] getMahasiswa()
        {
            Array[] result = new Array[1];
            return result;
        }

        private Array[] getMahasiswaById(int namanya1)
        {
            Array[] result = new Array[1];
            return result;
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
    }
}
