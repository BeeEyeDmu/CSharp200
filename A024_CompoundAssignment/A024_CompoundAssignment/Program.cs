using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A024_CompoundAssignment
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 32;

      Console.WriteLine(x += 2);
      Console.WriteLine(x -= 8);
      Console.WriteLine(x *= 3);
      Console.WriteLine(x /= 2);
      Console.WriteLine(x++);
      Console.WriteLine(--x);
    }
  }
}
