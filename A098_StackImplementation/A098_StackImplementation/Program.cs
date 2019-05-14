using System;

namespace A098_StackImplementation
{
  class Program
  {
    static void Main(string[] args)
    {
      MyStack<int> stack = new MyStack<int>();
      Random r = new Random();

      for (int i = 0; i < 10; i++)
      {
        int val = r.Next(100);
        stack.Push(val);
        Console.WriteLine("Push(" + val + ") ");
        //Console.WriteLine(" top = " + stack.top);
      }

      Console.WriteLine();
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine("Pop() = " + stack.Pop());
      }
    }
  }
}