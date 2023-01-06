using TukangBuku.Model;

namespace TukangBuku;

class Program
{
    static List<Beli_Beli> beli = new List<Beli_Beli>();
    public static void Main(string[] args)
    {
        menu();
    }

    public static void menu()
    {
        Console.WriteLine("1. Input");
        Console.WriteLine("2. Output");
        Console.Write("Masukkan Nomor Menu");
        int pilih = Convert.ToInt32(Console.ReadLine());
        if (pilih == 1)
        {
            input();
            menu();
        } else if(pilih == 2){
            output();
            menu();
        }
    }

    public static void input()
    {
        Console.Write("Nama Alat Tulis : ");
        string nama = Console.ReadLine();
        Console.Write("Stok : ");
        int stok = Convert.ToInt32(Console.ReadLine());
        Console.Write("Harga Satuan : ");
        int harga = Convert.ToInt32(Console.ReadLine());
        int hargatotal = stok * harga;

        beli.Add(new Beli_Beli(nama,stok,harga,hargatotal));
    }

    public static void output()
    {
        int totalsemua = 0;
        foreach (var semua in beli)
        {
            Console.WriteLine("Nama Alat Tulis : " + semua.nama);
            Console.WriteLine("Stok : " + semua.stok);
            Console.WriteLine("Harga Satuan : " + semua.harga);
            Console.WriteLine("Harga Total : " + semua.hargatotal);
        }

        foreach (var semuah in beli)
        {
            totalsemua += semuah.hargatotal;
        }
        Console.WriteLine("Total Harga Anda = "+totalsemua);
    }
}