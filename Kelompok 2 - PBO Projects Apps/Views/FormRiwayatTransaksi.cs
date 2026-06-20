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
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
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
                DataTable dt = new DatabaseHelper().GetRiwayatTransaksi();
                dgv_R_Transaksi.DataSource = dt;

                dgv_R_Transaksi.Columns["no"].HeaderText = "No.";
                dgv_R_Transaksi.Columns["id_komoditas"].HeaderText = "ID Komoditas";
                dgv_R_Transaksi.Columns["nama_komoditas"].HeaderText = "Komoditas";
                dgv_R_Transaksi.Columns["tanggal_transaksi"].HeaderText = "Tanggal";
                dgv_R_Transaksi.Columns["jumlah"].HeaderText = "Jumlah";
                dgv_R_Transaksi.Columns["satuan"].HeaderText = "Satuan";

                dgv_R_Transaksi.Columns["tanggal_transaksi"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";

                dgv_R_Transaksi.Columns["no"].Width = 40;
                dgv_R_Transaksi.Columns["id_komoditas"].Width = 90;
                dgv_R_Transaksi.Columns["nama_komoditas"].Width = 130;
                dgv_R_Transaksi.Columns["tanggal_transaksi"].Width = 140;
                dgv_R_Transaksi.Columns["jumlah"].Width = 90;
                dgv_R_Transaksi.Columns["satuan"].Width = 90;

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
            dgv_R_Transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgv_R_Transaksi.ColumnHeadersDefaultCellStyle.BackColor = Color.LimeGreen;
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
            FormAdmin admin = new FormAdmin();
            admin.ShowDialog();
            this.Close(); 
        }
    }
}