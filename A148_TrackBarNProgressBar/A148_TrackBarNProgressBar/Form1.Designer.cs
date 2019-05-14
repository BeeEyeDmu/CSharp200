namespace A148_TrackBarNProgressBar
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
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.button1 = new System.Windows.Forms.Button();
      this.lblTrack = new System.Windows.Forms.Label();
      this.lblProgress = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(39, 48);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(327, 45);
      this.trackBar1.TabIndex = 0;
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(52, 108);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(314, 23);
      this.progressBar1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(180, 161);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "시작";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lblTrack
      // 
      this.lblTrack.AutoSize = true;
      this.lblTrack.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblTrack.Location = new System.Drawing.Point(391, 48);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new System.Drawing.Size(0, 17);
      this.lblTrack.TabIndex = 3;
      // 
      // lblProgress
      // 
      this.lblProgress.AutoSize = true;
      this.lblProgress.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lblProgress.Location = new System.Drawing.Point(391, 114);
      this.lblProgress.Name = "lblProgress";
      this.lblProgress.Size = new System.Drawing.Size(0, 17);
      this.lblProgress.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(449, 212);
      this.Controls.Add(this.lblProgress);
      this.Controls.Add(this.lblTrack);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.trackBar1);
      this.Name = "Form1";
      this.Text = "TrackBar와 ProgressBar";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label lblTrack;
    private System.Windows.Forms.Label lblProgress;
  }
}

