namespace Kelompok_2___PBO_Projects_Apps.Views
{
    partial class FormRiwayatTransaksi
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayatTransaksi));
            dgvRiwayat = new DataGridView();
            btn_keluar_R = new Button();
            dgv_R_Transaksi = new DataGridView();
            btn_R_keluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_R_Transaksi).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayat
            // 
            dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayat.BackgroundColor = Color.White;
            dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayat.Location = new Point(199, 214);
            dgvRiwayat.Name = "dgvRiwayat";
            dgvRiwayat.ReadOnly = true;
            dgvRiwayat.RowHeadersWidth = 51;
            dgvRiwayat.Size = new Size(300, 188);
            dgvRiwayat.TabIndex = 0;
            // 
            // btn_keluar_R
            // 
            btn_keluar_R.BackColor = Color.Transparent;
            btn_keluar_R.Cursor = Cursors.Hand;
            btn_keluar_R.FlatAppearance.BorderSize = 0;
            btn_keluar_R.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_keluar_R.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar_R.FlatStyle = FlatStyle.Flat;
            btn_keluar_R.Location = new Point(696, 146);
            btn_keluar_R.Margin = new Padding(2);
            btn_keluar_R.Name = "btn_keluar_R";
            btn_keluar_R.Size = new Size(102, 24);
            btn_keluar_R.TabIndex = 1;
            btn_keluar_R.UseVisualStyleBackColor = false;
            // 
            // dgv_R_Transaksi
            // 
            dgv_R_Transaksi.BackgroundColor = Color.White;
            dgv_R_Transaksi.BorderStyle = BorderStyle.None;
            dgv_R_Transaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_R_Transaksi.Location = new Point(197, 263);
            dgv_R_Transaksi.Name = "dgv_R_Transaksi";
            dgv_R_Transaksi.RowHeadersWidth = 51;
            dgv_R_Transaksi.Size = new Size(784, 234);
            dgv_R_Transaksi.TabIndex = 2;
            dgv_R_Transaksi.CellContentClick += dgv_R_Transaksi_CellContentClick;
            // 
            // btn_R_keluar
            // 
            btn_R_keluar.BackColor = Color.Transparent;
            btn_R_keluar.Cursor = Cursors.Hand;
            btn_R_keluar.FlatAppearance.BorderSize = 0;
            btn_R_keluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_R_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_R_keluar.FlatStyle = FlatStyle.Flat;
            btn_R_keluar.Location = new Point(853, 177);
            btn_R_keluar.Margin = new Padding(2);
            btn_R_keluar.Name = "btn_R_keluar";
            btn_R_keluar.Size = new Size(128, 30);
            btn_R_keluar.TabIndex = 3;
            btn_R_keluar.UseVisualStyleBackColor = false;
            btn_R_keluar.Click += btn_R_keluar_Click;
            // 
            // FormRiwayatTransaksi
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1178, 619);
            ControlBox = false;
            Controls.Add(btn_R_keluar);
            Controls.Add(dgv_R_Transaksi);
            Controls.Add(btn_keluar_R);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRiwayatTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Transaksi";
            Load += FormRiwayatTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRiwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_R_Transaksi).EndInit();
            ResumeLayout(false);
            // 
            // FormRiwayatTransaksi
            // 
        }

        #endregion

        private DataGridView dgvRiwayat;
        private Button btn_keluar_R;
        private DataGridView dgv_R_Transaksi;
        private Button btn_R_keluar;
    }
}