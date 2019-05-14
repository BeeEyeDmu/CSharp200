using System;
using System.Drawing;
using System.Windows.Forms;

namespace A175_ImageViewer
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.Text = "ImageViewer";
      pictureBox1.BackColor = Color.White;
    }

    private void 이미지선택ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      openFileDialog1.Filter = "이미지 파일(.jpg)|*.jpg|모든 파일(*.*)|*.*";
      openFileDialog1.Title = "이미지 열기";
      openFileDialog1.FileName = "";
      openFileDialog1.ShowDialog();
      if (openFileDialog1.FileName != "")
      {
        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
      }
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void normalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
    }

    private void stretchImageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void autoSizeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    }

    private void centerImageToolStripMenuItem_Click(object sender, EventArgs e)
    {
      pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    }

    private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
    {
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
