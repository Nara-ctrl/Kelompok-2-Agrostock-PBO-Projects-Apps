namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormOlahKomoditas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_komoditas = new DataGridView();
            TbSatuan = new Label();
            btn_tambah = new Button();
            btn_keluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_komoditas).BeginInit();
            SuspendLayout();
            // 
            // dgv_komoditas
            // 
            dgv_komoditas.AllowUserToAddRows = false;
            dgv_komoditas.BackgroundColor = SystemColors.Window;
            dgv_komoditas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_komoditas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_komoditas.GridColor = Color.LightGray;
            dgv_komoditas.Location = new Point(165, 226);
            dgv_komoditas.Margin = new Padding(4);
            dgv_komoditas.Name = "dgv_komoditas";
            dgv_komoditas.ReadOnly = true;
            dgv_komoditas.RowHeadersWidth = 51;
            dgv_komoditas.Size = new Size(615, 295);
            dgv_komoditas.TabIndex = 0;
            // 
            // TbSatuan
            // 
            TbSatuan.AutoSize = true;
            TbSatuan.BackColor = Color.Transparent;
            TbSatuan.Location = new Point(145, 292);
            TbSatuan.Margin = new Padding(4, 0, 4, 0);
            TbSatuan.Name = "TbSatuan";
            TbSatuan.Size = new Size(0, 25);
            TbSatuan.TabIndex = 3;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = Color.Transparent;
            btn_tambah.BackgroundImageLayout = ImageLayout.None;
            btn_tambah.FlatAppearance.BorderSize = 0;
            btn_tambah.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_tambah.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_tambah.FlatStyle = FlatStyle.Flat;
            btn_tambah.Location = new Point(839, 205);
            btn_tambah.Margin = new Padding(4);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(128, 30);
            btn_tambah.TabIndex = 7;
            btn_tambah.UseVisualStyleBackColor = false;
            btn_tambah.Click += btnTambah_Click;
            // 
            // btn_keluar
            // 
            btn_keluar.BackColor = Color.Transparent;
            btn_keluar.FlatAppearance.BorderSize = 0;
            btn_keluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar.FlatStyle = FlatStyle.Flat;
            btn_keluar.Location = new Point(839, 254);
            btn_keluar.Margin = new Padding(4);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(128, 30);
            btn_keluar.TabIndex = 8;
            btn_keluar.UseVisualStyleBackColor = false;
            btn_keluar.Click += btn_keluar_Click;
            // 
            // FormOlahKomoditas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_kelola_komoditas__admin_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 619);
            ControlBox = false;
            Controls.Add(btn_keluar);
            Controls.Add(btn_tambah);
            Controls.Add(TbSatuan);
            Controls.Add(dgv_komoditas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormOlahKomoditas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola Komoditas (Admin)";
            Load += Formmengolahkomoditas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_komoditas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_komoditas;
        private Label TbSatuan;
        private Button btn_tambah;
        private Button btn_keluar;
    }
}