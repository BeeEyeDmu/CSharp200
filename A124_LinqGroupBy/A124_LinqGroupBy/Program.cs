using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A124_LinqGroupBy
{
  class Student
  {
    public string Name { get; set; }
    public int Id { get; set; }
    public List<int> Scores { get; set; }
  }
  
  class Program
  {
    static List<Student> students;

    static void Main(string[] args)
    {
      students = new List<Student>
      {
        new Student {Name="PjKim", Id=19001001, Scores = new List<int>{86,90,76}},
        new Student {Name="BsKim", Id=19001002, Scores = new List<int>{56,92,93}},
        new Student {Name="YsCho", Id=19001003, Scores = new List<int>{69,85,75}},
        new Student {Name="BiKang", Id=19001004, Scores = new List<int>{88,80,57}},       
      };

      var result = from student in students
                   group student by student.Scores.Average() >= 80 into g 
                   select new
                   {
                     key = g.Key == true ? "80점이상" : "80점미만", 
                     count = g.Count(), //해당 구간의 학생수
                     avr = g.Average(student => student.Scores.Average()),
                     max = g.Max(student => student.Scores.Average()) 
                   };

      foreach (var item in result)
      {
        Console.WriteLine("{0} : 학생 수 = {1}", item.key, item.count);
        Console.WriteLine("{0} : 평균 점수 = {1:F2}", item.key, item.avr);
        Console.WriteLine("{0} : 최고 점수 = {1:F2}", item.key, item.max);
        Console.WriteLine();
      }
    }
  }
}
