using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A015_Convert
{
  class Program
  {
    static void Main(string[] args)
    {
      int x, y;

      Console.Write("첫번째 숫자를 입력하세요: ");
      x = Convert.ToInt32(Console.ReadLine());
      Console.Write("두번째 숫자를 입력하세요: ");
      y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

      // 2진수, 8진수, 10진수, 16진수로 출력하기
      short value = short.MaxValue; // Int16.MaxValue

      Console.WriteLine("\n2진수, 8진수, 10진수, 16진수로 출력하기");

      //for(int baseNum = 2; baseNum <= 16; baseNum*=4)
      //{
      //  s = Convert.ToString(value, baseNum);
      //  int i = Convert.ToInt32(s, baseNum);
      //  Console.WriteLine("value = {0}, {1,2}진수 = {2,16}, i = {3}", value, baseNum, s, i);
      //}

      int baseNum = 2;
      string s = Convert.ToString(value, baseNum); // value를 string으로 변환(2진수로)
      int i = Convert.ToInt32(s, baseNum);  // string으로 변환된 값을 2진수로 읽어서 int로 다시 변환
      Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);

      baseNum = 8;
      s = Convert.ToString(value, baseNum);
      i = Convert.ToInt32(s, baseNum);
      Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);

      baseNum = 10;
      s = Convert.ToString(value, baseNum);
      i = Convert.ToInt32(s, baseNum);
      Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);

      baseNum = 16;
      s = Convert.ToString(value, baseNum);
      i = Convert.ToInt32(s, baseNum);
      Console.WriteLine("i = {0}, {1,2}진수 = {2,16}", i, baseNum, s);

      //double dNum = 23.15;

      //int iNum = Convert.ToInt32(dNum);
      //bool bNum = Convert.ToBoolean(dNum);
      //string sNum = Convert.ToString(dNum);

      Console.WriteLine(@"abc\nabc");
      Console.WriteLine("123\n123");

      string a = "\\\u0066\n";
      Console.WriteLine(a);

      string b = "C:\\Windows\\";
      Console.WriteLine(b);		// “C:\Windows\"를 출력
    }
  }
}
