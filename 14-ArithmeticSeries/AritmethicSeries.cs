using System;
namespace _14_ArithmeticSeries
{
  public class AritMethicSeries
  {
    public static string PrintAarithmeticSeries(int n)
    {
      if (n <= 0 || n > 100)
      {
        Console.WriteLine("Wring Input");
      }


      int totalSets = (int)Math.Ceiling((double)n / 3);
      int n1 = 2;
      int n2 = 3;
      int n3 = 7;

      List<int> gabung = new List<int>();

      for(int i = 0; totalSets < n; i++)
      {
        if(gabung.Count < n)
          gabung.Add(n1);
        if(gabung.Count < n)
          gabung.Add(n2);
        if(gabung.Count < n)
          gabung.Add(n3);

        n1++;
        n2++;
        n3++;
      }



      // Pemrosesan output sesuai aturan
      List<string> result = new List<string>();
      foreach (var ser in gabung)
      {
        if (ser % 3 == 0 && ser % 5 == 0)
        {
          result.Add("Boom");
        }
        else if (ser % 3 == 0)
        {
          result.Add("Tik");
        }
        else if (ser % 5 == 0)
        {
          result.Add("Tak");
        }
        else
        {
          result.Add(ser.ToString());
        }

        // Console.Write(ser);
        // Console.WriteLine(series[i]);
      }
      return string.Join(" ", result);


      // Console.WriteLine(string.Join(" ", result));   
      // Console.WriteLine(string.Join(" ", result));
    }
  }
}