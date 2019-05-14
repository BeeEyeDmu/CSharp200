using System;
using System.Windows;
using System.Windows.Threading;

namespace A164_WPF_DigitalClock
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      DispatcherTimer timer = new DispatcherTimer();
      timer.Interval = new TimeSpan(0, 0, 1);
      timer.Tick += Timer_Tick;
      timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      dClock.Text = DateTime.Now.ToString();
    }
  }
}
