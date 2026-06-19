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
            tb_password = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.BorderStyle = BorderStyle.None;
            tb_username.Location = new Point(583, 225);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(278, 24);
            tb_username.TabIndex = 0;
            // 
            // L_username
            // 
            L_username.AutoSize = true;
            L_username.BackColor = Color.Transparent;
            L_username.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L_username.ForeColor = Color.OliveDrab;
            L_username.Location = new Point(552, 181);
            L_username.Name = "L_username";
            L_username.Size = new Size(0, 25);
            L_username.TabIndex = 1;
            // 
            // l_password
            // 
            l_password.AutoSize = true;
            l_password.BackColor = Color.Transparent;
            l_password.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_password.ForeColor = Color.OliveDrab;
            l_password.Location = new Point(552, 257);
            l_password.Name = "l_password";
            l_password.Size = new Size(0, 25);
            l_password.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.None;
            tb_password.Location = new Point(583, 306);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(278, 24);
            tb_password.TabIndex = 3;
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
            btn_login.Location = new Point(583, 376);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(278, 34);
            btn_login.TabIndex = 4;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 506);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(l_password);
            Controls.Add(L_username);
            Controls.Add(tb_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private Label L_username;
        private Label l_password;
        private TextBox tb_password;
        private Button btn_login;
    }
}
