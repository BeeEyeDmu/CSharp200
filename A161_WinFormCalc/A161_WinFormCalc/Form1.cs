using System;
using System.Windows.Forms;

namespace A161_WinFormCalc
{
  public partial class Form1 : Form
  {
    private double saved;         // txtResult에 있는 값을 저장
    private char op = '\0';       // 현재 계산할 Operator
    private bool opFlag = false;  // 연산자를 누른 후인지 체크하는 flag
    private double memory;        // 메모리에 저장된 값
    private bool memFlag;         // 메모리 버튼을 누른 후인지 체크
    private bool percentFlag;    // % 처리를 위한 flag

    public Form1()
    {
      InitializeComponent();

      btnMC.Enabled = false;
      btnMR.Enabled = false;
    }

    // 소수점 처리
    private void btnDot_Click(object sender, EventArgs e)
    {
      if (txtResult.Text.Contains("."))
        return;
      else
        txtResult.Text += ".";
    }

    // 모든 숫자 버튼을 하나로 처리하는 메소드
    private void btn_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      string s = btn.Text;

      if (txtResult.Text == "0" || opFlag == true || memFlag == true)
      {
        txtResult.Text = s;
        opFlag = false;
        memFlag = false;
      }
      else
        txtResult.Text = txtResult.Text + s;  // txtResult.Text += "1";

      txtResult.Text = GroupSeparator(txtResult.Text);
    }

    // +, -, ×, ÷ 버튼
    private void btnOP_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;

      saved = Double.Parse(txtResult.Text);
      txtExp.Text += txtResult.Text + " " + btn.Text + " ";
      op = btn.Text[0];
      opFlag = true;
      percentFlag = true;
    }

    // = 버튼, 계산수행
    private void btnEqual_Click(object sender, EventArgs e)
    {
      Double value = Double.Parse(txtResult.Text);
      switch (op)
      {
        case '＋':
          txtResult.Text = (saved + value).ToString();
          break;
        case '－':
          txtResult.Text = (saved - value).ToString();
          break;
        case '×':
          txtResult.Text = (saved * value).ToString();
          break;
        case '÷':
          txtResult.Text = (saved / value).ToString();
          break;
      }
      txtResult.Text = GroupSeparator(txtResult.Text);
      txtExp.Text = "";
    }

    // 정수부분 세 자리씩 콤마(,) 삽입
    private string GroupSeparator(string s)
    {
      int pos = 0;
      double v = Double.Parse(s);

      if (s.Contains("."))
      {
        pos = s.Length - s.IndexOf('.');
        if (pos == 1)   // 맨 뒤에 소수점이 있으면 그대로 리턴
          return s;
        string formatStr = "{0:N" + (pos - 1) + "}";
        s = string.Format(formatStr, v);
      }
      else
        s = string.Format("{0:N0}", v);
      return s;
    }

    // 제곱근
    private void btnSqrt_Click(object sender, EventArgs e)
    {
      txtExp.Text = "√(" + txtResult.Text + ") ";
      txtResult.Text =
        Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
      txtResult.Text = GroupSeparator(txtResult.Text);
    }

    // 제곱
    private void btnSqr_Click(object sender, EventArgs e)
    {
      txtExp.Text = "sqr(" + txtResult.Text + ") ";
      txtResult.Text = (Double.Parse(txtResult.Text) *
        Double.Parse(txtResult.Text)).ToString();
      txtResult.Text = GroupSeparator(txtResult.Text);
    }

    // 역수
    private void btnRecip_Click(object sender, EventArgs e)
    {
      txtExp.Text = "1 / (" + txtResult.Text + ") ";
      txtResult.Text = (1 / Double.Parse(txtResult.Text)).ToString();
      txtResult.Text = GroupSeparator(txtResult.Text);
    }

    // 부호
    private void btnPlusMinus_Click(object sender, EventArgs e)
    {
      double v = Double.Parse(txtResult.Text);
      txtResult.Text = (-v).ToString();
      txtResult.Text = GroupSeparator(txtResult.Text);
    }

    // % 버튼
    private void btnPercent_Click(object sender, EventArgs e)
    {
      if (percentFlag == true)
      {
        double p = Double.Parse(txtResult.Text);
        p = saved * p / 100.0;
        txtResult.Text = p.ToString();
        txtExp.Text += txtResult.Text;
        percentFlag = false;
      }
    }

    // Memory Save
    private void btnMS_Click(object sender, EventArgs e)
    {
      memory = Double.Parse(txtResult.Text);
      btnMC.Enabled = true;
      btnMR.Enabled = true;
      memFlag = true;
    }

    // Memory Read
    private void btnMR_Click(object sender, EventArgs e)
    {
      txtResult.Text = memory.ToString();
      memFlag = true;
      txtResult.Text = GroupSeparator(txtResult.Text);
    }

    // Memory Clear
    private void btnMC_Click(object sender, EventArgs e)
    {
      txtResult.Text = "0";
      memory = 0;
      btnMR.Enabled = false;
      btnMC.Enabled = false;
    }

    // M+
    private void btnMPlus_Click(object sender, EventArgs e)
    {
      memory += Double.Parse(txtResult.Text);
    }

    // M-
    private void btnMMinus_Click(object sender, EventArgs e)
    {
      memory -= Double.Parse(txtResult.Text);
    }

    // 지금 txtResult에 있는 값을 0으로
    private void btnCE_Click(object sender, EventArgs e)
    {
      txtResult.Text = "0";
    }

    // 초기화
    private void btnC_Click(object sender, EventArgs e)
    {
      txtResult.Text = "0";
      txtExp.Text = "";
      saved = 0;
      op = '\0';
      opFlag = false;
      percentFlag = false;
    }

    // 맨 뒤의 한 글자 지우기
    private void btnDelete_Click(object sender, EventArgs e)
    {
      txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
      if (txtResult.Text.Length == 0)
        txtResult.Text = "0";
    }
  }
}
