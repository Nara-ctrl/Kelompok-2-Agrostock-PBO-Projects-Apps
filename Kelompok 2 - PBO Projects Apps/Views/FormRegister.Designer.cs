namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormRegister
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            tb_r_username = new TextBox();
            tb_r_password = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            btn_register = new Button();
            tb_r_alamat = new TextBox();
            tb_r_notlp = new TextBox();
            tb_r_nama = new TextBox();
            SuspendLayout();
            // 
            // tb_r_username
            // 
            tb_r_username.BorderStyle = BorderStyle.None;
            tb_r_username.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_r_username.Location = new Point(559, 249);
            tb_r_username.Margin = new Padding(2);
            tb_r_username.Name = "tb_r_username";
            tb_r_username.Size = new Size(225, 22);
            tb_r_username.TabIndex = 0;
            // 
            // tb_r_password
            // 
            tb_r_password.BorderStyle = BorderStyle.None;
            tb_r_password.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_r_password.Location = new Point(559, 311);
            tb_r_password.Margin = new Padding(2);
            tb_r_password.Name = "tb_r_password";
            tb_r_password.Size = new Size(225, 22);
            tb_r_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 96);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Transparent;
            btn_register.Cursor = Cursors.Hand;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_register.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.Honeydew;
            btn_register.Location = new Point(559, 361);
            btn_register.Margin = new Padding(2);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(225, 29);
            btn_register.TabIndex = 5;
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // tb_r_alamat
            // 
            tb_r_alamat.BorderStyle = BorderStyle.None;
            tb_r_alamat.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_r_alamat.Location = new Point(193, 305);
            tb_r_alamat.Margin = new Padding(2);
            tb_r_alamat.Name = "tb_r_alamat";
            tb_r_alamat.Size = new Size(225, 22);
            tb_r_alamat.TabIndex = 6;
            // 
            // tb_r_notlp
            // 
            tb_r_notlp.BorderStyle = BorderStyle.None;
            tb_r_notlp.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_r_notlp.Location = new Point(193, 368);
            tb_r_notlp.Margin = new Padding(2);
            tb_r_notlp.Name = "tb_r_notlp";
            tb_r_notlp.Size = new Size(225, 22);
            tb_r_notlp.TabIndex = 7;
            // 
            // tb_r_nama
            // 
            tb_r_nama.BorderStyle = BorderStyle.None;
            tb_r_nama.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_r_nama.Location = new Point(193, 243);
            tb_r_nama.Margin = new Padding(2);
            tb_r_nama.Name = "tb_r_nama";
            tb_r_nama.Size = new Size(225, 22);
            tb_r_nama.TabIndex = 8;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 506);
            Controls.Add(tb_r_nama);
            Controls.Add(tb_r_notlp);
            Controls.Add(tb_r_alamat);
            Controls.Add(btn_register);
            Controls.Add(label1);
            Controls.Add(tb_r_password);
            Controls.Add(tb_r_username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_r_username;
        private TextBox tb_r_password;
        private Label label1;
        private ImageList imageList1;
        private Button btn_register;
        private TextBox tb_r_alamat;
        private TextBox tb_r_notlp;
        private TextBox tb_r_nama;
    }
}