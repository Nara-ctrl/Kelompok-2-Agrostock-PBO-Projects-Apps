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

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                UserController uc = new UserController();

                User user = uc.Login(tb_username.Text, tb_password.Text);

                if (user != null && user.Validasi())
                {
                    this.Hide();
                    if (user is AdminGudang admin)
                    {
                        FormAdmin formAdmin = new FormAdmin(admin);
                        formAdmin.Show();
                    }
                    else if (user is Petani petani)
                    {
                        FormPetani formPetani = new FormPetani(petani.IdPetani);
                        formPetani.Show();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
