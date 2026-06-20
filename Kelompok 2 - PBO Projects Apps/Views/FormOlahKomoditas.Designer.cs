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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOlahKomoditas));
            dgv_komoditas = new DataGridView();
            TbSatuan = new Label();
            btnTambah = new Button();
            btn_keluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_komoditas).BeginInit();
            SuspendLayout();
            // 
            // dgv_komoditas
            // 
            dgv_komoditas.AllowUserToAddRows = false;
            dgv_komoditas.BackgroundColor = Color.DarkOliveGreen;
            dgv_komoditas.BorderStyle = BorderStyle.None;
            dgv_komoditas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_komoditas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_komoditas.GridColor = Color.LightGray;
            dgv_komoditas.Location = new Point(116, 168);
            dgv_komoditas.Name = "dgv_komoditas";
            dgv_komoditas.ReadOnly = true;
            dgv_komoditas.RowHeadersWidth = 51;
            dgv_komoditas.Size = new Size(546, 167);
            dgv_komoditas.TabIndex = 0;
            // 
            // TbSatuan
            // 
            TbSatuan.AutoSize = true;
            TbSatuan.BackColor = Color.Transparent;
            TbSatuan.Location = new Point(116, 234);
            TbSatuan.Name = "TbSatuan";
            TbSatuan.Size = new Size(0, 20);
            TbSatuan.TabIndex = 3;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.GreenYellow;
            btnTambah.Location = new Point(116, 123);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah ";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // btn_keluar
            // 
            btn_keluar.BackColor = Color.Red;
            btn_keluar.Location = new Point(567, 123);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(94, 29);
            btn_keluar.TabIndex = 8;
            btn_keluar.Text = "Keluar";
            btn_keluar.UseVisualStyleBackColor = false;
            btn_keluar.Click += btn_keluar_Click;
            // 
            // FormOlahKomoditas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 405);
            ControlBox = false;
            Controls.Add(btn_keluar);
            Controls.Add(btnTambah);
            Controls.Add(TbSatuan);
            Controls.Add(dgv_komoditas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button btnTambah;
        private Button btn_keluar;
    }
}