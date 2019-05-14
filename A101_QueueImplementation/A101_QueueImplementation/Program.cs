using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101_QueueImplementation
{
  class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();
      MyQueue<float> que = new MyQueue<float>();
      for (int i = 0; i < 5; i++)
        que.EnQueue(new Node<float>(r.Next(100)/100.0F));

      que.Print();

      for (int i = 0; i < 3; i++)
        Console.WriteLine("DeQueue: {0}", que.DeQueue()); 

      que.Print();
      
    }
  }
}