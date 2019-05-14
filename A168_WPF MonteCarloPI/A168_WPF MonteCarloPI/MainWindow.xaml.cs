using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A168_WPF_MonteCarloPI
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    int iCnt = 0;
    int oCnt = 0;
    
    DispatcherTimer timer = new DispatcherTimer();
    Random r = new Random();

    public MainWindow()
    {
      InitializeComponent();

      timer.Interval = new TimeSpan(10);  // 1ms
      timer.Tick += Timer_Tick;
      timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      Rectangle rect = new Rectangle();
      rect.Width = 1;
      rect.Height = 1;

      int x = r.Next(0, 400);
      int y = r.Next(0, 400);

      if ((x - 200) * (x - 200) + (y - 200) * (y - 200) <= 40000)
      {
        rect.Stroke = Brushes.Red;
        iCnt++;
      }
      else
      {
        rect.Stroke = Brushes.Blue;
        oCnt++;
      }
      int count = iCnt + oCnt;
      double pi = (double)iCnt / count * 4;
      txtStatus.Text = "n = " + count + ", In: " + iCnt + ", Out: " + oCnt + ", PI = " + pi;
      Canvas.SetLeft(rect, x);
      Canvas.SetTop(rect, y);
      canvas1.Children.Add(rect);
    }
  }
}
