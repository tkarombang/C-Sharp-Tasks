using System;
namespace _14_ArithmeticSeries
{
  class Program
  {

    public static void Main(string[] args)
    {
      // int a = 2;
      // int d = 3;
      // int n = 5;

      // HitungCetakAritmet.CetakArithmeticSeries(a, d, n);

      // int sum = HitungCetakAritmet.HitungArithmeticSeries(a, d, n);
      // Console.WriteLine("Jumlah dari " + n + " Suku Pertama: " + sum); 



      // Console.WriteLine(AritMethicSeries.PrintAarithmeticSeries(10));
      // WithConditions.PrintArithmeticSeriesWithConditions(151);

      Console.Write("Masukkan Nilai: ");
      int nIn = 0;
      bool input = int.TryParse(Console.ReadLine(), out nIn);

      // if (nIn <= 0 || nIn >= 100)
      // {
      //   Console.WriteLine("Wrong Input " + nIn);
      // }

      int n1 = 2;
      int n2 = 5;
      int n3 = 7;


      List<int> gabung = new List<int>();
      for (int i = 0; gabung.Count < nIn; i++)
      {
        gabung.Add(n1);
        gabung.Add(n2);
        gabung.Add(n3);

        n1++;
        n2++;
        n3++;
      }


      foreach (int el in gabung)
      {
        if (el % 3 == 0 && el % 5 == 0)
        {
          Console.Write("Boom");
        }
        else if (el % 3 == 0)
        {
          Console.Write("Tik ");
        }
        else if (el % 5 == 0)
        {
          Console.Write("Tak ");
        }
        else
        {
          Console.Write(" -" + el + "- ");
        }

      }
      // Actual: 2 5 7 3 6 8 4 7 9 5 8 10 
      // mod 3 :   3 6 9
      // mod 5 : 5       5 10
      // gab3&5: 5 3 6 9 5 10

      // Expect: 2 5 7 3 6 8 4 7 9 5 8 10




    }
  }


}