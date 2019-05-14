using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A092_3_SortArrayPair
{
  // 내림차순 정렬
  public class ReverseComparer : IComparer
  {
    public int Compare(object x, object y)
    {
      string s1 = (string)x;
      string s2 = (string)y;
      return string.Compare(s2, s1);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      string[] animalsEn = { "dog", "cow", "rabbit", "goat", "sheep", "mouse"};
      string[] animalsKo = { "개", "소", "토끼", "염소", "양", "쥐" };

      Display("Before Sort", animalsEn, animalsKo);
      Array.Sort(animalsEn, animalsKo);
      Display("After Sort", animalsEn, animalsKo);

      Array.Sort(animalsKo, animalsEn);
      Display("After Sort by Korean", animalsEn, animalsKo);

      IComparer revCom = new ReverseComparer();
      Array.Sort(animalsEn, animalsKo, revCom);
      Display("After Descending Sort", animalsEn, animalsKo);
    }

    private static void Display(string comment, string[] arr1, string[] arr2)
    {
      Console.WriteLine(comment);
      for (int i = 0; i<arr1.Length ; i++)
      {
        Console.WriteLine("  [{0}] : {1,-8} {2,-8}", i, arr1[i], arr2[i]);
      }
      Console.WriteLine();
    }
  }
}