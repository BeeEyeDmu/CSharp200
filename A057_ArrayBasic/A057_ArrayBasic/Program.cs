using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A057_ArrayBasic
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] a = { 1, 2, 3 };		// 배열의 초기화
      Console.Write("a[]: ");
      foreach (var value in a)
        Console.Write(value + " ");

      int[] b = new int[] { 1, 2, 3 };
      Console.Write("\nb[]: ");
      for (int i = 0; i < 3; i++)
        Console.Write(b[i] + " ");

      int[] c = new int[3] { 1, 2, 3 };
      Console.Write("\nc[]: ");
      for (int i = 0; i < b.Length; i++)
        Console.Write(b[i] + " ");

      int[] d = new int[3];
      d[0] = 1;
      d[1] = d[0] + 1;
      d[2] = d[1] + 1;
      Console.Write("\nd[]: ");
      foreach (int value in d)
        Console.Write(value + " ");
      Console.WriteLine();
    }
  }
}
