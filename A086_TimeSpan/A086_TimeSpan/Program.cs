using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A086_TimeSpan
{
  class Program
  {
    static void Main(string[] args)
    {
      // TimeSpan
      DateTime christmas = new DateTime(2018, 12, 25);
      DateTime newYearsDay = new DateTime(2019, 1, 1);
      //TimeSpan span = newYearsDay.Subtract(christmas);
      TimeSpan span = newYearsDay - christmas;
      Console.WriteLine("크리스마스와 1월 1일의 시간 간격");
      Console.WriteLine("{0,14}", span);
      Console.WriteLine("{0,14} days", span.Days);
      Console.WriteLine("{0,14} hours", span.Hours);
      Console.WriteLine("{0,14} minutes", span.Minutes);
      Console.WriteLine("{0,14} seconds", span.Seconds);
      Console.WriteLine("{0,14} milliseconds", span.Milliseconds);
      //Console.WriteLine("{0,14} ticks", span.Ticks);

      Console.WriteLine("\n또는");

      Console.WriteLine("{0,14}", span);
      Console.WriteLine("{0,14} days", span.TotalDays);
      Console.WriteLine("{0,14} hours", span.TotalHours);
      Console.WriteLine("{0,14} minutes", span.TotalMinutes);
      Console.WriteLine("{0,14} seconds", span.TotalSeconds);
      Console.WriteLine("{0,14} milliseconds", span.TotalMilliseconds);
      Console.WriteLine("{0,14} ticks", span.Ticks);

      // 생애 계산기
      Console.Write("생년월일 시분초를 입력하세요: ");
      DateTime date1 = DateTime.Parse(Console.ReadLine());
      DateTime date2 = DateTime.Now;
      // Calculate the interval between the two dates.
      TimeSpan interval = date2 - date1;
      Console.WriteLine("탄생 시간: {0}", date1);
      Console.WriteLine("현재 시간: {0}", date2);
      Console.WriteLine("생존 시간: {0}", interval.ToString());
      // Display individual properties of the resulting TimeSpan object.
      Console.WriteLine("당신은 지금 이 순간까지 {0}일 {1}시간"
        + " {2}분 {3}초를 살았습니다.", 
        interval.Days, interval.Hours, 
        interval.Minutes, interval.Seconds);
      Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", interval.Days);
      Console.WriteLine("   {0,-35} {1,20}", "Total Number of Days:", interval.TotalDays);
      Console.WriteLine("   {0,-35} {1,20}", "Value of Hours Component:", interval.Hours);
      Console.WriteLine("   {0,-35} {1,20}", "Total Number of Hours:", interval.TotalHours);
      Console.WriteLine("   {0,-35} {1,20}", "Value of Minutes Component:", interval.Minutes);
      Console.WriteLine("   {0,-35} {1,20}", "Total Number of Minutes:", interval.TotalMinutes);
      Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Seconds Component:", interval.Seconds);
      Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Seconds:", interval.TotalSeconds);
      Console.WriteLine("   {0,-35} {1,20:N0}", "Value of Milliseconds Component:", interval.Milliseconds);
      Console.WriteLine("   {0,-35} {1,20:N0}", "Total Number of Milliseconds:", interval.TotalMilliseconds);
      Console.WriteLine("   {0,-35} {1,20:N0}", "Ticks:", interval.Ticks);
    }
  }
}
