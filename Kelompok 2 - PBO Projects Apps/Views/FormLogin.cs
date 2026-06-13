using Kelompok_2___PBO_Projects_Apps.Controllers;
using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using Npgsql;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            tb_password.UseSystemPasswordChar = true;
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                UserController uc = new UserController();

                User user = uc.Login(tb_username.Text, tb_password.Text);

                if (user != null && user.Validasi())
                {
                    MessageBox.Show("Login berhasil");
                    this.Hide();

                    if (user is AdminGudang)
                    {
                        FormAdmin admin = new FormAdmin();
                        admin.Show();
                    }
                    else if (user is Petani)
                    {
                        FormPetani petani = new FormPetani();
                        petani.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
