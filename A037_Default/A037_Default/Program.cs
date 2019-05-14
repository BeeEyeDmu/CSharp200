using System;
using System.Collections.Generic;

namespace A037_Default
{
  class Program
  {
    enum E { Red, Green, Blue };  

    static void Main(string[] args)
    {
      int a = default;
      string s = default;
      Console.WriteLine("a = " + a);
      Console.WriteLine("s = " + s);
      Console.WriteLine("E = " + default(E));
      Console.WriteLine("E = " + (E)0);

      GenericList<int> iList = new GenericList<int>();
      Console.WriteLine("iList : " + iList.GetLast());

      GenericList<string> sList = new GenericList<string>();
      Console.WriteLine("sList : " + sList.GetLast());
      
      //sList.PrintList();
      //sList.AddNode("Tiger");
      //sList.AddNode("Lion");
      //iList.PrintList();
      //iList.AddNode(10);
      //iList.AddNode(20);
      //Console.WriteLine(iList.GetLast());
    }
  }

  public class GenericList<T>
  {
    private class Node
    {
      public T data;
      public Node next;
    }
    private Node head = default;

    public void AddNode(T t)
    {
      Node newNode = new Node();
      newNode.next = head;
      newNode.data = t;
      head = newNode;
    }

    public void PrintList()
    {
      for(Node ptr=head; ptr!=default; ptr=ptr.next)
        Console.Write(ptr.data + " ");
      Console.WriteLine();
    }

    public T GetLast()
    {
      // The value of temp is returned as the value of the method. 
      // The following declaration initializes temp to the appropriate 
      // default value for type T. The default value is returned if the 
      // list is empty.
      T temp = default(T);

      Node current = head;
      while (current != null)
      {
        temp = current.data;
        current = current.next;
      }
      return temp;
    }
  }
}
