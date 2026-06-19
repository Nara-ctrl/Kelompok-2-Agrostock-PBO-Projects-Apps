namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormPetani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetani));
            btn_kelola_profil = new Button();
            btn_logout = new Button();
            btn_riwayat = new Button();
            SuspendLayout();
            // 
            // btn_kelola_profil
            // 
            btn_kelola_profil.BackColor = Color.Transparent;
            btn_kelola_profil.Cursor = Cursors.Hand;
            btn_kelola_profil.FlatAppearance.BorderSize = 0;
            btn_kelola_profil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_kelola_profil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_kelola_profil.FlatStyle = FlatStyle.Flat;
            btn_kelola_profil.Location = new Point(163, 193);
            btn_kelola_profil.Margin = new Padding(2);
            btn_kelola_profil.Name = "btn_kelola_profil";
            btn_kelola_profil.Size = new Size(124, 102);
            btn_kelola_profil.TabIndex = 1;
            btn_kelola_profil.UseVisualStyleBackColor = false;
            btn_kelola_profil.Click += btn_kelola_profil_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Location = new Point(515, 193);
            btn_logout.Margin = new Padding(2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(124, 102);
            btn_logout.TabIndex = 2;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_riwayat
            // 
            btn_riwayat.BackColor = Color.Transparent;
            btn_riwayat.Cursor = Cursors.Hand;
            btn_riwayat.FlatAppearance.BorderSize = 0;
            btn_riwayat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_riwayat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_riwayat.FlatStyle = FlatStyle.Flat;
            btn_riwayat.Location = new Point(339, 193);
            btn_riwayat.Margin = new Padding(2);
            btn_riwayat.Name = "btn_riwayat";
            btn_riwayat.Size = new Size(124, 102);
            btn_riwayat.TabIndex = 4;
            btn_riwayat.UseVisualStyleBackColor = false;
            btn_riwayat.Click += btn_riwayat_Click;
            // 
            // FormPetani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 506);
            ControlBox = false;
            Controls.Add(btn_riwayat);
            Controls.Add(btn_logout);
            Controls.Add(btn_kelola_profil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPetani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Petani";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_kelola_profil;
        private Button btn_logout;
        private Button btn_riwayat;
    }
}