using System;
using System.Text;
namespace _5_Compounding
{
  class Program
  {

    public static string Compound(string str)
    {
      StringBuilder result = new StringBuilder();

      for (int i = 0; i < str.Length; i++)
      {
        if (i > 0)
        {
          result.Append("-");
        }
        result.Append(char.ToUpper(str[i]));

        for (int j = 1; j <= i; j++)
        {
          result.Append(char.ToLower(str[i]));
        }
      }

      return result.ToString();
      
    }





    public static void Main(string[] args)
    {
      string str = "abcde";
      Console.WriteLine($"input: {str}");
      Console.WriteLine($"output: {Compound(str)}");


      // double nilaiPokok = 2500999; //P = Principal (nilai pokok awal / modal)
      // double rateBunga = 5; //r = Tingkat Bunga tahunan (misal, 5%)
      // double time = 2; // Periode tahunan (misal, 2 Tahun)

      // // Hitung setelah Bunga Majemuk
      // double tingkatBunga = 1 + rateBunga / 100; // 1 + (r/n) = Frekuensi penggabungan dalam periode tahunan (misal 1,05)

      // // Jumlah Bunga per periode/tahun
      // double eksponen = Math.Pow(tingkatBunga, time); //t = Jumlah Tahun (misal 1,05^2 = 1,1025)

      // double nilaiAkhir = tingkatBunga * eksponen; //FV (Future Value / Nilia Akhir yang dicari)

      // Console.WriteLine(tingkatBunga); //1,05
      // Console.WriteLine(eksponen); // 1,1025

      // Console.WriteLine("-----");

      // Console.WriteLine($"Pokok {nilaiPokok}"); // 2500999
      // Console.WriteLine($"Rate {rateBunga}%"); // 5%
      // Console.WriteLine($"Waktu {time} Tahun"); // 2th
      // Console.WriteLine($"Jumlah Total (si-A) {nilaiAkhir}"); // 1,05 x 1,1025 = 1,157625
      // Console.WriteLine($"Bunga Majemuk (CI) {nilaiPokok - nilaiAkhir}"); // 2500999 - 1,157625






      // Problem: Compounding

    }
  }
}