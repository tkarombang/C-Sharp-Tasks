public class IsPrimeNumber
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

}