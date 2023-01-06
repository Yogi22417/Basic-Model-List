using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TukangBuku.Model;

public class Beli_Beli
{
    public Beli_Beli(string nama, int stok, int harga, int hargatotal) { 
        this.nama = nama;
        this.stok = stok;
        this.harga = harga;
        this.hargatotal = hargatotal;
    }
    public string nama { get; set; }
    public int stok { get; set; }
    public int harga { get; set; }
    public int hargatotal { get; set; }
}
