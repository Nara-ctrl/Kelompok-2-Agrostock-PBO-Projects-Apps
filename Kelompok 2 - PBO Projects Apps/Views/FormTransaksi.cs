using Kelompok_2___PBO_Projects_Apps.Controllers;
using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormTransaksi : Form
    {
        private UserController uc = new UserController();
        private string _panelAktif = "masuk";

        public FormTransaksi()
        {
            InitializeComponent();
            LoadKomoditas();
            LoadPetani();
            LoadSatuan();
            TampilkanPanel("masuk");
            lbl_tanggal.Text = DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void LoadKomoditas()
        {
            var list = new DatabaseHelper().GetAllKomoditas();

            cb_komoditas.Items.Clear();
            foreach (var komoditas in list)
            {
                cb_komoditas.Items.Add(komoditas.nama_komoditas);
            }

            if (cb_komoditas.Items.Count > 0)
                cb_komoditas.SelectedIndex = 0;
        }
        private void LoadPetani()
        {
            var list = uc.GetPetaniList();

            cb_petani.Items.Clear();
            foreach (var petani in list)
            {
                cb_petani.Items.Add(petani.nama);
            }

            if (cb_petani.Items.Count > 0)
                cb_petani.SelectedIndex = 0;
        }

        private void LoadSatuan()
        {
            cb_satuan.Items.Clear();
            cb_satuan.Items.Add("kg");
            cb_satuan.Items.Add("ton");
            cb_satuan.Items.Add("kwintal");
            cb_satuan.Items.Add("ikat");
            cb_satuan.Items.Add("karung");
            cb_satuan.Items.Add("buah");
            cb_satuan.SelectedIndex = 0;
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            TampilkanPanel("masuk");
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            TampilkanPanel("keluar");
        }

        private void TampilkanPanel(string jenis)
        {
            _panelAktif = jenis;

            lbl_petani.Visible = jenis == "masuk";
            cb_petani.Visible = jenis == "masuk";

            lbl_status.Text = jenis == "masuk" ? "Masuk" : "Keluar";

            btn_masuk.BackColor = jenis == "masuk" ? System.Drawing.Color.Green : System.Drawing.Color.LightGray;
            btn_keluar.BackColor = jenis == "keluar" ? System.Drawing.Color.OrangeRed : System.Drawing.Color.LightGray;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                var listKomoditas = new DatabaseHelper().GetAllKomoditas();
                var listPetani = uc.GetPetaniList();

                string idKomoditas = listKomoditas[cb_komoditas.SelectedIndex].id_komoditas;
                string satuan = cb_satuan.SelectedItem?.ToString();
                decimal jumlah = decimal.Parse(tb_jumlah.Text);
                int idPetani = _panelAktif == "masuk" ? listPetani[cb_petani.SelectedIndex].idPetani : 0;

                uc.CatatTransaksi(idKomoditas, idPetani, _panelAktif, jumlah, satuan);

                MessageBox.Show("Transaksi berhasil dicatat!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                BersihkanForm();
            }
            catch (FormatException)
            {
                MessageBox.Show("Jumlah harus berupa angka!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BersihkanForm()
        {
            tb_jumlah.Text = "";
            cb_komoditas.SelectedIndex = 0;
            cb_satuan.SelectedIndex = 0;
            if (cb_petani.Items.Count > 0)
                cb_petani.SelectedIndex = 0;
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            FormKelolaData back = new FormKelolaData();
            back.Show();
            this.Hide();
        }
    }
}