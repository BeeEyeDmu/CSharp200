using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A119_ListAndLambda
{
  class Program
  {
    static void Main(string[] args)
    {
        List<String> myList = new List<String> {
        "mouse", "cow", "tiger", "rabbit", "dragon", "snake"
      };

        bool n = myList.Exists(s => s.Contains("x"));
        Console.WriteLine("이름에 'x'를 포함하는 동물이 있나요 : " + n);

        Console.Write("이름이 3글자인 첫번째 동물 : ");
        string name = myList.Find(s => s.Length == 3);
        Console.WriteLine(name);

        Console.Write("6글자 이상의 동물들: ");
        List<string> longName = myList.FindAll(s => s.Length > 5);
        foreach (var item in longName)
        {
          Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.Write("대문자로 변환: ");
        List<string> capList = myList.ConvertAll(s => s.ToUpper());
        foreach (var item in capList)
          Console.Write(item + " ");
        Console.WriteLine();
      }
    }
  }

