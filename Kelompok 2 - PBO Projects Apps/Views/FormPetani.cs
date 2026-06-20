using Kelompok_2___PBO_Projects_Apps.Views;
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
        private int _idPetani;

        public FormPetani(int idPetani)
        {
            InitializeComponent();
            _idPetani = idPetani;
        }

        private void btn_kelola_profil_Click(object sender, EventArgs e)
        {

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