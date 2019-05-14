using System;
using System.Collections.Generic;

namespace A111_SortedList
{
  class Program
  {
    static void Main(string[] args)
    {
      SortedList<int, string> s1 = new SortedList<int, string>();
      s1.Add(3, "Three");
      s1.Add(4, "Four");
      s1.Add(1, "One");
      s1.Add(2, "Two");

      for (int i = 0; i < s1.Count; i++)
        Console.Write("k: {0}, v: {1} / ", s1.Keys[i], s1.Values[i]);
      Console.WriteLine();

      foreach(var kvp in s1)
        Console.Write("{0, -10} ", kvp);
      Console.WriteLine();

      SortedList<string, int> s2 = new SortedList<string, int>();
      s2.Add("one", 1);
      s2.Add("two", 2);
      s2.Add("three", 3);
      s2.Add("four", 4);

      //Console.WriteLine(s2["one"]);
      Console.WriteLine(s2["two"]);

      foreach (var kvp in s2)
        Console.Write("{0, -10} ", kvp);
      Console.WriteLine();

      //for (int i = 0; i < s2.Count; i++)
      //  Console.Write("k: {0}, v: {1}", s2.Keys[i], s2.Values[i]);

      int val;

      if (s2.TryGetValue("ten", out val))
        Console.WriteLine("key: ten, value: {0}", val);
      else
        Console.WriteLine("[ten] : Key is not valid.");

      if (s2.TryGetValue("one", out val))
        Console.WriteLine("key: one, value: {0}", val);
      
      Console.WriteLine(s2.ContainsKey("one"));  // returns true
      Console.WriteLine(s2.ContainsKey("ten"));  // returns false

      Console.WriteLine(s2.ContainsValue(2)); // returns true
      Console.WriteLine(s2.ContainsValue(6)); // returns false

      s2.Remove("one");// 키가 'one' 요소 삭제
      s2.RemoveAt(0);  // 첫번째 요소 삭제

      foreach (KeyValuePair<string, int> kvp in s2)
        Console.Write("{0, -10} ", kvp);
      Console.WriteLine();
    }
  }
}
