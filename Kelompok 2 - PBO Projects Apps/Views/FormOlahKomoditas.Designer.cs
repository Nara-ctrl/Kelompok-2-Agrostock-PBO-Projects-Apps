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
            dgv_komoditas.Location = new Point(121, 210);
            dgv_komoditas.Margin = new Padding(4, 4, 4, 4);
            dgv_komoditas.Name = "dgv_komoditas";
            dgv_komoditas.ReadOnly = true;
            dgv_komoditas.RowHeadersWidth = 51;
            dgv_komoditas.Size = new Size(746, 279);
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
            // btnTambah
            // 
            btnTambah.BackColor = Color.GreenYellow;
            btnTambah.Location = new Point(145, 154);
            btnTambah.Margin = new Padding(4, 4, 4, 4);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(118, 36);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah ";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // FormOlahKomoditas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnTambah);
            Controls.Add(TbSatuan);
            Controls.Add(dgv_komoditas);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormOlahKomoditas";
            Text = "Form Mengolah Komoditas";
            Load += Formmengolahkomoditas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_komoditas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_komoditas;
        private Label TbSatuan;
        private Button btnTambah;
    }
}