using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Kelompok_2___PBO_Projects_Apps.Database;

namespace Kelompok_2___PBO_Projects_Apps.Controllers
{
    internal class UserController
    {
        private DatabaseHelper db = new DatabaseHelper();

        public User Login(string username, string password)
        {
            bool berhasil = db.LoginUser(username, password, out int userId, out string role);
            if (!berhasil) return null;

            if (role == "admin")
            {
                var profil = db.GetProfilAdmin(userId);
                return new AdminGudang(userId, username, password, profil.nama, profil.alamat, profil.noTlp);
            }
            else if (role == "petani")
            {
                var profil = db.GetProfilPetani(userId);
                return new Petani(userId, profil.idPetani, username, password, profil.nama, profil.alamat, profil.noTlp);
            }

            return null;
        }

        public void RegisterPetani(string username, string password, string nama, string alamat, string noTlp)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new Exception("Username dan Password wajib diisi!");

            db.RegisterPetani(username, password, nama, alamat, noTlp);
        }
    }
}