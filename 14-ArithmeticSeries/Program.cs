using System;
namespace _14_ArithmeticSeries
{
  class Program
  {
    public static int HitungArithmeticSeries(int a, int d, int n)
    {
      return (n * (2 * a + (n - 1) * d)) / 2;
    }

    public static void CetakArithmeticSeries(int a, int d, int n)
    {
      for (int i = 0; i < n; i++)
      {
        int term = a + i * d;
        Console.Write(term + " ");
      }
      Console.WriteLine();
    }
    public static void Main(string[] args)
    {
      int a = 2;
      int d = 3;
      int n = 5;

      CetakArithmeticSeries(a, d, n);

      int sum = HitungArithmeticSeries(a, d, n);
      Console.WriteLine("Jumlah dari " + n + " Suku Pertama: " + sum); 

    }
  }

}