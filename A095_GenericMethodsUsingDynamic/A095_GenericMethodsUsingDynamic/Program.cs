using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A095_GenericMethodsUsingDynamic
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] a = { 10, 45, 32, 47, 85, 46, 93, 47, 50, 71 };
      double[] d = { 0.1, 5.3, 6.7, 8.5, 4.9, 6.1 };
      float[] f = { 1.2f, 5.3f, 7.8f, 6.1f, 3.4f, 8.8f };
      decimal[] c = { 123, 783, 456, 234, 456, 748 };

      PrintArray<int>("a[] :", a);
      CalcArray<int>(a);
      PrintArray<double>("d[] :", d);
      CalcArray<double>(d);
      PrintArray<float>("f[] :", f);
      CalcArray<float>(f);
      PrintArray<decimal>("c[] :", c);
      CalcArray<decimal>(c);
    }

    private static void CalcArray<T>(T[] a) where T : struct
    {
      T sum = default(T);
      T avg = default(T);
      T max = default(T);

      foreach (dynamic item in a)
      {
        if (max < item)
          max = item;
        sum += item;
      }
      avg = (dynamic)sum / a.Length;
      Console.WriteLine("      Sum = {0}, Average = {1}, Max = {2}",
          sum, avg, max);
    }

    private static void PrintArray<T>(string s, T[] a) where T : struct
    {
      Console.Write(s);
      foreach (var item in a)
      {
        Console.Write(" {0}", item);
      }
      Console.WriteLine();
    }
  }
}
