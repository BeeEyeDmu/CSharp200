using System;

namespace A096_LinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList list = new LinkedList();
      Random r = new Random();

      for (int i = 0; i < 5; i++)
        list.InsertLast(r.Next(100));

      Console.WriteLine("랜덤한 5개 값의 리스트입니다");
      list.Print();

      Console.Write("\n리스트의 맨 앞에 10, 맨 뒤에 90을 삽입합니다. <Enter>를 입력하세요");
      Console.ReadLine();
      list.InsertFront(10);      
      list.InsertLast(90);      
      list.Print();

      Console.WriteLine("\nx 노드 뒤에 y값을 저장하려고 합니다.");
      Console.Write(" x값을 입력하세요: ");
      int x = int.Parse(Console.ReadLine());
      Console.Write(" y값을 입력하세요: ");
      int y = int.Parse(Console.ReadLine());

      list.InsertAfter(x, y);
      list.Print();

      Console.Write("\n삭제할 노드의 값을 입력하세요: ");
      int z = int.Parse(Console.ReadLine());
      list.DeleteNode(z);
      list.Print();

      Console.WriteLine("\n리스트를 뒤집어서 출력합니다. <Enter>를 입력하세요");
      Console.ReadLine();
      list.Reverse();
      list.Print();
    }
  }
}
