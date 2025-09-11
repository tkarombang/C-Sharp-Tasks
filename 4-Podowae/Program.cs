using System;
using System.Linq;
namespace _4_Podowae
{
  class Program
  {
    public static void Main(string[] args)
    {
      string input = "Step on no pets";
      // METODE MANUAL
      // string str = "";

      // HAPUS SPASI
      // for (int i = 0; i < input.Length; i++)
      // {
      //   if (!char.IsWhiteSpace(input[i]))
      //   {
      //     str += input[i];
      //   }
      // }

      // string rev = new string(str.ToLower().Reverse().ToArray());

      // CEK APAKAH PODOWAE

      // if (rev == str.ToLower())
      // {
      //   Console.WriteLine("YES");
      // }
      // else
      // {
      //   Console.WriteLine("NO");

      // }

      // Console.WriteLine(str);
      // Console.WriteLine(rev);



      // METODE SINGKAT
      string hapusSpasi = new string(input.Where(p => !char.IsWhiteSpace(p)).ToArray()).ToLower();

      string revs = new string(hapusSpasi.Reverse().ToArray());

      if (hapusSpasi == revs)
      {
        Console.WriteLine("YES");
      }
      else
      {
        Console.WriteLine("NO");
      }




    }
  }
}