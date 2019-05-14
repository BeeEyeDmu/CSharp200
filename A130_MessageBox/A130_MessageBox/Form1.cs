using System;
using System.Windows.Forms;

namespace A130_MessageBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // The simplest overload of MessageBox.Show.
      MessageBox.Show("가장 간단한 메시지박스입니다.");

      // Dialog box with text and a title.
      MessageBox.Show("타이틀을 갖는 메시지박스입니다.",
          "Title Message");

      // Dialog box with two buttons: yes and no.
      DialogResult result1 = MessageBox.Show("두개의 버튼을 갖는 메시지박스입니다.",
          "Question", 
          MessageBoxButtons.YesNo);

      // Dialog box with question icon.
      DialogResult result2 = MessageBox.Show("세개의 버튼과 물음표 아이콘을 보여주는 메시지박스입니다.",
          "Question", 
          MessageBoxButtons.YesNoCancel, 
          MessageBoxIcon.Question);

      // Dialog box with question icon and default button.
      DialogResult result3 = MessageBox.Show("디폴트 버튼을 두 번째 버튼으로 \n지정한 메시지박스입니다.",
          "Question",
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2);

      string msg = string.Format("당신의 선택 : {0} {1} {2}", 
        result1.ToString(), result2.ToString(), result3.ToString());
      MessageBox.Show(msg, "Your Selections");

      // Dialog box with exclamation icon.
      MessageBox.Show("느낌표와 알람 메시지박스입니다.",
          "느낌표와 알람 소리",
          MessageBoxButtons.OK,
          MessageBoxIcon.Exclamation);
          //,
          //MessageBoxDefaultButton.Button1);
    }
  }
}
