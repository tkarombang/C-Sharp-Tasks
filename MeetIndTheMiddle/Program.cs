using System;
namespace MeetIndTheMiddle
{
  class Program
  {
    public static void Main(string[] args)
    {
      string kata = "belajar";
      int kata_tengah = kata.Length / 2;


      string col1 = kata.Substring(0, kata_tengah);
      string col2 = new string(kata.Substring(kata_tengah).Reverse().ToArray());

      // Console.WriteLine(col1);
      // Console.WriteLine(col2);
      for (int i = 0; i < kata_tengah; i++)
      {
        Console.WriteLine($"{col1[i]}{col2[i]}");
      }



    //   string input = Console.ReadLine();
    //   int tengah = input.Length / 2;
    //   //DO YOUR CODE HERE
    //   string col1 = input.Substring(0, tengah).ToLower();
    //   string col2 = new string(input.Substring(tengah).ToCharArray().Reverse().ToArray()).ToLower();

    //   // 		Console.WriteLine(col1);
    //   // 		Console.WriteLine(col2);

    //   for (int i = 0; i < tengah; i++)
    //   {
    //     Console.WriteLine($"{col1[i]}{col2[i]}");
    //   }

    }
  }
}