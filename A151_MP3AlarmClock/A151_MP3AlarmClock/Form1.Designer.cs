namespace A151_MP3AlarmClock
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnSet = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.timePicker = new System.Windows.Forms.DateTimePicker();
      this.datePicker = new System.Windows.Forms.DateTimePicker();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.lblTime = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblAlarm = new System.Windows.Forms.Label();
      this.lblAlarmSet = new System.Windows.Forms.Label();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.tabControl1.Location = new System.Drawing.Point(14, 15);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(398, 334);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnReset);
      this.tabPage1.Controls.Add(this.btnSet);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.timePicker);
      this.tabPage1.Controls.Add(this.datePicker);
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage1.Size = new System.Drawing.Size(390, 301);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "알람 설정";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(265, 221);
      this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(86, 36);
      this.btnReset.TabIndex = 5;
      this.btnReset.Text = "해제";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnSet
      // 
      this.btnSet.Location = new System.Drawing.Point(162, 221);
      this.btnSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnSet.Name = "btnSet";
      this.btnSet.Size = new System.Drawing.Size(86, 36);
      this.btnSet.TabIndex = 4;
      this.btnSet.Text = "설정";
      this.btnSet.UseVisualStyleBackColor = true;
      this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(19, 129);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(74, 20);
      this.label2.TabIndex = 3;
      this.label2.Text = "시간 설정";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "날짜 설정";
      // 
      // timePicker
      // 
      this.timePicker.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.timePicker.Location = new System.Drawing.Point(19, 156);
      this.timePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.timePicker.Name = "timePicker";
      this.timePicker.Size = new System.Drawing.Size(228, 27);
      this.timePicker.TabIndex = 1;
      // 
      // datePicker
      // 
      this.datePicker.CalendarFont = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.datePicker.Location = new System.Drawing.Point(19, 61);
      this.datePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.datePicker.Name = "datePicker";
      this.datePicker.Size = new System.Drawing.Size(228, 27);
      this.datePicker.TabIndex = 0;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox1);
      this.tabPage2.Controls.Add(this.lblAlarm);
      this.tabPage2.Controls.Add(this.lblAlarmSet);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage2.Size = new System.Drawing.Size(390, 301);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "디지털 시계";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblTime);
      this.groupBox1.Controls.Add(this.lblDate);
      this.groupBox1.Location = new System.Drawing.Point(35, 124);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.groupBox1.Size = new System.Drawing.Size(321, 136);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "현재시간";
      // 
      // lblTime
      // 
      this.lblTime.AutoSize = true;
      this.lblTime.Font = new System.Drawing.Font("맑은 고딕", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblTime.Location = new System.Drawing.Point(19, 58);
      this.lblTime.Name = "lblTime";
      this.lblTime.Size = new System.Drawing.Size(139, 65);
      this.lblTime.TabIndex = 2;
      this.lblTime.Text = "Time";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Location = new System.Drawing.Point(24, 39);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(41, 20);
      this.lblDate.TabIndex = 3;
      this.lblDate.Text = "Date";
      // 
      // lblAlarm
      // 
      this.lblAlarm.AutoSize = true;
      this.lblAlarm.Location = new System.Drawing.Point(32, 79);
      this.lblAlarm.Name = "lblAlarm";
      this.lblAlarm.Size = new System.Drawing.Size(62, 20);
      this.lblAlarm.TabIndex = 1;
      this.lblAlarm.Text = "Alarm : ";
      // 
      // lblAlarmSet
      // 
      this.lblAlarmSet.AutoSize = true;
      this.lblAlarmSet.Location = new System.Drawing.Point(29, 39);
      this.lblAlarmSet.Name = "lblAlarmSet";
      this.lblAlarmSet.Size = new System.Drawing.Size(74, 20);
      this.lblAlarmSet.TabIndex = 0;
      this.lblAlarmSet.Text = "알람 설정";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 366);
      this.Controls.Add(this.tabControl1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "Form1";
      this.Text = "Alarm 시계";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DateTimePicker datePicker;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker timePicker;
    private System.Windows.Forms.Button btnSet;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lblTime;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblAlarm;
    private System.Windows.Forms.Label lblAlarmSet;
  }
}

