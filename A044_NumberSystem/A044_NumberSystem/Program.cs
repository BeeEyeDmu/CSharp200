using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A044_NumberSystem
{
  class Program
  {
    static void Main(string[] args)
    {
      #region (1) 2/8/16 진수 출력
      // (1) 1부터 128까지의 숫자를 2진수, 8진수, 16진수로 출력
      Console.WriteLine("{0,5} {1,8} {2,3} {3,4}", "10진수", "2진수", "8진수", "16진수");
      for (int i = 1; i <= 128; i++)
      {
        //String str = Convert.ToString(i, 2);
        //str.PadLeft(8, '0'); 
        //string s = string.Format("", );
        Console.WriteLine("{0,7} {1,10} {2,5} {3,6}", i,
          Convert.ToString(i, 2).PadLeft(8, '0'),
          Convert.ToString(i, 8),
          Convert.ToString(i, 16));
      }
      #endregion

      #region (2) 구구단 출력
      // (2) 1~9사이의 정수 n을 읽어들여 해당하는 구구단의 n단 출력
      Console.Write("구구단의 단수를 입력하세요 : ");
      int n = int.Parse(Console.ReadLine());
      for (int i = 1; i <= 9; i++)
      {
        Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
      }
      #endregion

      #region (3) 평균, 최소, 최대
      // (3) 5명의 키를 읽은 후 평균과 최소, 최대값을 구하여 출력
      double max = double.MinValue;
      double min = double.MaxValue;
      double sum = 0;
      for (int i = 0; i < 5; i++)
      {
        Console.Write("키를 입력하세요(단위: cm) : ");
        double h = double.Parse(Console.ReadLine());
        if (h > max)
          max = h;
        if (h < min)
          min = h;
        sum += h;
      }
      Console.WriteLine("평균: {0,6}, 최대: {1}, 최소:{2}", sum / 5, max, min); 
      #endregion
    }
  }
}
