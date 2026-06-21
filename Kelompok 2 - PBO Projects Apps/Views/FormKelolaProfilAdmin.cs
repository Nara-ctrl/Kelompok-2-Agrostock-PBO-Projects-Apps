using Kelompok_2___PBO_Projects_Apps.Controllers;
using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps.Views
{
    public partial class FormKelolaProfilAdmin : Form
    {
        private AdminGudang adminLogin;

        public FormKelolaProfilAdmin(AdminGudang admin)
        {
            InitializeComponent();
            adminLogin = admin;
            this.Load += FormKelolaProfilAdmin_Load;
        }

        private void FormKelolaProfilAdmin_Load(object sender, EventArgs e)
        {
            LoadDataAdmin();
            tb_namaLengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_Simpan.Enabled = false;
            btn_Edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void LoadDataAdmin()
        {
            DatabaseHelper db = new DatabaseHelper();
            var profil = db.GetProfilAdmin(adminLogin.UserId);
            tb_namaLengkap.Text = profil.nama;
            txt_alamat.Text = profil.alamat;
            tb_noTlp.Text = profil.noTlp;
            tb_username.Text = adminLogin.Username;
            tb_password.Text = adminLogin.Password;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            tb_namaLengkap.ReadOnly = false;
            txt_alamat.ReadOnly = false;
            tb_noTlp.ReadOnly = false;
            tb_username.ReadOnly = false;
            tb_password.ReadOnly = false;
            btn_Simpan.Enabled = true;
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            db.UpdateProfilAdmin(
                adminLogin.UserId,
                tb_namaLengkap.Text,
                tb_username.Text,
                tb_password.Text,
                txt_alamat.Text,
                tb_noTlp.Text);

            adminLogin.Nama = tb_namaLengkap.Text;
            adminLogin.Username = tb_username.Text;
            adminLogin.Password = tb_password.Text;
            adminLogin.Alamat = tb_alamat.Text;
            adminLogin.NoTlp = tb_noTlp.Text;

            MessageBox.Show("Profil berhasil diperbarui!");
            tb_namaLengkap.ReadOnly = true;
            txt_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_Simpan.Enabled = false;
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            LoadDataAdmin();
            tb_namaLengkap.ReadOnly = true;
            txt_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_Simpan.Enabled = false;
        }

        private void btn_Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}