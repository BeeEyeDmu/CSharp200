using System;
using System.Collections.Generic;

namespace A109_Stack
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("계산할 수식을 Polish 표기법으로 입력하세요: ");
      string[] token = Console.ReadLine().Split();

      foreach (var i in token)
        Console.Write(" {0}", i);
      Console.Write(" = ");

      Stack<double> nStack = new Stack<double>();
      foreach(var s in token)
      {
        if(isOperator(s))
        {
          switch (s)
          {
            case "+":
              nStack.Push(nStack.Pop() + nStack.Pop());
              break;
            case "-":
              nStack.Push(-(nStack.Pop() - nStack.Pop()));
              break;
            case "*":
              nStack.Push(nStack.Pop() * nStack.Pop());
              break;
            case "/":
              nStack.Push(1.0/(nStack.Pop() / nStack.Pop()));
              break;
          }
        }
        else
        {
          nStack.Push(double.Parse(s));
        }
      }

      Console.WriteLine("결과는 {0}", nStack.Pop());
    }

    private static bool isOperator(string s)
    {
      if (s == "+" || s == "-" || s == "*" || s == "/")
        return true;
      else
        return false;
    }

    private static bool isNumber(string s)
    {      
      if (Double.TryParse(s, out double number))
        return true;
      else
        return false;
    }
  }
}
