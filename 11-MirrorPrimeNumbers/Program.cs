using System;
using System.Linq;
namespace _11_MirrorPrimeNumbers
{
  class Program
  {
    public static bool IsPrime(int n)
    {
      if (n < 2)
      {
        // Console.WriteLine("Not Prime");
        return false;
      }
      else
      {
        for (int i = 2; i < n; i++)
        {
          if (n % i == 0)
          {
            return false;
            // Console.WriteLine($"{n}/{i} = bUKAN Prime");
          }
        }
        // Console.WriteLine($"{n} = Prime");
        return true;
      }

    }

    public static void CetakPrime(int line)
    {
      List<int> bil = new List<int>();
      int angka = 2;
      while (bil.Count <= line)
      {
        if (IsPrime(angka))
        {
          bil.Add(angka);
        }
        angka++;
      }

      Console.WriteLine(string.Join(", ", bil));
      // for(int i = 1; i < bil.Count; i++)
      // {
      //   Console.WriteLine(bil[i]);
      // }
    }

    public static int MirrorNumber(int n)
    {
      int mirror = 0;
      while (n > 0)
      {
        int digit = n % 10;
        mirror = mirror * 10 + digit;
        n /= 10;
      }
      return mirror;
    }

    public static void CetakMirrorNumber(int line)
    {
      List<int> mirrorPrimes = new List<int>();
      int angka = 2;

      while (mirrorPrimes.Count < line)
      {
        if (IsPrime(angka))
        {
          int mirrored = MirrorNumber(angka);
          if (IsPrime(mirrored))
          {
            mirrorPrimes.Add(angka);
          }
        }
        angka++;
      }

      Console.WriteLine($"Mirror Prime Numbers: {mirrorPrimes}");
      foreach(int prime in mirrorPrimes)
      {
        Console.WriteLine(prime);
      }

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
      // CetakMirrorNumber(10);
      Console.WriteLine(MirrorNumber(312));


    }

  }
}