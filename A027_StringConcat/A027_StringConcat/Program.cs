using System;

namespace StringConcat
{
  class Program
  {
    static void Main(string[] args)
    {
      string userName = "bikang";
      string date = DateTime.Today.ToShortDateString();

      string strPlus = "Hello " + userName + ". Today is " + date + ".";
      Console.WriteLine(strPlus);

      string strFormat = String.Format("Hello {0}. Today is {1}.", userName, date);
      Console.WriteLine(strFormat);

      string strInterpolation = $"Hello {userName}. Today is {date}.";
      System.Console.WriteLine(strInterpolation);

      //string name = "bikang";
      //int age = 12;
      //Console.WriteLine($"{name} is {age} year{(age == 1 ? "" : "s")} old.");
      //Console.WriteLine(name + " is " + age + " year" + (age == 1 ? "" : "s") + " old.");

      string strConcat = String.Concat("Hello ", userName, ". Today is ", date, ".");
      Console.WriteLine(strConcat);
      
      string[] animals = { "mouse", "cow", "tiger", "rabbit", "dragon"};
      string s = String.Concat(animals);
      Console.WriteLine(s);
      s = String.Join(", ", animals);
      Console.WriteLine(s);
    }
  }
}
