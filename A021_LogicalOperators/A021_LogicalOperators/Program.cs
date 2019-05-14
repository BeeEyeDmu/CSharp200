using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A021_LogicalOperators
{
  class Program
  {
    static void Main(string[] args)
    {
      bool result;
      int first = 10, second = 20;

      result = (first == second) || (first > 5);
      Console.WriteLine("{0} || {1} : {2}", first == second, first > 5, result);

      result = (first == second) && (first > 5);
      Console.WriteLine("{0} && {1} : {2}", first == second, first > 5, result);

      result = true ^ false;
      Console.WriteLine("{0} ^ {1} : {2}", true, false, result);

      result = !(first > second);
      Console.WriteLine("!{0} : {1}", first > second, result);

      int year = 2018;
      bool isLeapYear = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
      Console.WriteLine("{0}년은 윤년이다 : {1}", year, isLeapYear);
    }
  }
}
