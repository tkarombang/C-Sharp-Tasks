using System;
using System.Linq;
namespace _11_MirrorPrimeNumbers
{
  class Program
  {
    public static bool IsPrime(int n)
    {
      if (n < 2) return false;

      for (int i = 2; i <= Math.Sqrt(n); i++)
      {
        if (n % i == 0) return false;
      }

      return true;
    }

    public static int ReverseNumber(int n)
    {
      int reversed = 0;
      while (n != 0)
      {
        int digit = n % 10;
        reversed = reversed * 10 + digit;
        n /= 10;
      }
      return reversed;
    }

    public static void Main(string[] args)
    {
      // int angka = 4;
      // bool isPrime = IsPrime(angka);
      // if(isPrime == true)
      // {
      //   Console.WriteLine("Bilangan Prima");
      // }
      // else
      // {
      //   Console.WriteLine("BUKAN Bilangan Prima");
      // }


      // CetakPrime(3);
      // MirrorPrime.CetakMirrorNumber(20);
      // Console.WriteLine(MirrorNumber(312));




      Console.Write("Masukkan angka (10 ≤ a ≤ 100): ");
      string input = Console.ReadLine();

      if (int.TryParse(input, out int a) && a >= 10 && a <= 100)
      {
        if (IsPrime(a))
        {
          int reversed = ReverseNumber(a);
          if (IsPrime(reversed))
          {
            Console.WriteLine("Mirror Primes");
          }
          else
          {
            Console.WriteLine("Regular Number");
          }
        }
        else
        {
          Console.WriteLine("Regular Number");
        }
      }
      else
      {
        Console.WriteLine("Wrong Input");
      }



    }
  }
}