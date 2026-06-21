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
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_edit = new Button();
            btn_simpan = new Button();
            btn_batal = new Button();
            btn_keluar = new Button();
            tb_alamat = new TextBox();
            SuspendLayout();
            // 
            // tb_namaLengkap
            // 
            tb_namaLengkap.BorderStyle = BorderStyle.None;
            tb_namaLengkap.Location = new Point(177, 308);
            tb_namaLengkap.Margin = new Padding(4, 4, 4, 4);
            tb_namaLengkap.Multiline = true;
            tb_namaLengkap.Name = "tb_namaLengkap";
            tb_namaLengkap.Size = new Size(233, 23);
            tb_namaLengkap.TabIndex = 0;
            // 
            // tb_noTlp
            // 
            tb_noTlp.BorderStyle = BorderStyle.None;
            tb_noTlp.Location = new Point(177, 440);
            tb_noTlp.Margin = new Padding(4, 4, 4, 4);
            tb_noTlp.Multiline = true;
            tb_noTlp.Name = "tb_noTlp";
            tb_noTlp.Size = new Size(233, 23);
            tb_noTlp.TabIndex = 2;
            // 
            // tb_username
            // 
            tb_username.BorderStyle = BorderStyle.None;
            tb_username.Location = new Point(539, 314);
            tb_username.Margin = new Padding(4, 4, 4, 4);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(233, 23);
            tb_username.TabIndex = 4;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Location = new Point(539, 380);
            tb_password.Margin = new Padding(4, 4, 4, 4);
            tb_password.Multiline = true;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(233, 23);
            tb_password.TabIndex = 5;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Transparent;
            btn_edit.Cursor = Cursors.Hand;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_edit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Location = new Point(886, 237);
            btn_edit.Margin = new Padding(2);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(128, 30);
            btn_edit.TabIndex = 6;
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_Edit_Click;
            // 
            // btn_simpan
            // 
            btn_simpan.BackColor = Color.Transparent;
            btn_simpan.Cursor = Cursors.Hand;
            btn_simpan.FlatAppearance.BorderSize = 0;
            btn_simpan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_simpan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_simpan.FlatStyle = FlatStyle.Flat;
            btn_simpan.Location = new Point(886, 282);
            btn_simpan.Margin = new Padding(2);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(128, 30);
            btn_simpan.TabIndex = 7;
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_Simpan_Click;
            // 
            // btn_batal
            // 
            btn_batal.BackColor = Color.Transparent;
            btn_batal.Cursor = Cursors.Hand;
            btn_batal.FlatAppearance.BorderSize = 0;
            btn_batal.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_batal.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_batal.FlatStyle = FlatStyle.Flat;
            btn_batal.Location = new Point(886, 328);
            btn_batal.Margin = new Padding(2);
            btn_batal.Name = "btn_batal";
            btn_batal.Size = new Size(128, 30);
            btn_batal.TabIndex = 8;
            btn_batal.UseVisualStyleBackColor = false;
            btn_batal.Click += btn_Batal_Click;
            // 
            // btn_keluar
            // 
            btn_keluar.BackColor = Color.Transparent;
            btn_keluar.Cursor = Cursors.Hand;
            btn_keluar.FlatAppearance.BorderSize = 0;
            btn_keluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar.FlatStyle = FlatStyle.Flat;
            btn_keluar.Location = new Point(886, 374);
            btn_keluar.Margin = new Padding(2);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(128, 30);
            btn_keluar.TabIndex = 9;
            btn_keluar.UseVisualStyleBackColor = false;
            btn_keluar.Click += btn_Keluar_Click;
            // 
            // tb_alamat
            // 
            tb_alamat.BorderStyle = BorderStyle.None;
            tb_alamat.Location = new Point(177, 374);
            tb_alamat.Margin = new Padding(4, 4, 4, 4);
            tb_alamat.Multiline = true;
            tb_alamat.Name = "tb_alamat";
            tb_alamat.Size = new Size(233, 23);
            tb_alamat.TabIndex = 3;
            // 
            // FormKelolaProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 619);
            Controls.Add(btn_keluar);
            Controls.Add(btn_batal);
            Controls.Add(btn_simpan);
            Controls.Add(btn_edit);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Controls.Add(tb_alamat);
            Controls.Add(tb_noTlp);
            Controls.Add(tb_namaLengkap);
            Margin = new Padding(4, 4, 4, 4);
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
        private Button btn_edit;
        private Button btn_simpan;
        private Button btn_batal;
        private Button btn_keluar;
    }
}