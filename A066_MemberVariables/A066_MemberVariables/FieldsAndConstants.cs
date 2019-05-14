using System;

namespace A066_FieldsAndConstants
{
  class Product
  {
    public string name;
    public int price;
  }

  class MyMath
  {
    public static double PI = 3.14;
  }

  class MyCalendar
  {
    public const int months = 12;
    public const int weeks = 52;
    public const int days = 365;

    public const double daysPerWeek = (double)days / (double)weeks;
    public const double daysPerMonth = (double)days / (double)months;
  }

  class FieldsAndConstants
  {
    static void Main(string[] args)
    {
      Product p = new Product();
      p.name = "시계";
      p.price = 100000;

      Console.WriteLine("{0} : {1:C}", p.name, p.price);
      Console.WriteLine("원주율 : {0}", MyMath.PI);

      Console.WriteLine("한달은 평균 {0:F3}일", MyCalendar.daysPerMonth);
    }
  }
}
