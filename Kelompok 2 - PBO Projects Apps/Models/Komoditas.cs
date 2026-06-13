using System;
using System.Collections.Generic;
using System.Text;

namespace Kelompok_2___PBO_Projects_Apps.Models
{
    public class Komoditas
    {
        public string id_komoditas { get; set; }
        public string nama_komoditas { get; set; }
        public string satuan { get; set; }

        public Komoditas(string id_komoditas, string nama_komoditas, string satuan)
        {
            this.id_komoditas = id_komoditas;
            this.nama_komoditas = nama_komoditas;
            this.satuan = satuan;
        }
    }
}