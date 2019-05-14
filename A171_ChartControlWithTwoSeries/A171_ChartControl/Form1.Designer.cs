namespace A171_ChartControl
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.btnTwoChartArea = new System.Windows.Forms.Button();
      this.btnOneChartArea = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(0, 0);
      this.chart1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(1028, 457);
      this.chart1.TabIndex = 0;
      this.chart1.Text = "chart1";
      // 
      // btnTwoChartArea
      // 
      this.btnTwoChartArea.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnTwoChartArea.Location = new System.Drawing.Point(545, 466);
      this.btnTwoChartArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnTwoChartArea.Name = "btnTwoChartArea";
      this.btnTwoChartArea.Size = new System.Drawing.Size(138, 52);
      this.btnTwoChartArea.TabIndex = 1;
      this.btnTwoChartArea.Text = "나누어 그리기";
      this.btnTwoChartArea.UseVisualStyleBackColor = true;
      this.btnTwoChartArea.Click += new System.EventHandler(this.btnTwoChartArea_Click);
      // 
      // btnOneChartArea
      // 
      this.btnOneChartArea.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnOneChartArea.Location = new System.Drawing.Point(277, 466);
      this.btnOneChartArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnOneChartArea.Name = "btnOneChartArea";
      this.btnOneChartArea.Size = new System.Drawing.Size(138, 52);
      this.btnOneChartArea.TabIndex = 2;
      this.btnOneChartArea.Text = "합쳐서 그리기";
      this.btnOneChartArea.UseVisualStyleBackColor = true;
      this.btnOneChartArea.Click += new System.EventHandler(this.btnOneChartArea_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1028, 545);
      this.Controls.Add(this.btnOneChartArea);
      this.Controls.Add(this.btnTwoChartArea);
      this.Controls.Add(this.chart1);
      this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.Name = "Form1";
      this.Text = "Using Chart Control";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Button btnTwoChartArea;
    private System.Windows.Forms.Button btnOneChartArea;
  }
}

