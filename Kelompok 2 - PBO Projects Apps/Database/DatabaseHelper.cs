using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace Kelompok_2___PBO_Projects_Apps.Database
{
    internal class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;Database=ProjectPboS2;Username=postgres;Password=zen123";

        
        public List<Komoditas> GetAllKomoditas()
        {
            List<Komoditas> list = new List<Komoditas>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT id_komoditas, nama_komoditas, satuan FROM komoditas ORDER BY id_komoditas ASC", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Komoditas(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2)
                ));
            }
            return list;
        }

        public void InsertKomoditas(Komoditas k)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "INSERT INTO komoditas (id_komoditas, nama_komoditas, satuan) VALUES (@id, @nama, @satuan)", conn);
            cmd.Parameters.AddWithValue("id", k.id_komoditas);
            cmd.Parameters.AddWithValue("nama", k.nama_komoditas);
            cmd.Parameters.AddWithValue("satuan", k.satuan);
            cmd.ExecuteNonQuery();
        }

        public void UpdateKomoditas(Komoditas k)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE komoditas SET nama_komoditas=@nama, satuan=@satuan WHERE id_komoditas=@id", conn);
            cmd.Parameters.AddWithValue("id", k.id_komoditas);
            cmd.Parameters.AddWithValue("nama", k.nama_komoditas);
            cmd.Parameters.AddWithValue("satuan", k.satuan);
            cmd.ExecuteNonQuery();
        }

        public void DeleteKomoditas(string id)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand("DELETE FROM komoditas WHERE id_komoditas=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }

        public static NpgsqlConnection GetConnection()
        {

            return new NpgsqlConnection(connString);
        }

        //user
        public bool LoginUser(string username, string password, out int userId, out string role)
        {
            userId = 0; role = "";
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string query = "SELECT id, role FROM users WHERE username = @username AND password = @password";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                userId = reader.GetInt32(0);
                role = reader.GetString(1);
                return true;
            }
            return false;
        }

        public (string nama, string alamat, string noTlp) GetProfilAdmin(int userId)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string query = "SELECT nama, alamat, no_tlp FROM admin WHERE id_user = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", userId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return (reader.GetString(0), reader.GetString(1), reader.GetString(2));
            return ("", "", "");
        }

        public (string nama, string alamat, string noTlp, int idPetani) GetProfilPetani(int userId)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string query = "SELECT nama, alamat, no_tlp, id_petani FROM petani WHERE id_user = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", userId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
                return (reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
            return ("", "", "", 0);
        }

        public void RegisterPetani(string username, string password, string nama, string alamat, string noTlp)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string q1 = "INSERT INTO users (username, password, role) VALUES (@username, @password, 'petani') RETURNING id";
            int newId;
            using (var cmd = new NpgsqlCommand(q1, conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                newId = (int)cmd.ExecuteScalar();
            }
            string q2 = "INSERT INTO petani (id_user, nama, alamat, no_tlp) VALUES (@id_user, @nama, @alamat, @no_tlp)";
            using (var cmd = new NpgsqlCommand(q2, conn))
            {
                cmd.Parameters.AddWithValue("id_user", newId);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.Parameters.AddWithValue("no_tlp", noTlp);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
