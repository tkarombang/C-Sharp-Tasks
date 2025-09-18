using System;
namespace _15_NumberOnly
{
  class Program
  {
    // public static bool IsNUmberOnly(string str)
    public static int IsNUmberOnly(string str)
    {
      int totalSum = 0;
      string currentNumber = "";

      // Iterasi setiap karakter dalam string input
      foreach (char c in str)
      {
        // Jika karakter adalah digit, tambahkan ke string "currentNumber"
        if (char.IsDigit(c))
        {
          currentNumber += c;
        }
        // Jika karakter bukan digit, kita telah mencapai akhir dari sebuah angka
        else
        {
          // Jika "currentNumber" tidak kosong, itu berarti kita telah mengumpulkan digit
          if (!string.IsNullOrEmpty(currentNumber))
          {
            // Ubah string digit menjadi integer dan tambahkan ke total
            if (int.TryParse(currentNumber, out int number))
            {
              totalSum += number;
            }
          }
          // Reset string "currentNumber" untuk angka berikutnya
          currentNumber = "";
        }
      }



      // Tambahkan angka terakhir setelah perulangan selesai (jika input diakhiri dengan digit)
      if (!string.IsNullOrEmpty(currentNumber))
      {
        if (int.TryParse(currentNumber, out int number))
        {
          totalSum += number;
        }
      }

      return totalSum;

    }
    public static void Main(string[] args)
    {
      Console.Write("masukkan nilai: ");
      string input = Console.ReadLine()!;



      Console.WriteLine(IsNUmberOnly(input));
      // Console.WriteLine(IsNUmberOnly("12345"));
      // Console.WriteLine(IsNUmberOnly("12a45"));
      // Console.WriteLine(IsNUmberOnly("abcdase"));



      // IsNUmberOnly.FibProses(100, 2);







    }
  }
}