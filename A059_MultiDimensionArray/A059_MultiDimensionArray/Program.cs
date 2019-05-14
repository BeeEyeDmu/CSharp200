using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A059_MultiDimensionArray
{
  class Program
  {
    static void Main(string[] args)
    {
      // 2차원 배열
      Console.WriteLine("2차원 배열: arr1[2, 3]");
      int[,] arrA = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
      for (int i = 0; i < 2; i++)
      {
        for (int j = 0; j < 3; j++)
          Console.Write("{0,5}", arrA[i, j]);
        Console.WriteLine();
      }
      Console.WriteLine("Length={0} GetLength(0)={1} GetLength(1)={2}",
        arrA.Length, arrA.GetLength(0), arrA.GetLength(1));
      Array.Clear(arrA, 0, arrA.Length);

      // 가변배열(jagged array)
      Console.WriteLine("2차원 배열: arrB[2][3]");
      int[][] arrB = new int[2][];
      arrB[0] = new int[] { 1, 2 };
      arrB[1] = new int[] { 3, 4, 5 };
      for (int i = 0; i < 2; i++)
      {
        Console.Write("arrB[{0}] : ", i);
        for (int j = 0; j < arrB[i].Length; j++)
          Console.Write("{0}  ", arrB[i][j]);
        Console.WriteLine();
      }
    }
  }
}
