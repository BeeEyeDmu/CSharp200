using System.Windows;
using System.Windows.Forms;

namespace A169_UsingWFControlInWPF
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

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.InitialDirectory = @"C:\Users\bikang\Pictures";
      ofd.Multiselect = true;
      var result = ofd.ShowDialog();
      if(result == System.Windows.Forms.DialogResult.OK)
      {
        foreach (var s in ofd.FileNames)
        {
          lbFiles.Items.Add(s);
        }
      }
    }
  }
}
