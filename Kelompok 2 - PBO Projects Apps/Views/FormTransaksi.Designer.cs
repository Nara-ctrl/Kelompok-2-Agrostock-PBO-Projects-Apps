namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
            btn_masuk = new Button();
            btn_keluar = new Button();
            cb_komoditas = new ComboBox();
            label1 = new Label();
            lbl_petani = new Label();
            cb_petani = new ComboBox();
            tb_jumlah = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lbl_status = new Label();
            lbl_tanggal = new Label();
            btn_simpan = new Button();
            btn_batal = new Button();
            label2 = new Label();
            label5 = new Label();
            lbl_satuan = new Label();
            lbl_stok = new Label();
            value_stok = new Label();
            SuspendLayout();
            // 
            // btn_masuk
            // 
            btn_masuk.FlatStyle = FlatStyle.Popup;
            btn_masuk.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_masuk.Location = new Point(164, 183);
            btn_masuk.Name = "btn_masuk";
            btn_masuk.Size = new Size(112, 34);
            btn_masuk.TabIndex = 0;
            btn_masuk.Text = "Stok Masuk";
            btn_masuk.UseVisualStyleBackColor = true;
            btn_masuk.Click += btn_masuk_Click;
            // 
            // btn_keluar
            // 
            btn_keluar.FlatStyle = FlatStyle.Popup;
            btn_keluar.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_keluar.Location = new Point(282, 183);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(112, 34);
            btn_keluar.TabIndex = 1;
            btn_keluar.Text = "Stok Keluar";
            btn_keluar.UseVisualStyleBackColor = true;
            btn_keluar.Click += btn_keluar_Click;
            // 
            // cb_komoditas
            // 
            cb_komoditas.FormattingEnabled = true;
            cb_komoditas.Location = new Point(282, 251);
            cb_komoditas.Name = "cb_komoditas";
            cb_komoditas.Size = new Size(156, 33);
            cb_komoditas.TabIndex = 2;
            cb_komoditas.SelectedIndexChanged += cb_komoditas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 252);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 3;
            label1.Text = "Komoditas :";
            // 
            // lbl_petani
            // 
            lbl_petani.AutoSize = true;
            lbl_petani.BackColor = Color.Transparent;
            lbl_petani.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_petani.Location = new Point(155, 295);
            lbl_petani.Name = "lbl_petani";
            lbl_petani.Size = new Size(75, 25);
            lbl_petani.TabIndex = 4;
            lbl_petani.Text = "Petani :";
            // 
            // cb_petani
            // 
            cb_petani.FormattingEnabled = true;
            cb_petani.Location = new Point(282, 295);
            cb_petani.Name = "cb_petani";
            cb_petani.Size = new Size(156, 33);
            cb_petani.TabIndex = 5;
            // 
            // tb_jumlah
            // 
            tb_jumlah.Location = new Point(282, 339);
            tb_jumlah.Name = "tb_jumlah";
            tb_jumlah.Size = new Size(156, 31);
            tb_jumlah.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 339);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 7;
            label3.Text = "Jumlah :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(155, 383);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 8;
            label4.Text = "Satuan :";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.BackColor = Color.Transparent;
            lbl_status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status.Location = new Point(638, 295);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(73, 25);
            lbl_status.TabIndex = 10;
            lbl_status.Text = "Status?";
            // 
            // lbl_tanggal
            // 
            lbl_tanggal.AutoSize = true;
            lbl_tanggal.BackColor = Color.Transparent;
            lbl_tanggal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tanggal.Location = new Point(638, 254);
            lbl_tanggal.Name = "lbl_tanggal";
            lbl_tanggal.Size = new Size(87, 25);
            lbl_tanggal.TabIndex = 11;
            lbl_tanggal.Text = "Tanggal?";
            // 
            // btn_simpan
            // 
            btn_simpan.FlatStyle = FlatStyle.Popup;
            btn_simpan.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_simpan.Location = new Point(538, 374);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(112, 34);
            btn_simpan.TabIndex = 12;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = true;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // btn_batal
            // 
            btn_batal.FlatStyle = FlatStyle.Popup;
            btn_batal.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_batal.Location = new Point(701, 374);
            btn_batal.Name = "btn_batal";
            btn_batal.Size = new Size(112, 34);
            btn_batal.TabIndex = 13;
            btn_batal.Text = "Keluar";
            btn_batal.UseVisualStyleBackColor = true;
            btn_batal.Click += btn_batal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(538, 253);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 14;
            label2.Text = "Tanggal :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(538, 295);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 15;
            label5.Text = "Status :";
            // 
            // lbl_satuan
            // 
            lbl_satuan.AutoSize = true;
            lbl_satuan.BackColor = Color.Transparent;
            lbl_satuan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_satuan.Location = new Point(276, 383);
            lbl_satuan.Name = "lbl_satuan";
            lbl_satuan.Size = new Size(79, 25);
            lbl_satuan.TabIndex = 16;
            lbl_satuan.Text = "Satuan?";
            // 
            // lbl_stok
            // 
            lbl_stok.AutoSize = true;
            lbl_stok.BackColor = Color.Transparent;
            lbl_stok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_stok.Location = new Point(155, 295);
            lbl_stok.Name = "lbl_stok";
            lbl_stok.Size = new Size(60, 25);
            lbl_stok.TabIndex = 17;
            lbl_stok.Text = "Stok :";
            // 
            // value_stok
            // 
            value_stok.AutoSize = true;
            value_stok.BackColor = Color.Transparent;
            value_stok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            value_stok.Location = new Point(276, 295);
            value_stok.Name = "value_stok";
            value_stok.Size = new Size(58, 25);
            value_stok.TabIndex = 18;
            value_stok.Text = "Stok?";
            // 
            // FormTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 506);
            ControlBox = false;
            Controls.Add(value_stok);
            Controls.Add(lbl_stok);
            Controls.Add(lbl_satuan);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(btn_batal);
            Controls.Add(btn_simpan);
            Controls.Add(lbl_tanggal);
            Controls.Add(lbl_status);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_jumlah);
            Controls.Add(cb_petani);
            Controls.Add(lbl_petani);
            Controls.Add(label1);
            Controls.Add(cb_komoditas);
            Controls.Add(btn_keluar);
            Controls.Add(btn_masuk);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Catat Transaksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_masuk;
        private Button btn_keluar;
        private ComboBox cb_komoditas;
        private Label label1;
        private Label lbl_petani;
        private ComboBox cb_petani;
        private TextBox tb_jumlah;
        private Label label3;
        private Label label4;
        private Label lbl_status;
        private Label lbl_tanggal;
        private Button btn_simpan;
        private Button btn_batal;
        private Label label2;
        private Label label5;
        private Label lbl_satuan;
        private Label lbl_stok;
        private Label value_stok;
    }
}