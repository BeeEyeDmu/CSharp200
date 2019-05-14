using System;

namespace A101_QueueImplementation
{
  class Node<T>
  {
    internal T value;
    internal Node<T> next;

    public Node (T value)
    {
      this.value = value;
      this.next = null;
    }      
  }

  class MyQueue<T>
  {
    internal Node<T> first = null;
    internal Node<T> last = null;
    
    internal void EnQueue(Node<T> node)
    {
      if (last == null)
        first = last = node;
      else
      {
        last.next = node;
        last = node;
      }
    }

    internal T DeQueue()
    {
      if (first == null)
      {
        Console.WriteLine("Queue Empty");
        return default(T);
      }
      else
      {
        T value = first.value;
        first = first.next;
        return value;
      }
    }

    internal void Print()
    {
      for (Node<T> t = first; t != null; t = t.next)
        Console.Write(t.value + " -> ");
      Console.WriteLine();
    }
  }
}
