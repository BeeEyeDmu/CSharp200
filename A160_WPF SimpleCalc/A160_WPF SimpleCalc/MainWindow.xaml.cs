using System.Windows;
using System.Windows.Controls;

namespace A160_WPF_SimpleCalc
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    private bool newButton;
    private double savedValue;
    private char myOperator;

    public MainWindow()
    {
      InitializeComponent();
    }

    // 숫자 버튼의 처리
    private void btn_Click(object sender, RoutedEventArgs e)
    {
      Button btn = sender as Button;
      string number = btn.Content.ToString();
      if (txtResult.Text == "0" || newButton == true)
      {
        txtResult.Text = number;
        newButton = false;
      }
      else
        txtResult.Text = txtResult.Text + number;
    }

    // operator 4개에 대한 함수를 하나로 쓸 수 있다
    private void btnOp_Click(object sender, RoutedEventArgs e)
    {
      Button btn = sender as Button;

      savedValue = double.Parse(txtResult.Text);// string의 첫번째 요소 값
      myOperator = btn.Content.ToString()[0];
      newButton = true;
    }

    private void Dot_Click(object sender, RoutedEventArgs e)
    {
      if (txtResult.Text.Contains(".") == false)
        txtResult.Text += ".";
    }

    private void Equal_Click(object sender, RoutedEventArgs e)
    {
      if (myOperator == '+')
        txtResult.Text = (savedValue + double.Parse(txtResult.Text)).ToString();
      else if (myOperator == '-')
        txtResult.Text = (savedValue - double.Parse(txtResult.Text)).ToString();
      else if (myOperator == '×')
        txtResult.Text = (savedValue * double.Parse(txtResult.Text)).ToString();
      else if (myOperator == '÷')
        txtResult.Text = (savedValue / double.Parse(txtResult.Text)).ToString();
    }
  }
}
