using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A091_OptionalNamedArguments
{
  class Program
  {
    static int MyPower(int x, int y = 2)
    {
      int result = 1;
      for (int i = 0; i < y; i++)
        result *= x;
      return result;
    }

    static int Area(int h, int w)
    {
      return h * w;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(MyPower(4, 2));
      Console.WriteLine(MyPower(4));
      Console.WriteLine(MyPower(3, 4));

      Console.WriteLine(Area(w: 5, h: 6));
      Console.WriteLine(Area(h: 6, w: 5));
    }
  }
}
