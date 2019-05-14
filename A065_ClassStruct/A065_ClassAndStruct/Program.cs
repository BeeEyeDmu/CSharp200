using System;

namespace A065_ClassAndStruct
{
  struct DateStruct
  {
    public int year, month, day;
  }

  class DateClass
  {
    public int year, month, day;
  }
  class Program
  {
    static void Main(string[] args)
    {
      DateStruct sDay;
      sDay.year = 2018;
      sDay.month = 11;
      sDay.day = 22;
      Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);

      DateClass cDay = new DateClass();
      cDay.year = 2018;
      cDay.month = 11;
      cDay.day = 22;
      Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);

      DateStruct sDay2 = new DateStruct();
      Console.WriteLine("sDay2: {0}/{1}/{2}", sDay2.year, sDay2.month, sDay2.day);
      DateClass cDay2 = new DateClass();
      Console.WriteLine("cDay2: {0}/{1}/{2}", cDay2.year, cDay2.month, cDay2.day);

      DateStruct s = sDay;
      DateClass c = cDay;

      s.year = 2000;
      c.year = 2000;

      Console.WriteLine("s: {0}/{1}/{2}", s.year, s.month, s.day);
      Console.WriteLine("c: {0}/{1}/{2}", c.year, c.month, c.day);
      Console.WriteLine("sDay: {0}/{1}/{2}", sDay.year, sDay.month, sDay.day);
      Console.WriteLine("cDay: {0}/{1}/{2}", cDay.year, cDay.month, cDay.day);

    }
  }
}
