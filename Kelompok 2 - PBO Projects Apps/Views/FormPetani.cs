using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormPetani : Form
    {
        public FormPetani()
        {
            InitializeComponent();
        }

        // Saat FormPetani ditutup, kembali ke Login
        private void FormPetani_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Hide();
        }
    }
}
