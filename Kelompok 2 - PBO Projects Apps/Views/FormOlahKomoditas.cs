using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using System;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps
{
    public partial class FormOlahKomoditas : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public FormOlahKomoditas()
        {
            InitializeComponent();
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            dgv_komoditas.AutoGenerateColumns = false;
            dgv_komoditas.AllowUserToAddRows = false;
            dgv_komoditas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_komoditas.MultiSelect = false;
            dgv_komoditas.ReadOnly = false;
            //kolom edi
            dgv_komoditas.Columns.Add(new DataGridViewTextBoxColumn { Name = "id", HeaderText = "ID Komoditas", DataPropertyName = "id_komoditas" });
            dgv_komoditas.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama", HeaderText = "Nama Komoditas", DataPropertyName = "nama_komoditas" });
            dgv_komoditas.Columns.Add(new DataGridViewTextBoxColumn { Name = "satuan", HeaderText = "Satuan", DataPropertyName = "satuan" });

            // Kolom Edit
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.HeaderText = "";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.DefaultCellStyle.BackColor = System.Drawing.Color.SteelBlue;
            btnEdit.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            btnEdit.Width = 70;
            btnEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_komoditas.Columns.Add(btnEdit);

            // Kolom Hapus
            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "Hapus";
            btnHapus.HeaderText = "";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            btnHapus.DefaultCellStyle.BackColor = System.Drawing.Color.Crimson;
            btnHapus.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            btnHapus.Width = 70;
            btnHapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_komoditas.Columns.Add(btnHapus);

            dgv_komoditas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_komoditas.Columns["Edit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_komoditas.Columns["Hapus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgv_komoditas.CellClick += dataGridView1_CellClick;
        }

        private void LoadData()
        {
            dgv_komoditas.DataSource = db.GetAllKomoditas();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormInputData formInput = new FormInputData(null);
            formInput.ShowDialog();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_komoditas.Rows[e.RowIndex];
            string id = row.Cells["id"].Value?.ToString();
            string nama = row.Cells["nama"].Value?.ToString();
            string satuan = row.Cells["satuan"].Value?.ToString();

            if (e.ColumnIndex == dgv_komoditas.Columns["Edit"].Index)
            {
                Komoditas k = new Komoditas(id, nama, satuan);
                FormInputData formInput = new FormInputData(k);
                formInput.ShowDialog();
                LoadData();
            }

            if (e.ColumnIndex == dgv_komoditas.Columns["Hapus"].Index)
            {
                var konfirmasi = MessageBox.Show(
                    $"Hapus komoditas '{nama}'?",
                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    db.DeleteKomoditas(id);
                    LoadData();
                }
            }
        }

        private void Formmengolahkomoditas_Load(object sender, EventArgs e)
        {

        }
    }
}