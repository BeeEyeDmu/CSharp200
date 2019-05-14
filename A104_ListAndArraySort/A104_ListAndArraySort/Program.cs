using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A104_ListAndArraySort
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> lstNames = new List<string>();
      lstNames.Add("dog");
      lstNames.Add("cow");
      lstNames.Add("rabbit");
      lstNames.Add("goat");
      lstNames.Add("sheep");
      lstNames.Sort();
      foreach (string s in lstNames)
        Console.Write(s + " ");
      Console.WriteLine();

      //Array arrNames = new Array(100);
      string[] arrNames = new string[100];
      arrNames[0] = "dog";
      arrNames[1] = "cow";
      arrNames[2] = "rabbit";
      arrNames[3] = "goat";
      arrNames[4] = "sheep";
      Array.Sort(arrNames);
      foreach (string s in lstNames)
        Console.Write(s + " ");
      Console.WriteLine();
    }
  }
}
