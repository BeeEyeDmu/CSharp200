namespace A197_ArduinoSensorMonitoring
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.읽어오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.시뮬레이션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.끝ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnZoom = new System.Windows.Forms.Button();
      this.btnViewAll = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.btnPortValue = new System.Windows.Forms.Button();
      this.btnConnect = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.menuStrip1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.시뮬레이션ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(507, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.읽어오기ToolStripMenuItem});
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 저장ToolStripMenuItem
      // 
      this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
      this.저장ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.저장ToolStripMenuItem.Text = "저장하기";
      // 
      // 읽어오기ToolStripMenuItem
      // 
      this.읽어오기ToolStripMenuItem.Name = "읽어오기ToolStripMenuItem";
      this.읽어오기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.읽어오기ToolStripMenuItem.Text = "읽어오기";
      // 
      // 시뮬레이션ToolStripMenuItem
      // 
      this.시뮬레이션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.시작ToolStripMenuItem,
            this.끝ToolStripMenuItem});
      this.시뮬레이션ToolStripMenuItem.Name = "시뮬레이션ToolStripMenuItem";
      this.시뮬레이션ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
      this.시뮬레이션ToolStripMenuItem.Text = "시뮬레이션";
      // 
      // 시작ToolStripMenuItem
      // 
      this.시작ToolStripMenuItem.Name = "시작ToolStripMenuItem";
      this.시작ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.시작ToolStripMenuItem.Text = "시작";
      this.시작ToolStripMenuItem.Click += new System.EventHandler(this.시작ToolStripMenuItem_Click);
      // 
      // 끝ToolStripMenuItem
      // 
      this.끝ToolStripMenuItem.Name = "끝ToolStripMenuItem";
      this.끝ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.끝ToolStripMenuItem.Text = "끝";
      this.끝ToolStripMenuItem.Click += new System.EventHandler(this.끝ToolStripMenuItem_Click);
      // 
      // btnZoom
      // 
      this.btnZoom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnZoom.Location = new System.Drawing.Point(257, 575);
      this.btnZoom.Name = "btnZoom";
      this.btnZoom.Size = new System.Drawing.Size(65, 29);
      this.btnZoom.TabIndex = 22;
      this.btnZoom.Text = "Zoom";
      this.btnZoom.UseVisualStyleBackColor = true;
      this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
      // 
      // btnViewAll
      // 
      this.btnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnViewAll.Location = new System.Drawing.Point(174, 575);
      this.btnViewAll.Name = "btnViewAll";
      this.btnViewAll.Size = new System.Drawing.Size(65, 29);
      this.btnViewAll.TabIndex = 21;
      this.btnViewAll.Text = "View All";
      this.btnViewAll.UseVisualStyleBackColor = true;
      this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.textBox1.Location = new System.Drawing.Point(295, 38);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(56, 23);
      this.textBox1.TabIndex = 20;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnDisconnect);
      this.groupBox2.Controls.Add(this.btnPortValue);
      this.groupBox2.Controls.Add(this.btnConnect);
      this.groupBox2.Controls.Add(this.comboBox1);
      this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox2.Location = new System.Drawing.Point(363, 31);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(127, 249);
      this.groupBox2.TabIndex = 19;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Port";
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(12, 103);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(104, 33);
      this.btnDisconnect.TabIndex = 10;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
      // 
      // btnPortValue
      // 
      this.btnPortValue.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnPortValue.Location = new System.Drawing.Point(12, 142);
      this.btnPortValue.Name = "btnPortValue";
      this.btnPortValue.Size = new System.Drawing.Size(104, 90);
      this.btnPortValue.TabIndex = 8;
      this.btnPortValue.Text = "button1";
      this.btnPortValue.UseVisualStyleBackColor = true;
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(12, 64);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(104, 33);
      this.btnConnect.TabIndex = 9;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(12, 29);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(104, 23);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new System.Drawing.Point(16, 168);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(341, 94);
      this.listBox1.TabIndex = 18;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.progressBar1);
      this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.Location = new System.Drawing.Point(16, 73);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(341, 80);
      this.groupBox1.TabIndex = 17;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "photoCell";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(294, 49);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "1023";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(14, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "0";
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 26);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(323, 23);
      this.progressBar1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(24, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 15);
      this.label1.TabIndex = 16;
      this.label1.Text = "label1";
      // 
      // chart1
      // 
      chartArea2.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart1.Legends.Add(legend2);
      this.chart1.Location = new System.Drawing.Point(16, 286);
      this.chart1.Name = "chart1";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart1.Series.Add(series2);
      this.chart1.Size = new System.Drawing.Size(474, 276);
      this.chart1.TabIndex = 23;
      this.chart1.Text = "chart1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(507, 616);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.btnZoom);
      this.Controls.Add(this.btnViewAll);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Arduino Sensor Monitoring";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 읽어오기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 시뮬레이션ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 시작ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝ToolStripMenuItem;
    private System.Windows.Forms.Button btnZoom;
    private System.Windows.Forms.Button btnViewAll;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.Button btnPortValue;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
  }
}

