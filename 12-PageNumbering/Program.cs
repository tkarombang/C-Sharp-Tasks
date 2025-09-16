using System;
namespace _12_PageNumbering
{
  class Program
  {
    public static int GetPageCount(int n)
    {
      int pageCount = 0;  // Menyimpan jumlah halaman
      int totalDigits = 0;  // Menyimpan total digit yang digunakan
      int page = 1;  // Nomor halaman

      // Mulai menghitung digit untuk setiap halaman
      while (totalDigits + page.ToString().Length <= n)
      {
        totalDigits += page.ToString().Length;  // Tambah digit halaman
        pageCount++;  // Tambah halaman
        page++;  // Ke halaman berikutnya
      }

      // Cek apakah total digit cocok dengan input n
      if (totalDigits == n)
      {
        return pageCount;  // Kembalikan jumlah halaman
      }

      return 0;  // Jika tidak cocok, berarti tidak ada solusi
    }


    public static void Main(string[] args)
    {

      Console.Write("Masukkan Angka: ");

      string input = Console.ReadLine()!;

      // Validasi input
      if (int.TryParse(input, out int n) && n > 0)
      {
        int result = GetPageCount(n);
        Console.WriteLine(result);  // Output
      }
      else
      {
        Console.WriteLine("Wrong Input");  // Input tidak valid
      }


    }
  }
}