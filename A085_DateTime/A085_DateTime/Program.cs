using System;

namespace A085_DateTime
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime date1 = new DateTime(1992, 7, 4, 8, 44, 0);
      DateTime date2 = new DateTime(1990, 1, 27, 12, 6, 0);
      Console.WriteLine(date1);
      Console.WriteLine(date2);
      Console.WriteLine("{0}과 {1}의 차이는 {2}일입니다", 
        date1.ToString("yyyy년 M월 d일"), 
        date2.ToString("yyyy년 M월 d일"), 
        date1.Subtract(date2).Days);

      Console.WriteLine("\n오늘: {0}", DateTime.Today);

      DateTime y = DateTime.Today.AddDays(-1);  // 어제
      Console.WriteLine("어제: {0}", y.ToShortDateString());

      DateTime t  = DateTime.Today.AddDays(1);  // 내일
      Console.WriteLine("내일: {0}", t.ToShortDateString());

      Console.WriteLine("\n2020년은 {0}입니다", DateTime.IsLeapYear(2020) ? "윤년" : "평년");
      Console.WriteLine("2020년 2월은 {0}일입니다.\n", DateTime.DaysInMonth(2020, 2));

      // Parse and TryParse
      string date = "1990-1-27 12:6";
      DateTime aDay = DateTime.Parse(date);
      Console.WriteLine(aDay);

      string input = "1992/7/4 8:44";
      DateTime bDay;
      if (DateTime.TryParse(input, out bDay))
      {
        Console.WriteLine(bDay);
      }
      Console.WriteLine();

      DateTime d1 = DateTime.Now;
      DateTime d2 = DateTime.UtcNow;

      Console.WriteLine(d1);
      Console.WriteLine(d2);
    }    
  }
}
