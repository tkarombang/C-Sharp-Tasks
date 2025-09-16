using System;
namespace _13_StarFibo
{
  class Program
  {
    public static string FiboStar(int n)
    {
      int n1 = 1;
      int n2 = 2;
      int next = 0;

      if (n == 0)
      {
        return "*";
      }
      else if (n == 1)
      {
        return "**";
      }


      for (int i = 0; i < n; i++)
      {
        next = n1 + n2;
        n1 = n2;
        n2 = next;
      }

      return new string('*', n1);
    }
    


    public static void Main(string[] args)
    {
      // Console.WriteLine(FiboStar(5));
      for(int i = 0; i < 10; i++)
      {
        Console.WriteLine(FiboStar(i));
      }

      
    }
  }
}