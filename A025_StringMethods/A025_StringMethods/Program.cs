using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A025_StringMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = " Hello, World! ";
      string t;

      Console.WriteLine(s.Length);
      Console.WriteLine(s[8]);

      Console.WriteLine(s.Insert(8, "C# "));
      Console.WriteLine(s.PadLeft(20, '.'));
      Console.WriteLine(s.PadRight(20, '.'));
      Console.WriteLine(s.Remove(6));      
      Console.WriteLine(s.Remove(6, 7));
      Console.WriteLine(s.Replace('l', 'm'));
      Console.WriteLine(s.ToLower());
      Console.WriteLine(s.ToUpper());
      Console.WriteLine('/' + s.Trim() + '/');
      Console.WriteLine('/' + s.TrimStart() + '/');
      Console.WriteLine('/' + s.TrimEnd() + '/');

      string[] a = s.Split(',');
      foreach(var i in a)
        Console.WriteLine('/' + i + '/');

      char[] destination = new char[10];
      s.CopyTo(8, destination, 0, 6);
      Console.WriteLine(destination);

      Console.WriteLine('/' + s.Substring(8) + '/');
      Console.WriteLine('/' + s.Substring(8, 5) + '/');

      Console.WriteLine(s.Contains("ll"));
      Console.WriteLine(s.IndexOf('o'));
      Console.WriteLine(s.LastIndexOf('o'));
      Console.WriteLine(s.CompareTo("abc"));
 
      Console.WriteLine(String.Concat("Hi~", s));
      Console.WriteLine(String.Compare("abc", s));
      Console.WriteLine(t = String.Copy(s));

      String[] val = { "apple", "orange", "grape", "pear" };
      String result = String.Join(", ", val);
      Console.WriteLine(result);
    }
  }
}
