using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A148_TrackBarNProgressBar
{
  public partial class Form1 : Form
  {
    Timer timer1 = new Timer(); 

    public Form1()
    {
      InitializeComponent();

      //this.BackColor = Color.White;
      timer1.Interval = 100;  // 0.1초
      timer1.Tick += Timer1_Tick;

      trackBar1.Minimum = 0;
      trackBar1.Maximum = 100;
      trackBar1.Value = 0;

      progressBar1.Minimum = 0;
      progressBar1.Maximum = 100;
      progressBar1.Value = 0;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (trackBar1.Value < 100)
      {
        trackBar1.Value++;
        progressBar1.Value++;
        lblTrack.Text = trackBar1.Value.ToString();
        lblProgress.Text = progressBar1.Value.ToString();
      }
      else
      {
        timer1.Stop();
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      timer1.Start();
    }
  }
}
