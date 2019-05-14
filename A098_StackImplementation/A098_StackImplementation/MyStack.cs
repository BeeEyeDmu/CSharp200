using System;

namespace A098_StackImplementation
{
  class MyStack<T>
  {
    const int maxSize = 10;
    private T[] arr = new T[maxSize];
    private int top;

    public MyStack()
    {
      top = 0;
    }

    public void Push(T val)
    {
      if (top < maxSize)
      {
        arr[top] = val;
        ++top;
      }
      else
      {
        Console.WriteLine("Stack Full");
        return;
      }
    }

    public T Pop()
    {
      if (top > 0)
      {
        --top;
        return arr[top];
      }
      else
      {
        Console.WriteLine("Stack Empty");
        return default(T);
      }
    }
  }
}