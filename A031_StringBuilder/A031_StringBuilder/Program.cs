using System;
using System.Diagnostics;
using System.Text;

namespace A031_StringBuilder
{
  class Program
  {
    static void Main(string[] args)
    {
      StringBuilder sb = new StringBuilder("This is a StringBuilder Test.");
      Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

      sb.Clear();
      Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

      sb.Append("This is a new string.");
      Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

      sb.Insert(5, "xyz ", 2);
      Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

      sb.Remove(5, 4);
      Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

      sb.Replace("xyz", "abc");
      Console.WriteLine("{0} ({1} characters)", sb.ToString(), sb.Length);

      Stopwatch time = new Stopwatch();
      string test = string.Empty;
      time.Start();
      for (int i = 0; i < 100000; i++)
      {
        test += i;
      }
      time.Stop();
      Console.WriteLine("Using String concatenation: " + time.ElapsedMilliseconds + " milliseconds");


      StringBuilder test1 = new StringBuilder();
      time.Reset();
      time.Start();
      for (int i = 0; i < 100000; i++)
      {
        test1.Append(i);
      }
      time.Stop();
      Console.WriteLine("Using StringBuilder: " + time.ElapsedMilliseconds + " milliseconds");
    }
  }
}
