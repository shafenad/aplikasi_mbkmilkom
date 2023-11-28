using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace Baskom.Database
{
    static class Database
    {
        static NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=baskom");
        public static void openDb()
        {
            conn.Open();
        }
        public static void closeDb()
        {
            conn.Close();
        }
        public static int sendData(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query,conn);
            int rows_affected = cmd.ExecuteNonQuery();
            return rows_affected;
        }
        public static NpgsqlDataReader getData(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query,conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static void send2BindData(List<object> data_status, List<object> data_id, string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            NpgsqlParameter p = new NpgsqlParameter("data_status", NpgsqlDbType.Array | NpgsqlDbType.Text);
            NpgsqlParameter q = new NpgsqlParameter("data_id", NpgsqlDbType.Array | NpgsqlDbType.Text);
            p.Value = data_status;
            q.Value = data_id;
            cmd.Parameters.Add(p);
            cmd.Parameters.Add(q);
            cmd.ExecuteNonQuery();
        }
    }
}
