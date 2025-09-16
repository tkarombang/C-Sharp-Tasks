using System;
namespace _12_PageNumbering
{
  class Program
  {
    public static int GetPageCount(int totalItems, int pageSize)
    {
      return (int)Math.Ceiling((double)totalItems / pageSize);
    }
    public static void Main(string[] args)
    {
      Console.WriteLine(GetPageCount(25, 10));
      Console.WriteLine(GetPageCount(100, 20));

      
    }
  }
}