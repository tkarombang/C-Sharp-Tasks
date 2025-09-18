using System;
namespace _15_NumberOnly
{
  class FibProc
  {
    public static void FibProses(int n, int x)
    {
      if (n <= 0 || n >= 100 || x <= 0 || x >= 100)
      {
        Console.WriteLine("Wrong Input");
        return;
      }
      List<long> fibonacciSeries = new List<long>();

      long a = 1;
      long b = 2;

      if (n >= 1) fibonacciSeries.Add(a);
      if (n >= 2) fibonacciSeries.Add(b);

      for (int i = 2; i < n; i++)
      {
        long next = a + b;
        fibonacciSeries.Add(next);
        a = b;
        b = next;
      }


      for (int i = 0; i < fibonacciSeries.Count; i++)
      {
        long number = fibonacciSeries[i];

        // Aturan kondisional
        if (x != 0 && number % x == 0)
        {
          Console.Write("*");
        }
        else
        {
          Console.Write(number);
        }

        // Tambahkan spasi kecuali untuk angka terakhir
        if (i < fibonacciSeries.Count - 1)
        {
          Console.Write(" ");
        }
      }

    }
  }
}