using System;
using System.Linq;
using System.Collections.Generic;
namespace _13_StarFibo
{
  class FiboStar
  {
    public static void CetakFiboStar(int length, int divisor)
    {
      if(length <= 0 || length > 100 || divisor <= 0 )
      {
        Console.WriteLine("Wrong Input");
        return;
      }
      int n1 = 1;
      int n2 = 2;
      List<int> FiboList = new List<int>();
      for (int i = 1; i <= length; i++)
      {
        if (i == 1)
        {
          FiboList.Add(n1);
        }
        else if (i == 2)
        {
          FiboList.Add(n2);
        }
        else
        {
          int next = n1 + n2;
          FiboList.Add(next);
          n1 = n2;
          n2 = next;
        }
      }




      var result = FiboList.Select(num => num % divisor == 0 ? "*" : num.ToString()).ToList();

      foreach (var item in result)
      {
        Console.Write($" {item} ");
      }
    }

  }

}
