using System;
namespace _8_Fruits_oop
{
  class Program
  {
    public static void Main(string[] args)
    {
      Fruits Apel = new Fruits("Apel", "Merah");
      Apel.Matang();

    }
  }

  class Fruits(string nama, string warna)
  {
    private string Nama = nama;
    private string Warna = warna;

    public void Matang()
    {
      Console.WriteLine($"Buah {Nama} warnanya {Warna} menandakan sudah Matang");
    }

  }
}