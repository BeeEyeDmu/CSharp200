using System;
using System.Drawing;
using System.Windows.Forms;

namespace A154_Menu
{
  public partial class Form1 : Form
  {
    Timer t = new Timer();

    public Form1()
    {
      InitializeComponent();

      lblTime.Text = "";
      lblTime.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
      t.Interval = 1000;
      t.Tick += T_Tick;
      t.Start();
    }

    private void T_Tick(object sender, EventArgs e)
    {
      lblTime.Location = new Point(this.ClientSize.Width / 2 - lblTime.Width / 2,
        this.ClientSize.Height / 2 - lblTime.Height / 2);
      lblTime.Text = DateTime.Now.ToString();
    }

    private void 폰트ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FontDialog fDlg = new FontDialog();

      fDlg.ShowColor = true;
      fDlg.ShowEffects = true;
      fDlg.Font = lblTime.Font;
      fDlg.Color = lblTime.ForeColor;

      if(fDlg.ShowDialog() == DialogResult.OK)
      {
        lblTime.Font = fDlg.Font;
        lblTime.ForeColor = fDlg.Color;
      }
    }

    private void 배경색ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ColorDialog cDlg = new ColorDialog();
      if (cDlg.ShowDialog() == DialogResult.OK)
      {
        this.BackColor = cDlg.Color;
      }
    }

    private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
