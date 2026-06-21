using Kelompok_2___PBO_Projects_Apps.Database;
using Kelompok_2___PBO_Projects_Apps.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps.Views
{
    public partial class FormKelolaDataAkunPetani : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public FormKelolaDataAkunPetani()
        {
            InitializeComponent();
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            dgv_petani.AutoGenerateColumns = false;
            dgv_petani.AllowUserToAddRows = false;
            dgv_petani.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_petani.MultiSelect = false;
            dgv_petani.ReadOnly = false;

            dgv_petani.Columns.Add(new DataGridViewTextBoxColumn { Name = "id_user", HeaderText = "Id User", DataPropertyName = "id_user" });
            dgv_petani.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama", HeaderText = "Nama Lengkap", DataPropertyName = "nama" });
            dgv_petani.Columns.Add(new DataGridViewTextBoxColumn { Name = "username", HeaderText = "Username", DataPropertyName = "username" });

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "Edit";
            btnEdit.HeaderText = "";
            btnEdit.Text = "Edit";
            btnEdit.UseColumnTextForButtonValue = true;
            btnEdit.DefaultCellStyle.BackColor = Color.SteelBlue;
            btnEdit.DefaultCellStyle.ForeColor = Color.White;
            btnEdit.Width = 70;
            dgv_petani.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
            btnHapus.Name = "Hapus";
            btnHapus.HeaderText = "";
            btnHapus.Text = "Hapus";
            btnHapus.UseColumnTextForButtonValue = true;
            btnHapus.DefaultCellStyle.BackColor = Color.Crimson;
            btnHapus.DefaultCellStyle.ForeColor = Color.White;
            btnHapus.Width = 70;
            dgv_petani.Columns.Add(btnHapus);

            dgv_petani.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_petani.Columns["Edit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_petani.Columns["Hapus"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgv_petani.CellClick += dgv_petani_CellClick;
        }

        private void LoadData()
        {
            var list = db.GetAllPetani();
            var table = new System.Data.DataTable();
            table.Columns.Add("id_user", typeof(int));
            table.Columns.Add("nama", typeof(string));
            table.Columns.Add("username", typeof(string));

            foreach (var item in list)
                table.Rows.Add(item.idUser, item.nama, item.username);

            dgv_petani.DataSource = table;
        }

        private void dgv_petani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_petani.Rows[e.RowIndex];
            int idUser = Convert.ToInt32(row.Cells["id_user"].Value);
            string nama = row.Cells["nama"].Value?.ToString();
            string username = row.Cells["username"].Value?.ToString();

            if (e.ColumnIndex == dgv_petani.Columns["Edit"].Index)
            {
                FormKelolaDataPetani formEdit = new FormKelolaDataPetani(idUser);
                formEdit.ShowDialog();
                LoadData();
            }

            if (e.ColumnIndex == dgv_petani.Columns["Hapus"].Index)
            {
                var konfirmasi = MessageBox.Show(
                    $"Hapus petani '{nama}'?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (konfirmasi == DialogResult.Yes)
                {
                    db.DeletePetani(idUser);
                    LoadData();
                }
            }
        }

        private void FormKelolaDataAkunPetani_Load(object sender, EventArgs e)
        {

        }

        private void btn_keluar_Click_1(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin(_admin);
            formAdmin.Show();
            this.Close();
        }

        private AdminGudang _admin;

        public FormKelolaDataAkunPetani(AdminGudang admin)
        {
            InitializeComponent();
            _admin = admin;
            SetupGrid();
            LoadData();
        }
    }
}