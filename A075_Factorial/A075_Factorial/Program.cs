using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A075_Factorial
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum = 0;
      for (int i = 1; i <= 10; i++)
      {
        sum += Factorial(i);
        Console.WriteLine("{0,2}! : {1,10:N0}", i, Factorial(i));
      }
      Console.WriteLine("1!~10!의합= {0,8:N0}", sum);
    }

    private static int Factorial(int n)
    {
      int fact = 1;
      for (int i = 1; i <= n; i++)
        fact *= i;
      return fact;
    }
  }
}
