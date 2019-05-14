using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace A171_ChartControl
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      this.Text = "Using Chart Control";
    }
    /*
    protected override void OnPaint(PaintEventArgs e)
    {
      // Data arrays.
      string[] seriesArray = { "사과", "배", "딸기", "오렌지" };
      int[] pointsArray = { 15, 30, 50, 14 };

      // Set palette.
      //chart1.Palette = ChartColorPalette.SeaGreen;

      // Set title.
      chart1.Titles.Add("과일");

      chart1.Series.Clear();      

      // Add series.
      for (int i = 0; i < seriesArray.Length; i++)
      {
        // Add series.
        Series series = chart1.Series.Add(seriesArray[i]);
        series.ChartType = SeriesChartType.Column;

        // Add point.
        series.Points.Add(pointsArray[i]);
      }
    }

    private void btnChart_Click(object sender, EventArgs e)
    {
      chart1.Series.Clear();
      chart1.Series.Add("Graph");
      chart1.Series["Graph"].Points.Clear();
      chart1.Series["Graph"].Points.Add(100);  // X=1
      chart1.Series["Graph"].Points.Add(200);  // X=2
      chart1.Series["Graph"].Points.Add(300);
      chart1.Series["Graph"].Points.Add(400);
    }

    private void btnChart2_Click(object sender, EventArgs e)
    {
      chart1.Series.Clear();
      chart1.Series.Add("Graph");
      chart1.Series["Graph"].Points.AddXY(10, 100);
      chart1.Series["Graph"].Points.AddXY(20, 400);
      chart1.Series["Graph"].Points.AddXY(30, 300);
      chart1.Series["Graph"].Points.AddXY(40, 200);
    }

    private void btnChart3_Click(object sender, EventArgs e)
    {    
      // Data arrays.
      string[] seriesArray = { "사과", "배", "딸기", "오렌지" };
      int[] pointsArray = { 15, 30, 50, 14 };

      // Set palette.
      chart1.Palette = ChartColorPalette.SeaGreen;

      // Set title.
      chart1.Titles.Add("과일");

      chart1.Series.Clear();

      // Add series.
      for (int i = 0; i < seriesArray.Length; i++)
      {
        // Add series.
        Series series = chart1.Series.Add(seriesArray[i]);        

        // Add point.
        series.Points.Add(pointsArray[i]);
      }
    }        
    */
    private void Form1_Load(object sender, EventArgs e)
    {
      chart1.Titles.Add("중간고사 성적");
      chart1.Series.Add("Series2");
      chart1.Series["Series1"].LegendText = "수학";
      chart1.Series["Series2"].LegendText = "영어";

      chart1.ChartAreas.Add("ChartArea2");
      chart1.Series["Series2"].ChartArea = "ChartArea2";

      Random r = new Random();
      for(int i=0; i<10; i++)
      {
        chart1.Series["Series1"].Points.AddXY(i, r.Next(100));
        chart1.Series["Series2"].Points.AddXY(i, r.Next(100));
      }
    }

    private void btnOneChartArea_Click(object sender, EventArgs e)
    {
      chart1.ChartAreas.RemoveAt(chart1.ChartAreas.IndexOf("ChartArea2"));
      chart1.Series["Series2"].ChartArea = "ChartArea1";
    }

    private void btnTwoChartArea_Click(object sender, EventArgs e)
    {
      chart1.ChartAreas.Add("ChartArea2");
      chart1.Series["Series2"].ChartArea = "ChartArea2";
    }
  }
}
