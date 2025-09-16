using System;
namespace _16_MultipleThreeAndSeven
{
  class Program
  {
    public static int HitungMultiplesOf3and7(int n)
    {
      int sum = 0;

      for (int i = 1; i <= n; i++)
      {
        if (i % 3 == 0 || i % 7 == 0)
          sum += i;
      }

      return sum;
    }
    public static void Main(string[] args)
    {
      Console.Write("Masukkan Angka: ");
      string input = Console.ReadLine();
      //DO YOUR CODE HERE

      if (int.TryParse(input, out int x_input) && x_input > 0)
      {
        // Menampilkan hasil jumlah kelipatan 3 atau 7
        int result = HitungMultiplesOf3and7(x_input);
        Console.WriteLine("Jumlah kelipatan 3 atau 7 antara 1 hingga " + x_input + " adalah: " + result);
        HitungMultiplesOf3and7(x_input);
      }

    }
  }
}