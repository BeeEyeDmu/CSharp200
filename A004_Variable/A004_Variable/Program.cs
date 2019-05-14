using System;

namespace A004_Variable
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("이름을 입력하세요: ");
      string name = Console.ReadLine();
      Console.Write("나이를 입력하세요: ");
      int age = int.Parse(Console.ReadLine());
      Console.Write("카를 입력하세요(cm): ");
      float height = float.Parse(Console.ReadLine());

      Console.Write("안녕하세요, ");
      Console.Write(name); 
      Console.WriteLine("님!");

      Console.Write("나이는 ");
      Console.Write(age);
      Console.Write("세, 키는 ");
      Console.Write(height);
      Console.WriteLine("cm 이군요!");
    }
  }
}
