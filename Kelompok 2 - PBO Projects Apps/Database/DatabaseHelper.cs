using Kelompok_2___PBO_Projects_Apps.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Kelompok_2___PBO_Projects_Apps.Database
{
    internal class DatabaseHelper
    {
        private static string connString = "Host=localhost;Port=5432;" +
            "Database=ProjectPboS2;" +
            "Username=postgres;" +
            "Password=zen123";


        public List<Komoditas> GetAllKomoditas()
        {
            List<Komoditas> list = new List<Komoditas>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
    "SELECT id_komoditas, nama_komoditas, satuan " +
    "FROM komoditas " +
    "WHERE status = true " +
    "ORDER BY id_komoditas ASC", conn);
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

        public string GenerateIdKomoditas()
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT id_komoditas " +
                "FROM komoditas " +
                "WHERE id_komoditas LIKE 'K%' " +
                "ORDER BY id_komoditas DESC LIMIT 1", conn);
            var hasil = cmd.ExecuteScalar();

            int idBaru = 1;
            if (hasil != null)
            {
                string idTerakhir = hasil.ToString();
                string angkaStr = idTerakhir.Substring(1);
                int angka = Convert.ToInt32(angkaStr);
                idBaru = angka + 1;
            }

            return "K" + idBaru.ToString("000");
        }

        public void InsertKomoditas(Komoditas k)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "INSERT INTO komoditas (id_komoditas, nama_komoditas, satuan) " +
                "VALUES (@id, @nama, @satuan)", conn);
            cmd.Parameters.AddWithValue("id", k.id_komoditas);
            cmd.Parameters.AddWithValue("nama", k.nama_komoditas);
            cmd.Parameters.AddWithValue("satuan", k.satuan);
            cmd.ExecuteNonQuery();

            using var cmdStok = new NpgsqlCommand(
                "INSERT INTO stok (id_komoditas, jumlah) VALUES (@id, @jumlah)", conn);
            cmdStok.Parameters.AddWithValue("id", k.id_komoditas);
            cmdStok.Parameters.AddWithValue("jumlah", 0);
            cmdStok.ExecuteNonQuery();
        }

        public void UpdateKomoditas(Komoditas k)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "UPDATE komoditas " +
                "SET nama_komoditas=@nama, satuan=@satuan " +
                "WHERE id_komoditas=@id", conn);
            cmd.Parameters.AddWithValue("id", k.id_komoditas);
            cmd.Parameters.AddWithValue("nama", k.nama_komoditas);
            cmd.Parameters.AddWithValue("satuan", k.satuan);
            cmd.ExecuteNonQuery();

            using var cmdStok = new NpgsqlCommand(
                "UPDATE stok SET jumlah=@jumlah WHERE id_komoditas=@id", conn);
            cmdStok.Parameters.AddWithValue("id", k.id_komoditas);
            cmdStok.ExecuteNonQuery();
        }

        public bool CekStokKomoditas(string id)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT COALESCE(SUM(jumlah), 0) " +
                "FROM stok " +
                "WHERE id_komoditas=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            decimal jumlahData = Convert.ToInt32(cmd.ExecuteScalar());
            return jumlahData > 0;
        }

        public void DeleteKomoditas(string id)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE komoditas " +
                "SET status = false " +
                "WHERE id_komoditas=@id", conn);
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
        }

        public static NpgsqlConnection GetConnection()
        {

            return new NpgsqlConnection(connString);
        }

        public bool LoginUser(string username, string password, out int userId, out string role)
        {
            userId = 0;
            role = "";

            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = "SELECT id, role " +
                "FROM users " +
                "WHERE username = @username AND password = @password";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

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

            string query = "SELECT nama, alamat, no_tlp " +
                "FROM admin WHERE id_user = @id";

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

            string query = "SELECT nama, alamat, no_tlp, id_petani " +
                "FROM petani WHERE id_user = @id";

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

            string q1 = "INSERT INTO users (username, password, role) " +
                "VALUES (@username, @password, 'petani') RETURNING id";

            int newId;
            using (var cmd = new NpgsqlCommand(q1, conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                newId = (int)cmd.ExecuteScalar();
            }

            string q2 = "INSERT INTO petani (id_user, nama, alamat, no_tlp) " +
                "VALUES (@id_user, @nama, @alamat, @no_tlp)";

            using (var cmd = new NpgsqlCommand(q2, conn))
            {
                cmd.Parameters.AddWithValue("id_user", newId);
                cmd.Parameters.AddWithValue("nama", nama);
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.Parameters.AddWithValue("no_tlp", noTlp);
                cmd.ExecuteNonQuery();
            }
        }

        public List<(int idPetani, string nama)> GetPetaniList()
        {
            var list = new List<(int, string)>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = "SELECT id_petani, nama " +
                "FROM petani ORDER BY nama ASC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
                list.Add((reader.GetInt32(0), reader.GetString(1)));
            return list;
        }

        public decimal GetJumlahStok(string idKomoditas)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT COALESCE(SUM(jumlah), 0) FROM stok WHERE id_komoditas = @id", conn);
            cmd.Parameters.AddWithValue("id", idKomoditas);
            var hasil = cmd.ExecuteScalar();
            return hasil == null ? 0 : Convert.ToDecimal(hasil);
        }

        public void CatatTransaksi(string idKomoditas, int idPetani, string jenis,
                                  decimal jumlah, string satuan)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string q1 = @"INSERT INTO transaksi (id_komoditas, id_petani, jenis, jumlah, satuan, tanggal) 
                VALUES (@id_komoditas, @id_petani, @jenis, @jumlah, @satuan, @tanggal)";

            using (var cmd = new NpgsqlCommand(q1, conn))
            {
                cmd.Parameters.AddWithValue("id_komoditas", idKomoditas);
                cmd.Parameters.AddWithValue("id_petani", idPetani == 0 ? DBNull.Value : (object)idPetani);
                cmd.Parameters.AddWithValue("jenis", jenis);
                cmd.Parameters.AddWithValue("jumlah", jumlah);
                cmd.Parameters.AddWithValue("satuan", satuan);
                cmd.Parameters.AddWithValue("tanggal", DateTime.Now);
                cmd.ExecuteNonQuery();
            }

            if (jenis == "masuk")
            {
                string cek = "SELECT COUNT(*) FROM stok WHERE id_komoditas = @id";
                int jumlahData;
                using (var cmd = new NpgsqlCommand(cek, conn))
                {
                    cmd.Parameters.AddWithValue("id", idKomoditas);
                    jumlahData = Convert.ToInt32(cmd.ExecuteScalar());
                }

                if (jumlahData == 0)
                {
                    string insert = "INSERT INTO stok (id_komoditas, jumlah) VALUES (@id, @jumlah)";
                    using var cmd = new NpgsqlCommand(insert, conn);
                    cmd.Parameters.AddWithValue("id", idKomoditas);
                    cmd.Parameters.AddWithValue("jumlah", jumlah);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string update = "UPDATE stok SET jumlah = jumlah + @jumlah WHERE id_komoditas = @id";
                    using var cmd = new NpgsqlCommand(update, conn);
                    cmd.Parameters.AddWithValue("id", idKomoditas);
                    cmd.Parameters.AddWithValue("jumlah", jumlah);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (jenis == "keluar")
            {
                string q2 = "UPDATE stok SET jumlah = jumlah - @jumlah WHERE id_komoditas = @id";
                using var cmd = new NpgsqlCommand(q2, conn);
                cmd.Parameters.AddWithValue("id", idKomoditas);
                cmd.Parameters.AddWithValue("jumlah", jumlah);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateProfilPetani(int userId, string username, string password, string alamat, string noTlp)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string q1 = @"UPDATE users SET username=@username, password=@password 
                        WHERE id=@id";

            using (var cmd =
                new NpgsqlCommand(q1, conn))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Parameters.AddWithValue("id", userId);
                cmd.ExecuteNonQuery();
            }

            string q2 = @"UPDATE petani SET alamat=@alamat, no_tlp=@no_tlp 
                        WHERE id_user=@id";

            using (var cmd = new NpgsqlCommand(q2, conn))
            {
                cmd.Parameters.AddWithValue("alamat", alamat);
                cmd.Parameters.AddWithValue("no_tlp", noTlp);
                cmd.Parameters.AddWithValue("id", userId);
                cmd.ExecuteNonQuery();
            }
        }
        public (string nama, string alamat, string noTlp, string username, string password)
        GetDataProfilPetani(int userId)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = @"SELECT p.nama, p.alamat, p.no_tlp, u.username, u.password 
                           FROM petani p 
                           JOIN users u ON p.id_user = u.id 
                           WHERE p.id_user = @id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("id", userId);
            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return (
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)
                );
            }
            return ("", "", "", "", "");
        }
        public List<Stok> GetAllStok()
        {
            List<Stok> list = new List<Stok>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();

            string query = @"SELECT k.id_komoditas, k.nama_komoditas, k.satuan, COALESCE(s.jumlah, 0)
                           FROM komoditas k
                           LEFT JOIN stok s ON k.id_komoditas = s.id_komoditas
                           WHERE k.status = true
                           ORDER BY k.id_komoditas ASC";

            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Stok(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDecimal(3)
                ));
            }
            return list;
        }

        public List<Komoditas> GetKomoditasStokMasuk()
        {
            List<Komoditas> list = new List<Komoditas>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "SELECT DISTINCT k.id_komoditas, k.nama_komoditas, k.satuan " +
                "FROM komoditas k " +
                "JOIN transaksi t ON k.id_komoditas = t.id_komoditas " +
                "WHERE k.status = true AND t.jenis = 'masuk' " +
                "ORDER BY k.id_komoditas ASC", conn);
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

        public DataTable GetRiwayatTransaksi()
        {
            DataTable dt = new DataTable();
            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT ROW_NUMBER() OVER (ORDER BY t.tanggal DESC) AS no,
                    t.id_komoditas,
                    k.nama_komoditas,
                    p.nama AS nama_petani,
                    t.tanggal AS tanggal_transaksi,
                    CASE WHEN t.jenis = 'keluar' THEN -t.jumlah ELSE t.jumlah END AS jumlah,
                    k.satuan
                    FROM transaksi t
                    JOIN komoditas k ON t.id_komoditas = k.id_komoditas
                    LEFT JOIN petani p ON t.id_petani = p.id_petani
                    ORDER BY t.tanggal DESC", conn);
                using var reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetRiwayatTransaksiByPetani(int idPetani)
        {
            DataTable dt = new DataTable();
            try
            {
                using var conn = new NpgsqlConnection(connString);
                conn.Open();
                using var cmd = new NpgsqlCommand(
                    @"SELECT ROW_NUMBER() OVER (ORDER BY t.tanggal DESC) AS no,
                    t.id_komoditas,
                    k.nama_komoditas,
                    t.tanggal AS tanggal_transaksi,
                    CASE WHEN t.jenis = 'keluar' THEN -t.jumlah ELSE t.jumlah END AS jumlah,
                    k.satuan
                    FROM transaksi t
                    JOIN komoditas k ON t.id_komoditas = k.id_komoditas
                    WHERE t.id_petani = @idPetani
                    ORDER BY t.tanggal DESC", conn);
                cmd.Parameters.AddWithValue("idPetani", idPetani);
                using var reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dt;
        }
    }
}
