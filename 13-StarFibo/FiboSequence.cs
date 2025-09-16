using System;
namespace _13_StarFibo
{
  class FiboSequence
  {
    public static string FibSeq(int n)
    {
      int n1 = 1;
      int n2 = 2;
      int next = 0;

      if (n == 0)
      {
        return "*";
      }
      else if (n == 1)
      {
        return "**";
      }


      for (int i = 0; i < n; i++)
      {
        next = n1 + n2;
        n1 = n2;
        n2 = next;
      }

      return new string('*', n1);
    }
  }
}