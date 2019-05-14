using System;
using System.Drawing;
using System.Windows.Forms;

namespace A165_WinForm_AnalogClock
{
  public partial class Form1 : Form
  {
    Graphics g;             // Graphics 객체
    private Point center;   // 중심점
    private double radius;  // 반지름
    private int hourHand;   // 시침의 길이
    private int minHand;    // 분침의 길이
    private int secHand;    // 초침의 길이
    private Timer timer1;    // 타이머
    private const int clientSize = 300; // clientSize
    private const int clockSize = 200;  // 시계 판의 지름

    public Form1()
    {
      InitializeComponent();

      this.ClientSize = new Size(clientSize, clientSize);
      this.Text = "Analog Clock";
      panel1.BackColor = Color.WhiteSmoke;
      this.Padding = new Padding(10);

      g = panel1.CreateGraphics();

      aClockSetting();  // 아날로그 클럭 세팅
      TimerSetting();   // 타이머 세팅
    }

    private void aClockSetting()
    {
      center = new Point(panel1.Width / 2, panel1.Height / 2);
      radius = panel1.Height / 2;

      hourHand = (int)(radius * 0.45);
      minHand = (int)(radius * 0.55);
      secHand = (int)(radius * 0.65);
    }

    private void TimerSetting()
    {
      timer1 = new Timer();
      timer1.Interval = 1000;     // 1초에 한번씩
      timer1.Tick += Timer1_Tick;
      timer1.Start();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      DateTime c = DateTime.Now;   // 현재시간

      panel1.Refresh();

      DrawClockFace(); //시계판 그리기

      // 시침, 분침, 초침의 각도(단위: 라디안)
      double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
      double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
      double radSec = (c.Second) * 6 * Math.PI / 180;

      DrawHands(radHr, radMin, radSec); // 바늘 그리기
    }

    private void DrawClockFace()
    {
      Pen pen = new Pen(Brushes.LightSteelBlue, 30);
      g.DrawEllipse(pen, center.X - clockSize/2, center.Y - clockSize/2, clockSize, clockSize);
    }

    private void DrawHands(double radHr, double radMin, double radSec)
    {
      // 시침
      DrawLine((int)(hourHand * Math.Sin(radHr)), (int)(-hourHand * Math.Cos(radHr)),
          0, 0, Brushes.RoyalBlue, 8, center.X, center.Y);
      // 분침
      DrawLine((int)(minHand * Math.Sin(radMin)), (int)(-minHand * Math.Cos(radMin)),
          0, 0, Brushes.SkyBlue, 6, center.X, center.Y);
      // 초침
      DrawLine((int)(secHand * Math.Sin(radSec)), (int)(-secHand * Math.Cos(radSec)),
          0, 0, Brushes.OrangeRed, 3, center.X, center.Y);

      // 배꼽
      int coreSize = 16;
      Rectangle r = new Rectangle(center.X - coreSize / 2, center.Y - coreSize / 2, coreSize, coreSize);
      g.FillEllipse(Brushes.Gold, r);
      Pen p = new Pen(Brushes.DarkRed, 3);
      g.DrawEllipse(p, r);
    }

    private void DrawLine(int x1, int y1, int x2, int y2, Brush color, int thick, int Cx, int Cy)
    {
      Pen pen = new Pen(color, thick);
      pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
      pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
      g.DrawLine(pen, x1 + Cx, y1 + Cy, x2 + Cx, y2 + Cy);
    }
  }
}
