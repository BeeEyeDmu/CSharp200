using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A061_RandomClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();

      Console.WriteLine("Random Bytes");
      Byte[] b = new byte[5];
      r.NextBytes(b);                // 한번 호출로 배열을 랜덤값으로 채움

      foreach (var x in b)
        Console.Write("{0,12}", x); // 12자리로 출력
      Console.WriteLine();

      Console.WriteLine("Random Double");
      double[] d = new double[5];

      for (int i = 0; i < 5; i++)    // 5개 double 랜덤값 생성 저장
        d[i] = r.NextDouble();

      foreach (var x in d)
        Console.Write("{0,12:F8}", x); // 12자리, 소수점 아래 8자리로 출력
      Console.WriteLine();

      Console.WriteLine("Random Int32");
      int[] a = new int[5];

      for (int i = 0; i < 5; i++)    // 5개 int 랜덤값 생성 저장
        a[i] = r.Next();
      PrintArray(a);

      Console.WriteLine("Random Int32(0~99)");
      int[] v = new int[5];

      for (int i = 0; i < 5; i++)    // 5개 0~99의 랜덤값 생성 저장
        v[i] = r.Next(100);
      PrintArray(v);
    }

    private static void PrintArray(int[] v)
    {
      foreach (var value in v)
        Console.Write("{0,12}", value);
      Console.WriteLine();
    }
  }
}
