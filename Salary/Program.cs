using System;
using System.Xml;

namespace Salary
{
  class Program
  {
    public static void Main(string[] args)
    {
      int gajiPokok = 6000000;
      int bonus = 0;
      int jamKerja;


      Console.Write("Masukkan Jam Kerja: ");
      string inpJamKerja = int.TryParse(Console.ReadLine(), out jamKerja).ToString();



      if (jamKerja < 7)
      {
        bonus = (int)(gajiPokok * -0.05);
      }
      else if (jamKerja > 7 && jamKerja <= 8)
      {
        bonus = (int)(gajiPokok * 0.02);
      }
      else if (jamKerja > 8 && jamKerja <= 9)
      {
        bonus = 250000;
      }

      int totalGaji = gajiPokok + bonus;
      Console.WriteLine($"Gaji Anda: Rp.{totalGaji}");



    }
  }  
}

