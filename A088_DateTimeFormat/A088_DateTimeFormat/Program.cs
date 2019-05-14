using System;
using System.Globalization;

namespace A088_DateTimeFormat
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime today = DateTime.Now;

      Console.WriteLine(today.ToString("yyyy년 MM월 dd일"));
      Console.WriteLine(string.Format("{0:yyyy년 MM월 dd일}", today));
      Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", CultureInfo.CreateSpecificCulture("en-US")));
      Console.WriteLine(today.ToString("MMMM dd, yyyy ddd", new CultureInfo("en-US")));

      // 오전, 오후
      Console.WriteLine(today.ToString("tt"));
      today = today.AddHours(12);
      Console.WriteLine(today.ToString("tt"));
      today = today.AddHours(-12);

      Console.WriteLine("\n표준 포맷 지정자");
      
      // d : 축약된 날짜 형식
      Console.WriteLine("d : " + today.ToString("d"));
      Console.WriteLine("d : " + today.ToString("d", new CultureInfo("en-US")));      

      // D : 긴 날짜 형식
      Console.WriteLine("D : " + string.Format("{0:D}", today));  
      Console.WriteLine("D : " + string.Format(new CultureInfo("en-US"), "{0:D}", today)); 

      // t : 축약된 시간
      Console.WriteLine("t : " + string.Format("{0:t}", today)); 
      Console.WriteLine("t : " + string.Format(new CultureInfo("en-US"), "{0:t}", today));

      // T : 긴 시간 형식
      Console.WriteLine("T : " + string.Format("{0:T}", today)); 
      Console.WriteLine("T : " + string.Format(new CultureInfo("en-US"), "{0:T}", today));

      // g : 일반 날 및 시간 (초 생략)
      Console.WriteLine("g : " + string.Format("{0:g}", today)); 
      Console.WriteLine("g : " + string.Format(new CultureInfo("en-US"), "{0:g}", today));

      // G : 일반 날짜 및 시간
      Console.WriteLine("G : " + string.Format("{0:G}", today)); 
      Console.WriteLine("G : " + string.Format(new CultureInfo("en-US"), "{0:G}", today));

      // f : Full 날짜 및 시간 (초 생략)
      Console.WriteLine("f : " + string.Format("{0:f}", today));
      Console.WriteLine("f : " + string.Format(new CultureInfo("en-US"), "{0:f}", today));

      // F : Full 날짜 및 시간
      Console.WriteLine("F : " + string.Format("{0:F}", today));
      Console.WriteLine("F : " + string.Format(new CultureInfo("en-US"), "{0:F}", today));

      // s : ISO 8601 표준
      Console.WriteLine("s : " + string.Format("{0:s}", today));
      //Console.WriteLine("s : " + string.Format(new CultureInfo("en-US"), "{0:s}", today));

      // o : Round-trip 패턴
      Console.WriteLine("o : " + string.Format("{0:o}", today));
      //Console.WriteLine("o : " + string.Format(new CultureInfo("en-US"), "{0:o}", today));

      // r : Round-trip 패턴
      Console.WriteLine("r : " + string.Format("{0:r}", today));
      //Console.WriteLine("r : " + string.Format(new CultureInfo("en-US"), "{0:r}", today));

      // u : 로칼시간을 UTC로 변환하여 출력
      Console.WriteLine("u : " + string.Format("{0:u}", today));
      
      DateTime utcNow = DateTime.UtcNow;
      DateTime utcTime = DateTime.Now.ToUniversalTime();
      Console.WriteLine("UTC : " + utcNow.ToString("o"));
      Console.WriteLine("UTC : " + utcTime.ToString("o"));
    }
  }
}
