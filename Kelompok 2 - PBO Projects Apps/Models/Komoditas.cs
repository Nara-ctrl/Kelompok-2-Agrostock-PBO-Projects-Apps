public class Komoditas
{
    public string id_komoditas { get; set; }
    public string nama_komoditas { get; set; }
    public decimal jumlah { get; set; } // ✅ Tambah ini
    public string satuan { get; set; }

    // Constructor lama (tetap ada agar tidak error di tempat lain)
    public Komoditas(string id, string nama, string satuan)
    {
        id_komoditas = id;
        nama_komoditas = nama;
        jumlah = 0;
        this.satuan = satuan;
    }

    // ✅ Constructor baru dengan jumlah
    public Komoditas(string id, string nama, decimal jumlah, string satuan)
    {
        id_komoditas = id;
        nama_komoditas = nama;
        this.jumlah = jumlah;
        this.satuan = satuan;
    }
}