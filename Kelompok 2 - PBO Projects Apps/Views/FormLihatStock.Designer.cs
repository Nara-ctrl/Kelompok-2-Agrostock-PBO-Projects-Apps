namespace Kelompok_2___PBO_Projects_Apps
{
    partial class FormLihatStock
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
            btn_keluar = new Button();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_keluar
            // 
            btn_keluar.BackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_keluar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_keluar.FlatStyle = FlatStyle.Flat;
            btn_keluar.Location = new Point(717, 146);
            btn_keluar.Name = "btn_keluar";
            btn_keluar.Size = new Size(107, 29);
            btn_keluar.TabIndex = 0;
            btn_keluar.UseVisualStyleBackColor = false;
            btn_keluar.Click += btn_keluar_Click;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(145, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(679, 223);
            dataGridView1.TabIndex = 1;
            // 
            // FormLihatStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.bg_lihat_stok__admin_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 506);
            ControlBox = false;
            Controls.Add(dataGridView1);
            Controls.Add(btn_keluar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLihatStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lihat Stok (Admin)";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_keluar;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridView1;
    }
}