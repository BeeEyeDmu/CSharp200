using System;

namespace A006_Assignment
{
  class Program
  {
    static void Main(string[] args)
    {
      int i;
      double x;

      i = 5;
      x = 3.141592;      
      Console.WriteLine("i = " + i + ", x = " + x);

      x = i; // 암시적 형변환 from int to double
      i = (int)x; // 캐스트가 필요함
      Console.WriteLine("i = " + i + ", x = " + x);
    }
  }
}