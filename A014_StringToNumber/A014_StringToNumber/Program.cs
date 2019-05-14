using System;

namespace A014_StringToNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      //int num = Int32.Parse("-15");
      //Console.WriteLine(num);

      //int i;
      //if (int.TryParse("-1004", out i))
      //  Console.WriteLine(i);
      //else
      //  Console.WriteLine("숫자로 바꿀 수 없습니다.");

      string input;
      int value;      

      Console.Write("1. int로 변환할 문자열을 입력하세요: ");
      input = Console.ReadLine();
      bool result = Int32.TryParse(input, out value);

      if (!result)
        Console.WriteLine("'{0}'는 int로 변환될 수 없습니다.\n", input);
      else
        Console.WriteLine("int '{0}'으로 변환되었습니다.\n", value);

      Console.Write("2. double로 변환할 문자열을 입력하세요: ");
      input = Console.ReadLine();
      try
      {
        double m = Double.Parse(input);
        Console.WriteLine("double '{0}'으로 변환되었습니다.\n", m);
      }
      catch (FormatException e)
      {
        Console.WriteLine(e.Message);
      }

      // Convert

    }
  }
}
