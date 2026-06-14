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
            SuspendLayout();
            // 
            // FormPetani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPetani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPetani";
            ResumeLayout(false);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetani));
            btn_p_register = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btn_p_register
            // 
            btn_p_register.BackColor = Color.Transparent;
            btn_p_register.Cursor = Cursors.Hand;
            btn_p_register.FlatAppearance.BorderSize = 0;
            btn_p_register.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_p_register.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_p_register.FlatStyle = FlatStyle.Flat;
            btn_p_register.Location = new Point(197, 207);
            btn_p_register.Margin = new Padding(2);
            btn_p_register.Name = "btn_p_register";
            btn_p_register.Size = new Size(99, 82);
            btn_p_register.TabIndex = 1;
            btn_p_register.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(361, 207);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(99, 82);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(526, 207);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(99, 82);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            // 
            // FormPetani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(982, 515);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_p_register);
            Name = "FormPetani";
            Text = "FormPetani";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_p_register;
        private Button button1;
        private Button button2;
    }
}