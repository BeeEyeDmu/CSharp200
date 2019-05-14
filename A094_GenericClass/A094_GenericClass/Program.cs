using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A094_GenericClass
{
  class MyClass<T>
  {
    private T[] arr;
    private int count = 0;

    public MyClass(int length)
    {
      arr = new T[length];
      count = length;
    }

    public void Insert(params T[] args)
    {
      for (int i = 0; i < args.Length; i++)
        arr[i] = args[i];
    }

    public void Print()
    {
      foreach (T i in arr)
        Console.Write(i + " ");
      Console.WriteLine();
    }

    public T AddAll()
    {
      T sum = default(T);
      foreach (T item in arr)
        sum = sum + (dynamic)item;
      return sum;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      MyClass<int> a = new MyClass<int>(10);
      MyClass<string> s = new MyClass<string>(5);

      a.Insert(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
      s.Insert("Tiger", "Lion", "Zebra", "Monkey", "Cow");

      a.Print();
      s.Print();

      Console.WriteLine("a.AddAll() : " + a.AddAll());
      Console.WriteLine("s.AddAll() : " + s.AddAll());
    }
  }
}
