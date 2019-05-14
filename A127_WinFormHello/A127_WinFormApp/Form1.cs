using System;
using System.Windows.Forms;

namespace A127_WinFormApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      label1.Text = "";
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      label1.Text = "Hello! Windows Forms Application!";
    }
  }
}
