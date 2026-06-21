using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormProfilPetani : Form
    {
        private Petani petaniLogin;

        public FormProfilPetani(Petani petani)
        {
            InitializeComponent();
            petaniLogin = petani;
            this.Load += FormProfilPetani_Load;
        }

        private void FormProfilPetani_Load(object sender, EventArgs e)
        {
            LoadDataPetani();
            tb_namalengkap.ReadOnly = true;
            tb_alamat.ReadOnly = true;
            tb_notlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_simpan.Enabled = false;

            btn_edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        

        private void LoadDataPetani()
        {
            tb_namalengkap.Text = petaniLogin.Nama;
            tb_alamat.Text = petaniLogin.Alamat;
            tb_notlp.Text = petaniLogin.NoTlp;
            tb_username.Text = petaniLogin.Username;
            tb_password.Text = petaniLogin.Password;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tb_alamat.ReadOnly = false;
            tb_notlp.ReadOnly = false;
            tb_username.ReadOnly = false;
            tb_password.ReadOnly = false;
            btn_simpan.Enabled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            db.UpdateProfilPetani(petaniLogin.UserId, tb_username.Text,
                tb_password.Text, tb_alamat.Text, tb_notlp.Text);
            petaniLogin.Username = tb_username.Text;
            petaniLogin.Password = tb_password.Text;
            petaniLogin.Alamat = tb_alamat.Text;
            petaniLogin.NoTlp = tb_notlp.Text;
            MessageBox.Show("Profil berhasil diperbarui");
            tb_alamat.ReadOnly = true;
            tb_notlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_simpan.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            LoadDataPetani();
            tb_alamat.ReadOnly = true;
            tb_notlp.ReadOnly = true;
            tb_username.ReadOnly = true;
            tb_password.ReadOnly = true;
            btn_simpan .Enabled = false;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}