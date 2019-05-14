using System;

namespace A063_BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();
      int[] v = new int[30];

      for (int i = 0; i < 30; i++)
        v[i] = r.Next(1000);
      PrintArray("정렬 전", v);

      // (1) 정렬
      Array.Sort(v);
      PrintArray("정렬 후", v);

      Console.Write("=> 검색할 숫자를 입력하세요: ");
      int key = int.Parse(Console.ReadLine());
      int count = 0;  // 비교횟수  

      // (2) 선형탐색
      for (int i = 0; i < v.Length - 1; i++)
      {
        count++;
        if (v[i] == key)
        {
          Console.WriteLine("v[{0}] = {1}", i, key);
          Console.WriteLine("선형탐색의 비교횟수는 {0}회 입니다.", count);
          break;
        }
      }

      // (3) 이진탐색      
      count = 0;
      int low = 0;
      int high = v.Length - 1;
      while (low <= high)
      {
        count++;
        int mid = (low + high) / 2;        
        if (key == v[mid])
        {
          Console.WriteLine("v[{0}] = {1}", mid, key);
          Console.WriteLine("이진탐색의 비교횟수는 {0}회 입니다.", count);
          break;
        }
        else if (key > v[mid])
          low = mid + 1;
        else
          high = mid - 1;
      }      
    }

    private static void PrintArray(string s, int[] v)
    {
      Console.WriteLine(s);
      for (int i = 0; i < v.Length; i++)
        Console.Write("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
    }
  }
}
