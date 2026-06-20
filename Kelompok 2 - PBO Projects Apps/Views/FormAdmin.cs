using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Views;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
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
    }
}
