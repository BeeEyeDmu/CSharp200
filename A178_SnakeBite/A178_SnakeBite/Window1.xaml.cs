using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading; // timer
using System.Diagnostics;   // StopWatch

namespace A178_SnakeBite
{
  public partial class Window1 : Window
  {
    Random r = new Random();

    Ellipse[] A178_SnakeBites = new Ellipse[30];
    Ellipse egg = new Ellipse();
    private int size = 12;      // Egg와 Body의 사이즈
    private int visibleCount = 5;
    private string move = "";
    private int eaten = 0;
    DispatcherTimer timer = new DispatcherTimer();
    Stopwatch sw = new Stopwatch();
    private bool startFlag = false;

    public Window1()
    {
      InitializeComponent();
      InitA178_SnakeBite();
      InitEgg();

      timer.Interval = new TimeSpan(0, 0, 0, 0, 100); // 0.1초 마다
      timer.Tick += timer_Tick;
      timer.Start();
    }

    void timer_Tick(object sender, EventArgs e)
    {
      if (move != "")
      {
        startFlag = true;

        for (int i = visibleCount; i >= 1; i--)     // 꼬리 하나를 더 계산해 둔다
        {
          Point p = (Point)A178_SnakeBites[i - 1].Tag;
          A178_SnakeBites[i].Tag = new Point(p.X, p.Y);
        }

        Point pnt = (Point)A178_SnakeBites[0].Tag;
        if (move == "Right")
          A178_SnakeBites[0].Tag = new Point(pnt.X + size, pnt.Y);
        else if (move == "Left")
          A178_SnakeBites[0].Tag = new Point(pnt.X - size, pnt.Y);
        else if (move == "Up")
          A178_SnakeBites[0].Tag = new Point(pnt.X, pnt.Y - size);
        else if (move == "Down")
          A178_SnakeBites[0].Tag = new Point(pnt.X, pnt.Y + size);

        EatEgg();   // 알을 먹었는지 체크
      }

      if (startFlag == true)
      {
        TimeSpan ts = sw.Elapsed;
        time.Text = String.Format("Time = {0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        DrawA178_SnakeBites();
      }
    }

    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
      if (move == "")  // 맨 처음 키가 눌렸을 때 sw 시작
        sw.Start();

      if (e.Key == Key.Right)
        move = "Right";
      else if (e.Key == Key.Left)
        move = "Left";
      else if (e.Key == Key.Up)
        move = "Up";
      else if (e.Key == Key.Down)
        move = "Down";
      else if (e.Key == Key.Escape)
        move = "";
    }

    private void EatEgg()
    {
      Point pS = (Point)A178_SnakeBites[0].Tag;
      Point pE = (Point)egg.Tag;

      if (pS.X == pE.X && pS.Y == pE.Y)
      {
        egg.Visibility = Visibility.Hidden;
        visibleCount++;
        A178_SnakeBites[visibleCount - 1].Visibility = Visibility.Visible;   // 꼬리를 하나 늘림
        score.Text = "Eggs = " + (++eaten).ToString();

        if (visibleCount == 30)
        {
          timer.Stop();
          sw.Stop();
          DrawA178_SnakeBites();
          TimeSpan ts = sw.Elapsed;
          string TimeElapsed = String.Format("Time = {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
          MessageBox.Show("Success!!!  " + TimeElapsed + " sec");
          this.Close();
        }

        Point p = new Point(r.Next(1, 480 / size) * size, r.Next(1, 380 / size) * size);
        egg.Tag = p;
        egg.Visibility = Visibility.Visible;
        Canvas.SetLeft(egg, p.X);
        Canvas.SetTop(egg, p.Y);
      }
    }

    private void DrawA178_SnakeBites()
    {
      for (int i = 0; i < visibleCount; i++)
      {
        Point p = (Point)A178_SnakeBites[i].Tag;
        Canvas.SetLeft(A178_SnakeBites[i], p.X);
        Canvas.SetTop(A178_SnakeBites[i], p.Y);
      }
    }

    private void InitEgg()
    {
      egg = new Ellipse();
      egg.Tag = new Point(r.Next(1, 480 / size) * size, r.Next(1, 380 / size) * size);
      egg.Width = size;
      egg.Height = size;
      egg.Stroke = Brushes.Black;
      egg.Fill = Brushes.Red;

      Point p = (Point)egg.Tag;
      Canvas1.Children.Add(egg);
      Canvas.SetLeft(egg, p.X);
      Canvas.SetTop(egg, p.Y);
    }

    private void InitA178_SnakeBite()
    {
      int x = r.Next(1, 480 / size) * size;
      int y = r.Next(1, 380 / size) * size;

      for (int i = 0; i < 30; i++)
      {
        A178_SnakeBites[i] = new Ellipse();
        A178_SnakeBites[i].Width = size;
        A178_SnakeBites[i].Height = size;
        if (i == 0)
          A178_SnakeBites[i].Fill = Brushes.Chocolate; // 머리와 5번째 마디마다 색깔 변경
        else if (i % 5 == 0)
          A178_SnakeBites[i].Fill = Brushes.YellowGreen; // 5번째 마디마다 색깔 변경
        else
          A178_SnakeBites[i].Fill = Brushes.Gold;
        A178_SnakeBites[i].Stroke = Brushes.Black;
        Canvas1.Children.Add(A178_SnakeBites[i]);
      }

      for (int i = visibleCount; i < 30; i++)
      {
        A178_SnakeBites[i].Visibility = Visibility.Hidden;
      }

      CreateA178_SnakeBite(x, y);
    }

    private void CreateA178_SnakeBite(int x, int y)
    {
      for (int i = 0; i < visibleCount; i++)
      {
        A178_SnakeBites[i].Tag = new Point(x, y + i * size);
        Canvas.SetLeft(A178_SnakeBites[i], x);
        Canvas.SetTop(A178_SnakeBites[i], y + i * size);
      }
    }
  }
}
