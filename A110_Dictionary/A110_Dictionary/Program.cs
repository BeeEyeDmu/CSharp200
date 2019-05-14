using System;
using System.Collections.Generic;

namespace A110_Dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> colorTable = new Dictionary<string, string>();
            
      colorTable.Add("Red", "빨간색");
      colorTable.Add("Green", "초록색");
      colorTable.Add("Blue", "파란색");

      foreach(var v in colorTable)
        Console.WriteLine("colorTable[{0}] = {1}", v.Key, v.Value);
      Console.WriteLine();

      try
      {
        colorTable.Add("Red", "빨강");
      }
      catch(ArgumentException e)
      {
        Console.WriteLine(e.Message);
      }

      try
      {
        Console.WriteLine("Yellow => {0}", colorTable["Yellow"]);
      }
      catch(KeyNotFoundException e)
      {
        Console.WriteLine(e.Message);
      }

      Console.WriteLine("\n"+colorTable["Red"]);
      Console.WriteLine(colorTable["Green"]);
      Console.WriteLine(colorTable["Blue"]);
    }
  }
}
