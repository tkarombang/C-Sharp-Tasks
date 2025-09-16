class MirrorPrime
{

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
      if (IsPrimeNumber.IsPrime(angka))
      {
        int mirrored = MirrorNumber(angka);
        if (IsPrimeNumber.IsPrime(mirrored))
        {
          mirrorPrimes.Add(angka);
        }
      }
      angka++;
    }

    Console.WriteLine($"Mirror Prime Numbers: {mirrorPrimes}");
    foreach (int prime in mirrorPrimes)
    {
      Console.WriteLine(prime);
    }

  }






}