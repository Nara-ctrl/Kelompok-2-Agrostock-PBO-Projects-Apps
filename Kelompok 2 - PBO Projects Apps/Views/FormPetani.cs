using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using Kelompok_2___PBO_Projects_Apps.Views;
using System;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormPetani : Form
    {
        private int _idPetani;

        public FormPetani(int idPetani)
        {
            InitializeComponent();
            _idPetani = idPetani;
        }

        private void btn_kelola_profil_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            var profil = db.GetProfilPetaniByIdPetani(_idPetani);

            Petani petani = new Petani(
                profil.userId,
                _idPetani,
                profil.username,
                profil.password,
                profil.nama,
                profil.alamat,
                profil.noTlp
            );

            FormProfilPetani formProfil = new FormProfilPetani(petani);
            formProfil.ShowDialog();
        }
        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi riwayat = new FormRiwayatTransaksi(_idPetani);
            riwayat.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}