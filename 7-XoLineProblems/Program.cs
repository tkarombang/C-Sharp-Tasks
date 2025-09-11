using System;
namespace _7_XoLineProblems
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Masukkan Integer 1-40 :");

      string? input = Console.ReadLine();
      // bool inputNilai = int.TryParse(Console.ReadLine(), out nil);
      if (input == null)
      {
        Console.WriteLine("gagal");
      }
      else
      {
        int nil = int.Parse(input);

        string hasil = "";

        if (nil < 1 || nil > 40)
        {
          Console.WriteLine("Wrong Input");
        }
        else
        {
          for (int i = 0; i < nil; i++)
          {
            if (i % 2 == 0)
            {
              hasil += "X";
            }
            else
            {
              hasil += "O";
            }
          }
        }


        Console.WriteLine(hasil);

      }
    }
  }
}