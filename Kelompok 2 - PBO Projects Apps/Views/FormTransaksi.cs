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
        private DatabaseHelper db = new DatabaseHelper();
        private string _panelAktif = "masuk";
        private List<Komoditas> _listKomoditasMasuk = new List<Komoditas>();
        private List<Komoditas> _listKomoditasKeluar = new List<Komoditas>();
        private List<(int idPetani, string nama)> _listPetaniMasuk = new List<(int, string)>();
        private List<(int idPetani, string nama)> _listPetaniKeluar = new List<(int, string)>();

        public FormTransaksi()
        {
            InitializeComponent();
            TampilkanPanel("masuk");
            lbl_tanggal.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void LoadKomoditasMasuk()
        {
            _listKomoditasMasuk = db.GetAllKomoditas();
            cb_komoditas.Items.Clear();
            foreach (var k in _listKomoditasMasuk)
                cb_komoditas.Items.Add(k.nama_komoditas);
            if (cb_komoditas.Items.Count > 0)
                cb_komoditas.SelectedIndex = 0;
        }

        private void LoadKomoditasKeluar()
        {
            _listKomoditasKeluar = db.GetKomoditasStokMasuk();
            cb_komoditas.Items.Clear();
            foreach (var k in _listKomoditasKeluar)
                cb_komoditas.Items.Add(k.nama_komoditas);
            if (cb_komoditas.Items.Count > 0)
                cb_komoditas.SelectedIndex = 0;
        }

        private void LoadPetaniMasuk()
        {
            _listPetaniMasuk = uc.GetPetaniList();
            cb_petani.Items.Clear();
            foreach (var p in _listPetaniMasuk)
                cb_petani.Items.Add(p.nama);
            if (cb_petani.Items.Count > 0)
                cb_petani.SelectedIndex = 0;
        }

        private void cb_komoditas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_komoditas.SelectedIndex < 0) return;

            string idKomoditas;
            string satuan;

            if (_panelAktif == "masuk")
            {
                idKomoditas = _listKomoditasMasuk[cb_komoditas.SelectedIndex].id_komoditas;
                satuan = _listKomoditasMasuk[cb_komoditas.SelectedIndex].satuan;
            }
            else
            {
                idKomoditas = _listKomoditasKeluar[cb_komoditas.SelectedIndex].id_komoditas;
                satuan = _listKomoditasKeluar[cb_komoditas.SelectedIndex].satuan;
            }

            lbl_satuan.Text = satuan;

            if (_panelAktif == "keluar")
            {
                decimal stok = db.GetJumlahStok(idKomoditas);
                value_stok.Text = $"{stok}";
            }
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

            if (jenis == "masuk")
            {
                LoadKomoditasMasuk();
                LoadPetaniMasuk();
                lbl_petani.Visible = true;
                cb_petani.Visible = true;
                lbl_stok.Visible = false;
                value_stok.Visible = false;
            }
            else
            {
                LoadKomoditasKeluar();
                lbl_petani.Visible = false;
                cb_petani.Visible = false;
                lbl_stok.Visible = true;
                value_stok.Visible = true;
            }

            cb_komoditas_SelectedIndexChanged(null, EventArgs.Empty);

            lbl_status.Text = jenis == "masuk" ? "Masuk" : "Keluar";
            btn_masuk.BackColor = jenis == "masuk" ? Color.Green : Color.LightGray;
            btn_keluar.BackColor = jenis == "keluar" ? Color.OrangeRed : Color.LightGray;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                string idKomoditas;
                int idPetani = 0;

                if (_panelAktif == "masuk")
                {
                    idKomoditas = _listKomoditasMasuk[cb_komoditas.SelectedIndex].id_komoditas;
                    idPetani = _listPetaniMasuk[cb_petani.SelectedIndex].idPetani;
                }
                else
                {
                    if (_listKomoditasKeluar.Count == 0)
                    {
                        MessageBox.Show("Tidak ada komoditas yang tersedia untuk stok keluar.",
                            "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    idKomoditas = _listKomoditasKeluar[cb_komoditas.SelectedIndex].id_komoditas;
                }

                string satuan = _panelAktif == "masuk"
                                ? _listKomoditasMasuk[cb_komoditas.SelectedIndex].satuan
                                : _listKomoditasKeluar[cb_komoditas.SelectedIndex].satuan;
                decimal jumlah = decimal.Parse(tb_jumlah.Text);

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
            if (cb_komoditas.Items.Count > 0)
                cb_komoditas.SelectedIndex = 0;
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