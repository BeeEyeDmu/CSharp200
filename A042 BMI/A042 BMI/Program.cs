using System;

namespace A042_BMI
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("키를 입력하세요(cm) : ");
      double height = double.Parse(Console.ReadLine());
      height /= 100;  // m 단위

      Console.Write("체중을 입력하세요(kg) : ");
      double weight = double.Parse(Console.ReadLine());
      double bmi = weight / (height * height);

      /*
        BMI < 20, 저체중
        20 <= BMI < 25, 정상체중
        25 <= BMI < 30, 경도비만
        30 <= BMI < 40, 비만
        BMI >= 40, 고도비만
      */
      string comment = null;
      if (bmi < 20)
        comment = "저체중";
      else if (bmi < 25)
        comment = "정상체중";
      else if (bmi < 30)
        comment = "경도비만";
      else if (bmi < 40)
        comment = "비만";
      else
        comment = "고도비만";

      Console.WriteLine("BMI={0:F1}, \"{1}\"입니다", bmi, comment);
    }
  }
}
