using Kelompok_2___PBO_Projects_Apps.Database;
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
    public partial class FormLihatStock : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public FormLihatStock()
        {
            InitializeComponent();
            SetupGrid();
            LoadData();
        }

        private void SetupGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "id", HeaderText = "ID", DataPropertyName = "id_komoditas" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "nama", HeaderText = "Komoditas", DataPropertyName = "nama_komoditas" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "jumlah", HeaderText = "Jumlah", DataPropertyName = "jumlah" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "satuan", HeaderText = "Satuan", DataPropertyName = "satuan" });

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = db.GetAllStok();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            FormKelolaData back = new FormKelolaData();
            back.Show();
            this.Hide();
        }
    }
}

