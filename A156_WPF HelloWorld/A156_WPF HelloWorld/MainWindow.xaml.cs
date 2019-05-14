using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace A156_WPF_HelloWorld
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void label1_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if (label1.Foreground != Brushes.White)
      {
        label1.Foreground = Brushes.White;
        this.Background = Brushes.Blue;
      }
      else
      {
        label1.Foreground = SystemColors.WindowTextBrush;
        this.Background = SystemColors.WindowBrush;
      }
    }
  }
}
