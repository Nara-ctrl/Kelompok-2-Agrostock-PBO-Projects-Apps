using System;
using System.Collections.Generic;
using System.Text;

namespace Kelompok_2___PBO_Projects_Apps.Controllers
{
    public abstract class User
    {
        private int _userId;
        private string _username;
        private string _password;
        private string _nama;
        private string _alamat;
        private string _noTlp;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }
        public string NoTlp
        {
            get { return _noTlp; }
            set { _noTlp = value; }
        }

        public User(int userId, string username, string password, string nama, string alamat, string noTlp)
        {
            _userId = userId;
            _username = username;
            _password = password;
            _nama = nama;
            _alamat = alamat;
            _noTlp = noTlp;
        }

        public abstract string GetRole();

        public abstract bool Validasi();
    }
}