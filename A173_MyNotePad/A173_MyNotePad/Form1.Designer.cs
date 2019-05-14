namespace A173_MyNotePad
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.복사하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.txtMemo = new System.Windows.Forms.RichTextBox();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(700, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 새로만들기ToolStripMenuItem
      // 
      this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
      this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.새로만들기ToolStripMenuItem.Text = "새로 만들기";
      this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
      // 
      // 열기ToolStripMenuItem
      // 
      this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
      this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.열기ToolStripMenuItem.Text = "열기";
      this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
      // 
      // 저장ToolStripMenuItem
      // 
      this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
      this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.저장ToolStripMenuItem.Text = "저장";
      this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
      // 
      // 끝내기ToolStripMenuItem
      // 
      this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
      this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.끝내기ToolStripMenuItem.Text = "끝내기";
      this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
      // 
      // 편집ToolStripMenuItem
      // 
      this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.복사하기ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem});
      this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
      this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.편집ToolStripMenuItem.Text = "편집";
      // 
      // 복사하기ToolStripMenuItem
      // 
      this.복사하기ToolStripMenuItem.Name = "복사하기ToolStripMenuItem";
      this.복사하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.복사하기ToolStripMenuItem.Text = "복사하기";
      this.복사하기ToolStripMenuItem.Click += new System.EventHandler(this.복사하기ToolStripMenuItem_Click);
      // 
      // 붙여넣기ToolStripMenuItem
      // 
      this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
      this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
      this.붙여넣기ToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기ToolStripMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // txtMemo
      // 
      this.txtMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtMemo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtMemo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtMemo.Location = new System.Drawing.Point(0, 24);
      this.txtMemo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtMemo.Name = "txtMemo";
      this.txtMemo.Size = new System.Drawing.Size(700, 336);
      this.txtMemo.TabIndex = 1;
      this.txtMemo.Text = "";
      this.txtMemo.TextChanged += new System.EventHandler(this.txtMemo_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(700, 360);
      this.Controls.Add(this.txtMemo);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 복사하기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.RichTextBox txtMemo;
  }
}

