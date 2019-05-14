using System.Windows;

namespace A178_SnakeBite
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }
    private void button1_Click(object sender, RoutedEventArgs e)
    {
      Window1 w = new Window1();
      w.Show();
    }
    private void button2_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
