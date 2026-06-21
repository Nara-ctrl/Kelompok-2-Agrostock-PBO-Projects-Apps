using Kelompok_2___PBO_Projects_Apps.Controllers;
using Kelompok_2___PBO_Projects_Apps.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                UserController uc = new UserController();

                uc.RegisterPetani(tb_r_username.Text, tb_r_password.Text, tb_r_nama.Text, tb_r_alamat.Text, tb_r_notlp.Text);

                MessageBox.Show("Akun petani berhasil dibuat!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void tb_r_alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            FormAdmin back = new FormAdmin(null);
            back.Show();
            this.Hide();
        }
    }
}
