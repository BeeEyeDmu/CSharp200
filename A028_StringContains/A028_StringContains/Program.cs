using System;

namespace A028_StringContains
{
  class Program
  {
    static void Main(string[] args)
    {
      string s1 = "mouse, cow, tiger, rabbit, dragon";
      string s2 = "cow";
      bool b = s1.Contains(s2);
      Console.WriteLine("'{0}' is in the string '{1}': {2}", s2, s1, b);

      if (b)
      {
        int index = s1.IndexOf(s2);
        if (index >= 0)
          Console.WriteLine("'{0} begins at index {1}", s2, index);
      }

      int i = s1.IndexOf(s2, StringComparison.CurrentCultureIgnoreCase);
      if (i >= 0)
      {
        Console.WriteLine("'{0}' is in the string '{1}' ", s2, s1);
        Console.WriteLine("at index {0} (case insensitive)", i);
      }
    }
  }
}
