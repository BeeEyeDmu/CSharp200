namespace WMP
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
      this.btnFile = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
      this.SuspendLayout();
      // 
      // axWindowsMediaPlayer1
      // 
      this.axWindowsMediaPlayer1.Enabled = true;
      this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 1);
      this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
      this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
      this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(511, 336);
      this.axWindowsMediaPlayer1.TabIndex = 0;
      // 
      // btnFile
      // 
      this.btnFile.Location = new System.Drawing.Point(427, 341);
      this.btnFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnFile.Name = "btnFile";
      this.btnFile.Size = new System.Drawing.Size(85, 27);
      this.btnFile.TabIndex = 1;
      this.btnFile.Text = "파일 선택";
      this.btnFile.UseVisualStyleBackColor = true;
      this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(542, 390);
      this.Controls.Add(this.btnFile);
      this.Controls.Add(this.axWindowsMediaPlayer1);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "WMP";
      this.Resize += new System.EventHandler(this.Form1_Resize);
      ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    private System.Windows.Forms.Button btnFile;
  }
}

