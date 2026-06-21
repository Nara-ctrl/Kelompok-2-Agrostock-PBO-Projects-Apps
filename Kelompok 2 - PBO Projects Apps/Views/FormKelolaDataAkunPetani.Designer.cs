namespace Kelompok_2___PBO_Projects_Apps.Views
{
    partial class FormKelolaDataAkunPetani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaDataAkunPetani));
            dgv_petani = new DataGridView();
            btn_keluar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_petani).BeginInit();
            SuspendLayout();
            // 
            // dgv_petani
            // 
            dgv_petani.BackgroundColor = Color.White;
            dgv_petani.BorderStyle = BorderStyle.None;
            dgv_petani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_petani.Location = new Point(204, 268);
            dgv_petani.Margin = new Padding(4);
            dgv_petani.Name = "dgv_petani";
            dgv_petani.RowHeadersWidth = 51;
            dgv_petani.Size = new Size(758, 235);
            dgv_petani.TabIndex = 0;
            // 
            // btn_keluar
            // 
            btn_keluar.BackColor = Color.Transparent;
            btn_keluar.Cursor = Cursors.Hand;
            btn_keluar.FlatAppearance.BorderSize = 0;
            btn_keluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar.FlatStyle = FlatStyle.Flat;
            btn_keluar.Location = new Point(834, 186);
            btn_keluar.Margin = new Padding(2);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(128, 30);
            btn_keluar.TabIndex = 1;
            btn_keluar.UseVisualStyleBackColor = false;
            btn_keluar.Click += btn_keluar_Click_1;
            // 
            // FormKelolaDataAkunPetani
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 619);
            Controls.Add(btn_keluar);
            Controls.Add(dgv_petani);
            Margin = new Padding(4);
            Name = "FormKelolaDataAkunPetani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKelolaDataAkunPetani";
            Load += FormKelolaDataAkunPetani_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_petani).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_petani;
        private Button btn_keluar;
    }
}