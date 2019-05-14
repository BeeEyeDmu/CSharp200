using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A045_MultiplicationTable
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("구구단의 출력할 단수를 입력하세요 : ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= 9; i++)
      {
        Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
      }
    }
  }
}
