
using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using System;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormInputData : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private Komoditas _komoditas;

        public FormInputData(Komoditas komoditas)
        {
            InitializeComponent();
            _komoditas = komoditas;

            if (_komoditas != null)
            {
                tb_id_komoditas.Text = _komoditas.id_komoditas;
                tb_id_komoditas.Enabled = false;
                tb_nama_komoditas.Text = _komoditas.nama_komoditas;
                tb_Jumlah.Text = _komoditas.jumlah.ToString(); 
                tbs_satuan.Text = _komoditas.satuan;
                this.Text = "Edit Komoditas";
            }
            else
            {
                tb_id_komoditas.Text = db.GenerateIdKomoditas();
                tb_id_komoditas.Enabled = false;
                this.Text = "Tambah Komoditas";
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (tb_nama_komoditas.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tb_Jumlah.Text, out int jumlah))
            {
                MessageBox.Show("Jumlah harus berupa angka!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Komoditas k = new Komoditas(tb_id_komoditas.Text, tb_nama_komoditas.Text, jumlah, tbs_satuan.Text); 

            if (_komoditas == null)
            {
                db.InsertKomoditas(k);
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses");
            }
            else
            {
                db.UpdateKomoditas(k);
                MessageBox.Show("Data berhasil diperbarui!", "Sukses");
            }

            this.Close();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbSatuan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}