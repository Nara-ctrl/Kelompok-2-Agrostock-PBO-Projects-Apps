using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using Kelompok_2___PBO_Projects_Apps.Views;
using System;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormAdmin : Form
    {
        private AdminGudang _admin;

        public FormAdmin(AdminGudang admin)
        {
            InitializeComponent();
            _admin = admin;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            FormRegister register = new FormRegister();
            register.Show();
            this.Hide();
        }

        private void btn_olah_komoditas_Click(object sender, EventArgs e)
        {
            FormOlahKomoditas olah = new FormOlahKomoditas();
            olah.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void btn_kelola_data_Click(object sender, EventArgs e)
        {
            FormKelolaData kelolaData = new FormKelolaData();
            kelolaData.Show();
            this.Hide();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_RiwayatTransaksi_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi transaksi = new FormRiwayatTransaksi();
            transaksi.Show();
            this.Hide();
        }

        private void btn_kelola_petani_Click(object sender, EventArgs e)
        {
            FormKelolaDataAkunPetani form = new FormKelolaDataAkunPetani(_admin);
            form.Show(); 
            this.Hide();
        }

        private void btn_KelolaProfil_Click(object sender, EventArgs e)
        {
            FormKelolaProfilAdmin Profil = new FormKelolaProfilAdmin(_admin);
            Profil.Show();
            this.Hide();
        }
    }
}