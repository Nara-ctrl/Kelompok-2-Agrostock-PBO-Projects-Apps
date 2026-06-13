namespace Kelompok_2___PBO_Projects_Apps.Views
{
    partial class FormKelolaData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaData));
            btn_transaksi = new Button();
            SuspendLayout();
            // 
            // btn_transaksi
            // 
            btn_transaksi.BackColor = Color.Transparent;
            btn_transaksi.Cursor = Cursors.Hand;
            btn_transaksi.FlatAppearance.BorderSize = 0;
            btn_transaksi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_transaksi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_transaksi.FlatStyle = FlatStyle.Flat;
            btn_transaksi.Location = new Point(336, 202);
            btn_transaksi.Name = "btn_transaksi";
            btn_transaksi.Size = new Size(124, 102);
            btn_transaksi.TabIndex = 5;
            btn_transaksi.UseVisualStyleBackColor = false;
            btn_transaksi.Click += btn_transaksi_Click;
            // 
            // FormKelolaData
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(978, 506);
            Controls.Add(btn_transaksi);
            Name = "FormKelolaData";
            Text = "FormKelolaData";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_transaksi;
    }
}