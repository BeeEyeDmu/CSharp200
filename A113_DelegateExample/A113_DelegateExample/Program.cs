using System;

namespace A113_DelegateExample
{
  class Program
  {
    delegate bool MemberTest(int a);

    static void Main(string[] args)
    {
      int[] arr = new int[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };

      Console.WriteLine(Count(4));
      Console.WriteLine(Count(arr, 4));
      Console.WriteLine("짝수의 갯수: " + EvenCount(arr));
      Console.WriteLine("홀수의 갯수: " + OddCount(arr));

      Console.WriteLine("짝수의 갯수: " + Count(arr, IsEven));
      Console.WriteLine("홀수의 갯수: " + Count(arr, IsOdd));
    }

    static int EvenCount(int[] a)
    {
      int cnt = 0;
      foreach (var n in a)
      {
        if (n % 2 == 0)
          cnt++;
      }
      return cnt;
    }

    static int OddCount(int[] a)
    {
      int cnt = 0;
      foreach (var n in a)
      {
        if (n % 2 == 1)
          cnt++;
      }
      return cnt;
    }

    static int Count(int[] a, MemberTest testMethod)
    {
      int cnt = 0;
      foreach (var n in a)
      {
        if (testMethod(n) == true)
          cnt++;
      }
      return cnt;
    }

    static public bool IsOdd(int n) { return n % 2 != 0; }
    static public bool IsEven(int n) { return n % 2 == 0; }

    private static int Count(int v)
    {
      var nums = new[] { 3, 5, 4, 2, 6, 4, 6, 8, 54, 23, 4, 6, 4 };
      int cnt = 0;
      foreach (var n in nums)
      {
        if (n == v)
          cnt++;
      }
      return cnt;
    }

    private static int Count(int[] nums, int v)
    {
      int cnt = 0;
      foreach (var n in nums)
      {
        if (n == v)
          cnt++;
      }
      return cnt;
    }
  }
}
