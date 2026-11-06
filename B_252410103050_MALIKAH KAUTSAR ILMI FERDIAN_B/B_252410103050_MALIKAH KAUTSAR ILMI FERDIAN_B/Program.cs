using System;
class Agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public void TampilInfo()
    {
        Console.WriteLine("ID: " + idAgen + ", Nama: " + namaAgen + ", Stok: " +stokAgen);
    }
}

abstract class ProdukGalon
{
    private string idProduk { get; set; }
    private string namaProduk { get; set; }
    private int stokGudang { get; set; }

    public void KurangiStok()
    {
        
        Console.WriteLine("");
    }

    public virtual int HitungBiaya(int jumlah)
    {
        return 0;
    }
}

class GalonAkua : ProdukGalon
{
    public int jumlah;


    public override int HitungBiaya(int jumlah)
    {
        return jumlah * 20000;
    }
}

class GalonBerkeran : ProdukGalon
{
    public int jumlah;
    public string jenisKeran;

    public override int HitungBiaya(int jumlah)
    {
        return jumlah * 12000;
    }

}

class DistribusiGalon
{
    public Agen agen;
    public ProdukGalon galon;
    public int jumlah;
}

interface DapatDidistribusikan
{
    void KirimPaket()
    {
        
    }
}

class Program
{
    static void Main()
    {
        Agen agen1 = new Agen();
        agen1.idAgen = "AAA";
        agen1.namaAgen = "Alamalama";
        agen1.stokAgen = 12;
        agen1.TampilInfo();

        Agen agen2 = new Agen();
        agen2.idAgen = "BBB";
        agen2.namaAgen = "Babamarica";
        agen2.stokAgen = 23;
        agen2.TampilInfo();

        ProdukGalon produk;
        produk = new GalonAkua();
        Console.WriteLine("Biaya galon akua (2): " + produk.HitungBiaya(2));

        produk = new GalonBerkeran();
        Console.WriteLine("Biaya galon keran (5): " + produk.HitungBiaya(5));
    }
}