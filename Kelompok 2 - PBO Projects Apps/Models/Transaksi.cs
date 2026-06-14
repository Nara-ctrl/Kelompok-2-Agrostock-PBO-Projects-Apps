using System;
using System.Collections.Generic;
using System.Text;


namespace Kelompok_2___PBO_Projects_Apps.Models
{
    public abstract class Transaksi
    {
        private string _idKomoditas;
        private decimal _jumlah;
        private string _satuan;
        private DateTime _tanggal;

        public string IdKomoditas
        {
            get { return _idKomoditas; }
            set { _idKomoditas = value; }
        }

        public decimal Jumlah
        {
            get { return _jumlah; }
            set { _jumlah = value; }
        }

        public string Satuan
        {
            get { return _satuan; }
            set { _satuan = value; }
        }

        public DateTime Tanggal
        {
            get { return _tanggal; }
            set { _tanggal = value; }
        }

        public Transaksi(string idKomoditas, decimal jumlah, string satuan)
        {
            _idKomoditas = idKomoditas;
            _jumlah = jumlah;
            _satuan = satuan;
            _tanggal = DateTime.Now;
        }

        public abstract string GetJenis();
    }

    public class StokMasuk : Transaksi
    {
        private int _idPetani;

        public int IdPetani
        {
            get { return _idPetani; }
            set { _idPetani = value; }
        }

        public StokMasuk(string idKomoditas, int idPetani, decimal jumlah, string satuan)
            : base(idKomoditas, jumlah, satuan)
        {
            _idPetani = idPetani;
        }

        public override string GetJenis()
        {
            return "masuk";
        }
    }

    public class StokKeluar : Transaksi
    {
        public StokKeluar(string idKomoditas, decimal jumlah, string satuan)
            : base(idKomoditas, jumlah, satuan)
        {
        }

        public override string GetJenis()
        {
            return "keluar";
        }
    }
}