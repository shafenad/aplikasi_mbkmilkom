using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunAdmin
    {
        private int id_admin;
        private string email;
        private string kata_sandi;
        private string nama_admin;

        public bool cekLoginAdmin(string email, string kata_sandi)
        {
            string[] data_admin = getAdminByEmail(email);
            if (data_admin[3] == kata_sandi)
            {
                this.id_admin = int.Parse(data_admin[0]);
                this.email = email;
                this.kata_sandi = kata_sandi;
                this.nama_admin = data_admin[1];
                return true;
            }
            return false;
        }
        public string[] getAdminByEmail(string email)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Admin\" WHERE email = '{email}'");
            string[] result = new string[4];
            while (reader.Read())
            {
                result[0] = reader[0].ToString();
                result[1] = reader[1].ToString();
                result[2] = reader[2].ToString();
                result[3] = reader[3].ToString();
            }
            reader.Close();
            return result;
        }

        public void setDataAdmin(int id_admin, string nama_admin, string kata_sandi)
        {
            this.id_admin = id_admin;
            this.email = nama_admin;
            this.kata_sandi = kata_sandi;
        }
        public object[] getAttributes()
        {
            object[] result = new object[2];
            result[0] = nama_admin;
            result[1] = email;
            return result;
        }
    }
}
