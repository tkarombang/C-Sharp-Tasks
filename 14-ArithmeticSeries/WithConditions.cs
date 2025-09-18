using System;
class WithConditions
{
  public static void PrintArithmeticSeriesWithConditions(int N)
  {
    if (N <= 0 || N > 100)
    {
      Console.WriteLine("Wring Input");
      return;
    }

    // Mendefinisikan suku awal untuk ketiga deret.
    int series1 = 2;
    int series2 = 5;
    int series3 = 7;

    // Menggunakan list untuk menyimpan deret gabungan.
    List<int> combinedSeries = new List<int>();

    // Loop untuk menghasilkan N angka.
    for (int i = 0; combinedSeries.Count < N; i++)
    {
      // Tambahkan angka pertama dari set ini jika belum mencapai N.
      if (combinedSeries.Count < N)
      {
        combinedSeries.Add(series1);
      }

      // Tambahkan angka kedua dari set ini jika belum mencapai N.
      if (combinedSeries.Count < N)
      {
        combinedSeries.Add(series2);
      }

      // Tambahkan angka ketiga dari set ini jika belum mencapai N.
      if (combinedSeries.Count < N)
      {
        combinedSeries.Add(series3);
      }

      // Tambahkan 1 ke setiap deret untuk iterasi berikutnya.
      series1++;
      series2++;
      series3++;
    }

    // Cetak deret dengan aturan kondisi.
    foreach (int number in combinedSeries)
    {
      if (number % 3 == 0 && number % 5 == 0)
      {
        Console.Write("Boom ");
      }
      else if (number % 3 == 0)
      {
        Console.Write("Tik ");
      }
      else if (number % 5 == 0)
      {
        Console.Write("Tak ");
      }
      else
      {
        Console.Write($"{number} ");
      }
    }
    Console.WriteLine(); // Baris baru untuk output yang rapi.
  }
}

