using System;

namespace A026_SplitMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("더하고자하는 숫자들을 입력하세요: ");
      string s = Console.ReadLine();
      Console.WriteLine(s);

      int sum = 0;
      char[] delimiters = { ',', ' ', '-' };
      string[] v = s.Split(delimiters);
      
      foreach (var i in v)
      {
        sum += int.Parse(i);
      }
      Console.WriteLine("결과는 {0}", sum);
    }
  }
}
