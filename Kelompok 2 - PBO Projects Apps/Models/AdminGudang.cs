using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kelompok_2___PBO_Projects_Apps.Models
{
    public class AdminGudang : User
    {
        public AdminGudang(int userId, string username, string password, string nama, string alamat, string noTlp)
            : base(userId, username, password, nama, alamat, noTlp)
        {
        }

        public override string GetRole()
        {
            return "Admin Gudang";
        }

        public override bool Validasi()
        {
            return !string.IsNullOrWhiteSpace(Username) &&
                   !string.IsNullOrWhiteSpace(Password);
        }
    }
}