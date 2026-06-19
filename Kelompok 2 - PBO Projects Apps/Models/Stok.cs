using System;
using System.Collections.Generic;
using System.Text;

namespace Kelompok_2___PBO_Projects_Apps.Models
{
    public class Stok
    {
        public string id_komoditas { get; set; }
        public string nama_komoditas { get; set; }
        public string satuan { get; set; }
        public decimal jumlah { get; set; }

        public Stok(string id_komoditas, string nama_komoditas, string satuan, decimal jumlah)
        {
            this.id_komoditas = id_komoditas;
            this.nama_komoditas = nama_komoditas;
            this.satuan = satuan;
            this.jumlah = jumlah;
        }
    }
}
