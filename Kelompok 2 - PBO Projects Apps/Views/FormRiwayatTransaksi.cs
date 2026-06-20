using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kelompok_2___PBO_Projects_Apps.Database;

namespace Kelompok_2___PBO_Projects_Apps.Views
{
    public partial class FormRiwayatTransaksi : Form
    {
        private int? _idPetani = null; 

        public FormRiwayatTransaksi()
        {
            InitializeComponent();
        }

        public FormRiwayatTransaksi(int idPetani)
        {
            InitializeComponent();
            _idPetani = idPetani;
        }

        private void FormRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            AturDesainTabel();
            LoadDataRiwayat();
        }

        private void LoadDataRiwayat()
        {
            try
            {
                DataTable dt = _idPetani.HasValue
                    ? new DatabaseHelper().GetRiwayatTransaksiByPetani(_idPetani.Value)
                    : new DatabaseHelper().GetRiwayatTransaksi();

                dgv_R_Transaksi.DataSource = dt;

                dgv_R_Transaksi.Columns["no"].HeaderText = "No.";
                dgv_R_Transaksi.Columns["id_komoditas"].HeaderText = "ID Komoditas";
                dgv_R_Transaksi.Columns["nama_komoditas"].HeaderText = "Komoditas";
                dgv_R_Transaksi.Columns["nama_petani"].HeaderText = "Petani";
                dgv_R_Transaksi.Columns["tanggal_transaksi"].HeaderText = "Tanggal";
                dgv_R_Transaksi.Columns["jumlah"].HeaderText = "Jumlah";
                dgv_R_Transaksi.Columns["satuan"].HeaderText = "Satuan";

                dgv_R_Transaksi.Columns["tanggal_transaksi"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
                dgv_R_Transaksi.Columns["nama_petani"].DefaultCellStyle.NullValue = "-";

                dgv_R_Transaksi.Columns["no"].FillWeight = 8;
                dgv_R_Transaksi.Columns["id_komoditas"].FillWeight = 15;
                dgv_R_Transaksi.Columns["nama_komoditas"].FillWeight = 18;
                dgv_R_Transaksi.Columns["nama_petani"].FillWeight = 18;
                dgv_R_Transaksi.Columns["tanggal_transaksi"].FillWeight = 22;
                dgv_R_Transaksi.Columns["jumlah"].FillWeight = 12;
                dgv_R_Transaksi.Columns["satuan"].FillWeight = 10;

                foreach (DataGridViewRow row in dgv_R_Transaksi.Rows)
                {
                    if (row.Cells["jumlah"].Value != null)
                    {
                        decimal val = Convert.ToDecimal(row.Cells["jumlah"].Value);
                        row.Cells["jumlah"].Style.ForeColor = val < 0 ? Color.Red : Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AturDesainTabel()
        {
            dgv_R_Transaksi.RowHeadersVisible = true;
            dgv_R_Transaksi.RowHeadersWidth = 30;
            dgv_R_Transaksi.EnableHeadersVisualStyles = false;
            dgv_R_Transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_R_Transaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgv_R_Transaksi.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_R_Transaksi.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv_R_Transaksi.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            dgv_R_Transaksi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv_R_Transaksi.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgv_R_Transaksi.DefaultCellStyle.SelectionForeColor = Color.White;
        }


        private void dgv_R_Transaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_R_keluar_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (_idPetani.HasValue)
            {
                FormPetani petani = new FormPetani(_idPetani.Value);
                petani.ShowDialog();
            }
            else
            {
                FormAdmin admin = new FormAdmin();
                admin.ShowDialog();
            }
            this.Close();
        }
    }
}