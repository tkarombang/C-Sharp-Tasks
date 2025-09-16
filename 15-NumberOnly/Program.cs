using System;
namespace _15_NumberOnly
{
  class Program
  {
    // public static bool IsNUmberOnly(string str)
    public static string IsNUmberOnly(string str)
    {
      var angka = str.Where(c => char.IsDigit(c));
      return new string(angka.ToArray());
      // return str.All(c => char.IsDigit(c));
    }
    public static void Main(string[] args)
    {
      Console.WriteLine(IsNUmberOnly("12345"));
      Console.WriteLine(IsNUmberOnly("12a45"));
      Console.WriteLine(IsNUmberOnly("abcdase"));

    }
  }
}