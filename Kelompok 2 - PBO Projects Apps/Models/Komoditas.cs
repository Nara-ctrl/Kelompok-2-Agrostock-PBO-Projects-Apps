public class Komoditas
{
    public string id_komoditas { get; set; }
    public string nama_komoditas { get; set; }
    public string satuan { get; set; }

    public Komoditas(string id, string nama, string satuan)
    {
        id_komoditas = id;
        nama_komoditas = nama;
        this.satuan = satuan;
    }

    public Komoditas(string id, string nama,  decimal jumlah, string satuan)
    {
        id_komoditas = id;
        nama_komoditas = nama;
        this.satuan = satuan;
    }
}