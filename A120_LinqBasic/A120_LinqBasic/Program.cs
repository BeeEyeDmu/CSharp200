using System;
using System.Collections.Generic;
using System.Linq;

namespace A120_LinqBasic
{
  class Program
  {
    // List에서 짝수 데이터를 꺼내어 정렬하여 출력한다
    static void Main(string[] args)
    {
      List<int> data = new List<int> { 123, 45, 12, 89, 456, 1, 4, 74, 46 };
      List<int> lstSortedEven = new List<int>();

      foreach (var item in data)
      {
        if (item % 2 == 0)
          lstSortedEven.Add(item);
      }
      lstSortedEven.Sort();

      Console.WriteLine("Using foreach: ");
      foreach (var item in lstSortedEven)
        Console.Write(item + " ");
      Console.WriteLine();

      IEnumerable<int> sortedEven = from item in data
              where item % 2 == 0
              orderby item
              select item;

      Console.WriteLine("\nUsing Linq: ");
      foreach (var item in sortedEven)
        Console.Write(item + " ");
      Console.WriteLine();
    }
  }
}
