using Kelompok_2___PBO_Projects_Apps.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps.Views
{
    public partial class FormKelolaDataPetani : Form
    {
        private int _idUser;
        private DatabaseHelper db = new DatabaseHelper();

        public FormKelolaDataPetani(int idUser)
        {
            InitializeComponent();
            _idUser = idUser;
            this.Load += FormKelolaDataPetani_Load;
        }

        private void FormKelolaDataPetani_Load(object sender, EventArgs e)
        {
            LoadData();
            tb_nama_lengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_simpan.Enabled = false;
            btn_edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void LoadData()
        {
            var profil = db.GetProfilPetaniByIdUser(_idUser);
            tb_nama_lengkap.Text = profil.nama;
            tb_alamat.Text = profil.alamat;
            tb_noTlp.Text = profil.noTlp;
            tb_username.Text = profil.username;
            tb_password.Text = profil.password;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            tb_nama_lengkap.ReadOnly = false;
            tb_alamat.ReadOnly = false;
            tb_noTlp.ReadOnly = false;
            tb_username.ReadOnly = false;
            tb_password.ReadOnly = false;
            btn_simpan.Enabled = true;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            db.UpdateProfilPetani(
                _idUser,
                tb_username.Text,
                tb_password.Text,
                tb_alamat.Text,
                tb_noTlp.Text,
                tb_nama_lengkap.Text);

            MessageBox.Show("Data berhasil diperbarui!");
            tb_nama_lengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_simpan.Enabled = false;
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            LoadData();
            tb_nama_lengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_simpan.Enabled = false;
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            FormKelolaDataAkunPetani back = new FormKelolaDataAkunPetani();
            back.Show();
            this.Hide();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}