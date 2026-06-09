using Kelompok_2___PBO_Projects_Apps.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kelompok_2___PBO_Projects_Apps.Controllers
{
    public class Petani : User
    {
        private int _idPetani;

        public int IdPetani
        {
            get { return _idPetani; }
            set { _idPetani = value; }
        }

        public Petani(int userId, int idPetani, string username, string password, string nama, string alamat, string noTlp)
            : base(userId, username, password, nama, alamat, noTlp)
        {
            _idPetani = idPetani;
        }

        public override string GetRole()
        {
            return "Petani";
        }

        public override bool Validasi()
        {
            return !string.IsNullOrWhiteSpace(Username) &&
                   !string.IsNullOrWhiteSpace(Password) &&
                   !string.IsNullOrWhiteSpace(Nama);
        }
    }
}