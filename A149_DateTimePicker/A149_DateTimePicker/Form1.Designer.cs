namespace A149_DateTimePicker
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
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtDates = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.dateTimePicker1.Location = new System.Drawing.Point(12, 49);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
      this.dateTimePicker1.TabIndex = 0;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(12, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "날짜를 선택하세요.";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(12, 130);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(160, 15);
      this.label2.TabIndex = 2;
      this.label2.Text = "선택한 날짜부터 오늘까지 ...";
      // 
      // txtDates
      // 
      this.txtDates.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtDates.Location = new System.Drawing.Point(168, 127);
      this.txtDates.Name = "txtDates";
      this.txtDates.Size = new System.Drawing.Size(85, 23);
      this.txtDates.TabIndex = 3;
      this.txtDates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.Location = new System.Drawing.Point(259, 130);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 15);
      this.label3.TabIndex = 4;
      this.label3.Text = "일이 지났습니다.";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(378, 174);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtDates);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dateTimePicker1);
      this.Name = "Form1";
      this.Text = "날짜 계산기";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtDates;
    private System.Windows.Forms.Label label3;
  }
}

