using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A047_Power
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("x의 y승을 계산합니다.");
      Console.Write(" x를 입력하세요: ");
      int x = int.Parse(Console.ReadLine());
      Console.Write(" y를 입력하세요: ");
      int y = int.Parse(Console.ReadLine());

      int pow = 1;

      for (int i = 0; i < y; i++)
        pow *= x;

      Console.WriteLine("{0}의 {1}승은 {2}입니다", x, y, pow);
    }
  }
}
