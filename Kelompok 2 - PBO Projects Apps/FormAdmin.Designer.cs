namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            btn_olah_komoditas = new Button();
            btn_logout = new Button();
            btn_p_register = new Button();
            SuspendLayout();
            // 
            // btn_olah_komoditas
            // 
            btn_olah_komoditas.BackColor = Color.Transparent;
            btn_olah_komoditas.Cursor = Cursors.Hand;
            btn_olah_komoditas.FlatAppearance.BorderSize = 0;
            btn_olah_komoditas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_olah_komoditas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_olah_komoditas.FlatStyle = FlatStyle.Flat;
            btn_olah_komoditas.Location = new Point(412, 155);
            btn_olah_komoditas.Margin = new Padding(2, 2, 2, 2);
            btn_olah_komoditas.Name = "btn_olah_komoditas";
            btn_olah_komoditas.Size = new Size(99, 82);
            btn_olah_komoditas.TabIndex = 1;
            btn_olah_komoditas.UseVisualStyleBackColor = false;
            btn_olah_komoditas.Click += btn_olah_komoditas_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.Transparent;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_logout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Location = new Point(412, 254);
            btn_logout.Margin = new Padding(2, 2, 2, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(99, 82);
            btn_logout.TabIndex = 2;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_p_register
            // 
            btn_p_register.BackColor = Color.Transparent;
            btn_p_register.Cursor = Cursors.Hand;
            btn_p_register.FlatAppearance.BorderSize = 0;
            btn_p_register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_p_register.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_p_register.FlatStyle = FlatStyle.Flat;
            btn_p_register.Location = new Point(131, 155);
            btn_p_register.Margin = new Padding(2);
            btn_p_register.Name = "btn_p_register";
            btn_p_register.Size = new Size(99, 82);
            btn_p_register.TabIndex = 0;
            btn_p_register.UseVisualStyleBackColor = false;
            btn_p_register.Click += btn_register_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 405);
            ControlBox = false;
            Controls.Add(btn_logout);
            Controls.Add(btn_olah_komoditas);
            Controls.Add(btn_p_register);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_olah_komoditas;
        private Button btn_logout;
        private Button btn_p_register;
    }
}