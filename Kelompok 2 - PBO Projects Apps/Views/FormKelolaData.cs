using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kelompok_2___PBO_Projects_Apps.Views
{
    public partial class FormKelolaData : Form
    {
        public FormKelolaData()
        {
            InitializeComponent();
        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi transaksi = new FormTransaksi();
            transaksi.ShowDialog();
        }
    }
}
