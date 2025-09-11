using System;
namespace CharacterDistance
{
  class Program
  {
    static bool IsValidInput(string input)
    {
      bool isDigit = true;
      bool isAlpha = true;
      foreach (char c in input)
      {
        if (!Char.IsDigit(c))
        {
          isDigit = false;
        }
        if (!Char.IsLetter(c))
        {
          isAlpha = false;
        }
      }
      return isDigit || isAlpha;
    }
    public static void Main(string[] args)
    {
      Console.Write("Masukkan Kalimat Ke-1: ");
      string? kata_pertama = Console.ReadLine();
      Console.Write("Masukkan Kalimat Ke-2: ");
      string? kata_kedua = Console.ReadLine();

      
      if (kata_pertama?.Length != kata_kedua?.Length)
      {
        Console.WriteLine("Different Length");
        return;
      }
      

      if (!IsValidInput(kata_pertama!) || !IsValidInput(kata_kedua!))
      {
        Console.WriteLine("Wrong Input");
        return;
      }


      int jumlahBeda = 0;
      char[] result = kata_pertama!.ToCharArray();
      for (int i = 0; i < kata_pertama?.Length; i++)
      {
        if (kata_pertama[i] != kata_kedua?[i])
        {
          result[i] = '*';
          jumlahBeda++;
        }
      }

      kata_pertama = new string(result);
      kata_kedua = new string(result);

      Console.WriteLine($"{kata_pertama}");
      Console.WriteLine($"{kata_kedua}");
      Console.WriteLine($"{jumlahBeda}");


    }
  }
}
