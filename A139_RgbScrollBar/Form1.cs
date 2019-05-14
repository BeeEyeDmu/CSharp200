using System;
using System.Drawing;
using System.Windows.Forms;

namespace A139_RgbScrollBar
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      this.BackColor = Color.LightSteelBlue;
      panel1.BackColor = Color.FromArgb(0, 0, 0);
      txtR.Text = 0.ToString();
      txtG.Text = 0.ToString();
      txtB.Text = 0.ToString();
      scrR.Maximum = 255 + 9;
      scrG.Maximum = 255 + 9;
      scrB.Maximum = 255 + 9;
    }

    private void scrR_Scroll(object sender, ScrollEventArgs e)
    {
      txtR.Text = scrR.Value.ToString();
      panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
    }

    private void scrG_Scroll(object sender, ScrollEventArgs e)
    {
      txtG.Text = scrG.Value.ToString();
      panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
    }

    private void scrB_Scroll(object sender, ScrollEventArgs e)
    {
      txtB.Text = scrB.Value.ToString();
      panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
    }

    private void txtR_TextChanged(object sender, EventArgs e)
    {
      if (txtR.Text != "")
      {
        scrR.Value = int.Parse(txtR.Text);
        panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
      }
    }

    private void txtG_TextChanged(object sender, EventArgs e)
    {
      if (txtG.Text != "")
      {
        scrG.Value = int.Parse(txtG.Text);
        panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
      }
    }

    private void txtB_TextChanged(object sender, EventArgs e)
    {
      if (txtB.Text != "")
      {
        scrB.Value = int.Parse(txtB.Text);
        panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
      }
    }
  }
}
