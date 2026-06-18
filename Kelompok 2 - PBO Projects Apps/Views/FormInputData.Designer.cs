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
            label4 = new Label();
            tb_Jumlah = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 69);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Komoditas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 108);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 1;
            label2.Text = "Nama Komoditas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 179);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Satuan";
            // 
            // tb_id_komoditas
            // 
            tb_id_komoditas.Location = new Point(202, 66);
            tb_id_komoditas.Name = "tb_id_komoditas";
            tb_id_komoditas.Size = new Size(125, 27);
            tb_id_komoditas.TabIndex = 3;
            // 
            // tb_nama_komoditas
            // 
            tb_nama_komoditas.Location = new Point(202, 105);
            tb_nama_komoditas.Name = "tb_nama_komoditas";
            tb_nama_komoditas.Size = new Size(125, 27);
            tb_nama_komoditas.TabIndex = 4;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.YellowGreen;
            btn_simpan.Location = new Point(58, 242);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(104, 35);
            btn_simpan.TabIndex = 6;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // btn_batal
            // 
            btn_batal.BackColor = Color.Red;
            btn_batal.Location = new Point(218, 242);
            btn_batal.Name = "btn_batal";
            btn_batal.Size = new Size(109, 34);
            btn_batal.TabIndex = 7;
            btn_batal.Text = "Batal";
            btn_batal.UseVisualStyleBackColor = false;
            btn_batal.Click += btn_batal_Click;
            // 
            // tbs_satuan
            // 
            tbs_satuan.DropDownStyle = ComboBoxStyle.DropDownList;
            tbs_satuan.FormattingEnabled = true;
            tbs_satuan.Items.AddRange(new object[] { "Kg", "Ton" });
            tbs_satuan.Location = new Point(202, 176);
            tbs_satuan.Name = "tbs_satuan";
            tbs_satuan.Size = new Size(125, 28);
            tbs_satuan.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 143);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 9;
            label4.Text = "Jumlah";
            // 
            // tb_Jumlah
            // 
            tb_Jumlah.Location = new Point(202, 140);
            tb_Jumlah.Name = "tb_Jumlah";
            tb_Jumlah.Size = new Size(125, 27);
            tb_Jumlah.TabIndex = 10;
            // 
            // FormInputData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(415, 332);
            Controls.Add(tb_Jumlah);
            Controls.Add(label4);
            Controls.Add(tbs_satuan);
            Controls.Add(btn_batal);
            Controls.Add(btn_simpan);
            Controls.Add(tb_nama_komoditas);
            Controls.Add(tb_id_komoditas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormInputData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forminputdata";
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
        private Label label4;
        private TextBox tb_Jumlah;
    }
}