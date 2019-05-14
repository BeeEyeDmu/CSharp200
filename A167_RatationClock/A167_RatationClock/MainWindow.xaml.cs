using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A167_RatationClock
{
  public partial class MainWindow : Window
  {
    // 시침, 분침, 초침의 각도(12시 방향 기준, 시계방향)
    private double hourDeg;
    private double secDeg;
    private double minDeg;

    public MainWindow()
    {
      InitializeComponent();

      //시계판을 그린다(눈금을 그린다)
      DrawFace();

      //시계바늘을 만든다
      MakeClockHands();

      // 타이머 세팅
      DispatcherTimer dt = new DispatcherTimer();
      dt.Interval = new TimeSpan(0, 0, 0, 0, 10); // 10ms      
      dt.Tick += Dt_Tick;   //dt.Tick += new EventHandler(Dt_Tick);
      dt.Start();

    }

    // 시계판을 그린다
    private void DrawFace()
    {
      // 눈금 60개를 Line 배렬로 만든다
      Line[] marking = new Line[60];
      int W = 300;  // width of Clock

      for (int i = 0; i < 60; i++)
      {
        marking[i] = new Line();
        marking[i].Stroke = Brushes.LightSteelBlue;
        marking[i].X1 = W / 2; marking[i].Y1 = 2;
        marking[i].X2 = W / 2;
        if (i % 5 == 0)       // 매 5번째 눈금은 큰 눈금으로 한다
        {
          marking[i].StrokeThickness = 5;
          marking[i].Y2 = 20;
        }
        else
        {
          marking[i].StrokeThickness = 2;
          marking[i].Y2 = 10;
        }

        // 눈금 하나당 중심점을 기준으로 6도씩 회전(RotationTransform)
        RotateTransform rt = new RotateTransform(6 * i);
        rt.CenterX = 150; // 회전 중심점
        rt.CenterY = 150; // 회전 중심점
        marking[i].RenderTransform = rt;
        aClock.Children.Add(marking[i]);
      }
    }

    private void MakeClockHands()
    {
      int W = 300;  // width of Clock
      int H = 300;  // Height of Clock

      secHand.X1 = W / 2;
      secHand.Y1 = H / 2;
      secHand.X2 = W / 2;
      secHand.Y2 = 20;

      minHand.X1 = W / 2;
      minHand.Y1 = H / 2;
      minHand.X2 = W / 2;
      minHand.Y2 = 40;

      hourHand.X1 = W / 2;
      hourHand.Y1 = H / 2;
      hourHand.X2 = W / 2;
      hourHand.Y2 = 60;
    }

    private void Dt_Tick(object sender, EventArgs e)
    {
      DateTime currentTime = DateTime.Now;

      int hour = currentTime.Hour;
      int min = currentTime.Minute;
      int sec = currentTime.Second;
      hourDeg = hour % 12 * 30 + min * 0.5;
      minDeg = min * 6;
      secDeg = sec * 6;

      // 시계바늘을 Remove & Add
      aClock.Children.Remove(hourHand);
      RotateTransform hourRt = new RotateTransform(hourDeg);
      hourRt.CenterX = hourHand.X1;
      hourRt.CenterY = hourHand.Y1;
      hourHand.RenderTransform = hourRt;
      aClock.Children.Add(hourHand);

      aClock.Children.Remove(minHand);
      RotateTransform minRt = new RotateTransform(minDeg);
      minRt.CenterX = minHand.X1;
      minRt.CenterY = minHand.Y1;
      minHand.RenderTransform = minRt;
      aClock.Children.Add(minHand);

      aClock.Children.Remove(secHand);
      RotateTransform secRt = new RotateTransform(secDeg);
      secRt.CenterX = secHand.X1;
      secRt.CenterY = secHand.Y1;
      secHand.RenderTransform = secRt;
      aClock.Children.Add(secHand);

      // 배꼽
      aClock.Children.Remove(center);
      aClock.Children.Add(center);
    }
  }
}
