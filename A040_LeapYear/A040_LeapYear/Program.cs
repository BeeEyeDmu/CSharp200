using System;

namespace A040_LeapYear
{
  class Program
  {
    static void Main(string[] args)
    {
      int year = int.Parse(Console.ReadLine());

      //for (int year = 100; year <= 4000; year += 100)
      //{
      if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        Console.WriteLine("{0}년은 윤년", year);
      else
        Console.WriteLine("{0}년은 평년", year);

      if (DateTime.IsLeapYear(year))
        Console.WriteLine("{0}년은 윤년", year);
      else
        Console.WriteLine("{0}년은 평년", year);
      //}
    }
  }
}
