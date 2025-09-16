using System;
namespace _14_ArithmeticSeries
{
  class AritMethicSeries
  {
    public static void PrintAarithmeticSeries(int n)
    {
      if (n <= 0 || n > 100)
      {
        Console.WriteLine("Wring Input");
        return;
      }


      string[] result = new string[n];
      int current = 2;

      for (int i = 0; i < n; i++)
      {
        if (current % 3 == 0 && current % 5 == 0)
        {
          result[i] = "Boom";
        }
      }

      Console.WriteLine(string.Join(" ", result));


    }
  }
}