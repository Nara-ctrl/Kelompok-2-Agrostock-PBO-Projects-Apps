namespace Kelompok_2___PBO_Projects_Apps.Views
{
    partial class FormKelolaProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaProfilAdmin));
            tb_namaLengkap = new TextBox();
            tb_noTlp = new TextBox();
            tb_alamat = new TextBox();
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_Edit = new Button();
            btn_Simpan = new Button();
            btn_Batal = new Button();
            btn_Keluar = new Button();
            txt_alamat = new TextBox();
            SuspendLayout();
            // 
            // tb_namaLengkap
            // 
            tb_namaLengkap.Location = new Point(120, 224);
            tb_namaLengkap.Multiline = true;
            tb_namaLengkap.Name = "tb_namaLengkap";
            tb_namaLengkap.Size = new Size(157, 17);
            tb_namaLengkap.TabIndex = 0;
            // 
            // tb_noTlp
            // 
            tb_noTlp.Location = new Point(119, 321);
            tb_noTlp.Multiline = true;
            tb_noTlp.Name = "tb_noTlp";
            tb_noTlp.Size = new Size(162, 16);
            tb_noTlp.TabIndex = 2;
            // 
            // tb_alamat
            // 
            tb_alamat.Location = new Point(120, 271);
            tb_alamat.Multiline = true;
            tb_alamat.Name = "tb_alamat";
            tb_alamat.Size = new Size(155, 17);
            tb_alamat.TabIndex = 3;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(365, 228);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(162, 18);
            tb_username.TabIndex = 4;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(366, 276);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(159, 17);
            tb_password.TabIndex = 5;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.Transparent;
            btn_Edit.Cursor = Cursors.Hand;
            btn_Edit.FlatAppearance.BorderSize = 0;
            btn_Edit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Edit.FlatStyle = FlatStyle.Flat;
            btn_Edit.Location = new Point(603, 173);
            btn_Edit.Margin = new Padding(2);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(86, 22);
            btn_Edit.TabIndex = 6;
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Simpan
            // 
            btn_Simpan.BackColor = Color.Transparent;
            btn_Simpan.Cursor = Cursors.Hand;
            btn_Simpan.FlatAppearance.BorderSize = 0;
            btn_Simpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Simpan.FlatStyle = FlatStyle.Flat;
            btn_Simpan.Location = new Point(602, 205);
            btn_Simpan.Margin = new Padding(2);
            btn_Simpan.Name = "btn_Simpan";
            btn_Simpan.Size = new Size(86, 22);
            btn_Simpan.TabIndex = 7;
            btn_Simpan.UseVisualStyleBackColor = false;
            btn_Simpan.Click += btn_Simpan_Click;
            // 
            // btn_Batal
            // 
            btn_Batal.BackColor = Color.Transparent;
            btn_Batal.Cursor = Cursors.Hand;
            btn_Batal.FlatAppearance.BorderSize = 0;
            btn_Batal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Batal.FlatStyle = FlatStyle.Flat;
            btn_Batal.Location = new Point(602, 239);
            btn_Batal.Margin = new Padding(2);
            btn_Batal.Name = "btn_Batal";
            btn_Batal.Size = new Size(86, 22);
            btn_Batal.TabIndex = 8;
            btn_Batal.UseVisualStyleBackColor = false;
            btn_Batal.Click += btn_Batal_Click;
            // 
            // btn_Keluar
            // 
            btn_Keluar.BackColor = Color.Transparent;
            btn_Keluar.Cursor = Cursors.Hand;
            btn_Keluar.FlatAppearance.BorderSize = 0;
            btn_Keluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Keluar.FlatStyle = FlatStyle.Flat;
            btn_Keluar.Location = new Point(603, 271);
            btn_Keluar.Margin = new Padding(2);
            btn_Keluar.Name = "btn_Keluar";
            btn_Keluar.Size = new Size(86, 22);
            btn_Keluar.TabIndex = 9;
            btn_Keluar.UseVisualStyleBackColor = false;
            btn_Keluar.Click += btn_Keluar_Click;
            // 
            // txt_alamat
            // 
            txt_alamat.Location = new Point(122, 272);
            txt_alamat.Multiline = true;
            txt_alamat.Name = "txt_alamat";
            txt_alamat.Size = new Size(155, 17);
            txt_alamat.TabIndex = 3;
            // 
            // FormKelolaProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Keluar);
            Controls.Add(btn_Batal);
            Controls.Add(btn_Simpan);
            Controls.Add(btn_Edit);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(txt_alamat);
            Controls.Add(tb_alamat);
            Controls.Add(tb_noTlp);
            Controls.Add(tb_namaLengkap);
            Name = "FormKelolaProfilAdmin";
            Text = "FormKelolaProfilAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_namaLengkap;
        private TextBox tb_noTlp;
        private TextBox tb_alamat;
        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_Edit;
        private Button btn_Simpan;
        private Button btn_Batal;
        private Button btn_Keluar;
        private TextBox txt_alamat;
    }
}