namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            tb_username = new TextBox();
            L_username = new Label();
            l_password = new Label();
            btn_login = new Button();
            tb_password = new TextBox();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.BorderStyle = BorderStyle.None;
            tb_username.Font = new Font("Segoe UI", 12F);
            tb_username.Location = new Point(491, 163);
            tb_username.Margin = new Padding(1);
            tb_username.Multiline = true;
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(237, 21);
            tb_username.TabIndex = 0;
            // 
            // L_username
            // 
            L_username.AutoSize = true;
            L_username.BackColor = Color.Transparent;
            L_username.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L_username.ForeColor = Color.OliveDrab;
            L_username.Location = new Point(386, 109);
            L_username.Margin = new Padding(1, 0, 1, 0);
            L_username.Name = "L_username";
            L_username.Size = new Size(0, 15);
            L_username.TabIndex = 1;
            // 
            // l_password
            // 
            l_password.AutoSize = true;
            l_password.BackColor = Color.Transparent;
            l_password.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_password.ForeColor = Color.OliveDrab;
            l_password.Location = new Point(386, 155);
            l_password.Margin = new Padding(1, 0, 1, 0);
            l_password.Name = "l_password";
            l_password.Size = new Size(0, 15);
            l_password.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Transparent;
            btn_login.BackgroundImage = (Image)resources.GetObject("btn_login.BackgroundImage");
            btn_login.BackgroundImageLayout = ImageLayout.Stretch;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_login.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Transparent;
            btn_login.Location = new Point(489, 275);
            btn_login.Margin = new Padding(1);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(239, 27);
            btn_login.TabIndex = 4;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Font = new Font("Segoe UI", 12F);
            tb_password.Location = new Point(491, 223);
            tb_password.Margin = new Padding(1);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(237, 22);
            tb_password.TabIndex = 5;
            tb_password.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(825, 371);
            Controls.Add(tb_password);
            Controls.Add(btn_login);
            Controls.Add(l_password);
            Controls.Add(L_username);
            Controls.Add(tb_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private Label L_username;
        private Label l_password;
        private Button btn_login;
        private TextBox tb_password;
    }
}
