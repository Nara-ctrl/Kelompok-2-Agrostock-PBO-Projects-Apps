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
            tb_namalengkap.ReadOnly = true;
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

        private void LoadData()
        {
            var profil = db.GetProfilPetaniByIdUser(_idUser);
            tb_namalengkap.Text = profil.nama;
            tb_alamat.Text = profil.alamat;
            tb_noTlp.Text = profil.noTlp;
            tb_username.Text = profil.username;
            tb_password.Text = profil.password;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            tb_namalengkap.ReadOnly = false;
            tb_alamat.ReadOnly = false;
            tb_noTlp.ReadOnly = false;
            tb_username.ReadOnly = false;
            tb_password.ReadOnly = false;
            btn_Simpan.Enabled = true;
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            db.UpdateProfilPetani(
                _idUser,
                tb_username.Text,
                tb_password.Text,
                tb_alamat.Text,
                tb_noTlp.Text,
                tb_namalengkap.Text);

            MessageBox.Show("Data berhasil diperbarui!");
            tb_namalengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_Simpan.Enabled = false;
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            LoadData();
            tb_namalengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_noTlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_Simpan.Enabled = false;
        }

        private void btn_Keluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Keluar_Click(object sender, EventArgs e)
        {

        }
    }
}