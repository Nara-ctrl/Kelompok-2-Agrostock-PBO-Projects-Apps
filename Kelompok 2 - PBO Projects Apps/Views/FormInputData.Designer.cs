namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormInputData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputData));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_id_komoditas = new TextBox();
            tb_nama_komoditas = new TextBox();
            btn_simpan = new Button();
            btn_batal = new Button();
            tbs_satuan = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 91);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Komoditas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Nama Komoditas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 178);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Satuan";
            // 
            // tb_id_komoditas
            // 
            tb_id_komoditas.Location = new Point(206, 82);
            tb_id_komoditas.Margin = new Padding(4);
            tb_id_komoditas.Name = "tb_id_komoditas";
            tb_id_komoditas.Size = new Size(155, 31);
            tb_id_komoditas.TabIndex = 3;
            // 
            // tb_nama_komoditas
            // 
            tb_nama_komoditas.Location = new Point(206, 132);
            tb_nama_komoditas.Margin = new Padding(4);
            tb_nama_komoditas.Name = "tb_nama_komoditas";
            tb_nama_komoditas.Size = new Size(155, 31);
            tb_nama_komoditas.TabIndex = 4;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.YellowGreen;
            btn_simpan.Location = new Point(46, 242);
            btn_simpan.Margin = new Padding(4);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(130, 44);
            btn_simpan.TabIndex = 6;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // btn_batal
            // 
            btn_batal.BackColor = Color.Red;
            btn_batal.Location = new Point(226, 242);
            btn_batal.Margin = new Padding(4);
            btn_batal.Name = "btn_batal";
            btn_batal.Size = new Size(136, 42);
            btn_batal.TabIndex = 7;
            btn_batal.Text = "Batal";
            btn_batal.UseVisualStyleBackColor = false;
            btn_batal.Click += btn_batal_Click;
            // 
            // tbs_satuan
            // 
            tbs_satuan.FormattingEnabled = true;
            tbs_satuan.Items.AddRange(new object[] { "Kg", "Ton" });
            tbs_satuan.Location = new Point(206, 178);
            tbs_satuan.Margin = new Padding(4);
            tbs_satuan.Name = "tbs_satuan";
            tbs_satuan.Size = new Size(155, 33);
            tbs_satuan.TabIndex = 8;
            // 
            // FormInputData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(429, 312);
            ControlBox = false;
            Controls.Add(tbs_satuan);
            Controls.Add(btn_batal);
            Controls.Add(btn_simpan);
            Controls.Add(tb_nama_komoditas);
            Controls.Add(tb_id_komoditas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormInputData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input Data Komoditas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_id_komoditas;
        private TextBox tb_nama_komoditas;
        private Button btn_simpan;
        private Button btn_batal;
        private ComboBox tbs_satuan;
    }
}