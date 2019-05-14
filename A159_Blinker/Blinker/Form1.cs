using System;
using System.Drawing;
using System.Windows.Forms;

namespace Blinker
{
  public partial class Form1 : Form
  {
    Timer t;

    public Form1()
    {
      InitializeComponent();
      t = new Timer();
      t.Interval = 500;
      t.Tick += T_Tick;
    }

    private void T_Tick(object sender, EventArgs e)
    {
      if(btnRed.BackColor == Color.Red)
      {
        btnRed.BackColor = DefaultBackColor;
        btnGreen.BackColor = Color.Green;
      }
      else
      {
        btnRed.BackColor = Color.Red;
        btnGreen.BackColor = DefaultBackColor;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      btnRed.BackColor = Color.Red;
      btnGreen.BackColor = Color.Green;
    }

    private void btnGreen_Click(object sender, EventArgs e)
    {
      t.Start();
    }

    private void btnRed_Click(object sender, EventArgs e)
    {
      t.Stop();
    }
  }
}
