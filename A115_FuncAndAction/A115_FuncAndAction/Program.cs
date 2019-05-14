using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A115_FuncAndAction
{
  class Program
  {
    static void Main(string[] args)
    {
      var arr = new[] { 3, 34, 6, 34, 7, 8, 24, 3, 675, 8, 23 };

      int n = Count(arr, delegate (int x) { return x % 2 == 0; });
      Console.WriteLine("짝수의 갯수 : " + n);

      n = Count(arr, delegate (int x) { return x % 2 != 0; });
      Console.WriteLine("홀수의 갯수 : " + n);
    }

    private static int Count(int[] arr, Func<int, bool> testMethod)
    {
      int cnt = 0;
      foreach (var n in arr)
      {
        if (testMethod(n))
          cnt++;
      }
      return cnt;
    }
  }
}
