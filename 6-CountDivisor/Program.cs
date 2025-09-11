using System;
namespace _6_CountDivisor
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input = "2 7 3";
      // konversi ke array
      string[] bagian = input.Split(' ');
      // Console.WriteLine(bagian[0]);
      // Console.WriteLine(bagian[1]);
      // Console.WriteLine(bagian[2]);

      // konversi ke integer
      int l = int.Parse(bagian[0]); // nilai awal
      int r = int.Parse(bagian[1]); // nilai akhir
      int k = int.Parse(bagian[2]); // pembagian

      // Buat Variabel total
      int tot = 0;
      // Telusuri setiap angka
      for (int i = l; i < r; i++)
      {
        if (i % k == 0) // jika hasil bagi i dengan k = 0
        {
          Console.Write($"nilai:\t{i}\n"); // cetak nilai yang habis dibagi k
          tot += i; // simpan ke varibel "tot" dan jumlahkan semuanya
        }
      }
      // Cetak jumlah Hasil bagi
      Console.WriteLine($"hasil penjumlahan dari nilai yg sisa pembagiannya = 0 adalah {tot}");


    }
  }
}