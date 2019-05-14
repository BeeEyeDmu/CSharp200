using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace WPF_Blinker
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    DispatcherTimer t = new DispatcherTimer();
    public MainWindow()
    {
      InitializeComponent();
      t.Interval = new TimeSpan(5000000); // 단위 Tick
      t.Tick += T_Tick;
    }

    private void T_Tick(object sender, EventArgs e)
    {
      if(btnRed.Background == Brushes.Red)
      {
        btnRed.ClearValue(Button.BackgroundProperty);
        btnGreen.Background = Brushes.Green;
      }
      else
      {
        btnGreen.ClearValue(Button.BackgroundProperty);
        btnRed.Background = Brushes.Red;
      }
    }

    private void btnGreen_Click(object sender, RoutedEventArgs e)
    {
      t.Start();
    }

    private void btnRed_Click(object sender, RoutedEventArgs e)
    {
      t.Stop();
    }
  }
}
