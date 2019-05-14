using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A062_ArrayAndRandom
{
  class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();

      Console.WriteLine("Random Int32(0~99)");
      int[] v = new int[15];

      for (int i = 0; i < v.Length; i++)  // 5개 0~99의 랜덤값 저장
        v[i] = r.Next(100);
      PrintArray(v);

      // (1) 최대값
      int max = v[0];
      for (int i = 1; i < v.Length; i++)
        if (v[i] > max)
          max = v[i];
      Console.WriteLine("최대값: {0}", max);

      // (2) 최소값
      int min = v[0];
      for (int i = 1; i < v.Length; i++)
        if (v[i] < min)
          min = v[i];
      Console.WriteLine("최소값: {0}", min);

      // (3) 합계와 평균
      int sum = 0;
      for (int i = 0; i < v.Length; i++)
        sum += v[i];
      Console.WriteLine("합계: {0}\n평균: {1:F2}", sum,
         (double)sum / v.Length);
    }

    private static void PrintArray(int[] v)
    {
      for (int i = 0; i < v.Length; i++)
        Console.Write("{0,5}{1}", v[i], (i % 5 == 4) ? "\n" : "");
    }
  }
}
