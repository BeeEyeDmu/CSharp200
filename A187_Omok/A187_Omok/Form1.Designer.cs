using System;

namespace A187_Omok
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
      this.다시시작ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.복기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.수순ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.수순표시ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.수순표시안함ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.수순ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(479, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.다시시작ToolStripMenuItem,
            this.복기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 다시시작ToolStripMenuItem
      // 
      this.다시시작ToolStripMenuItem.Name = "다시시작ToolStripMenuItem";
      this.다시시작ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.다시시작ToolStripMenuItem.Text = "다시 시작";
      this.다시시작ToolStripMenuItem.Click += new System.EventHandler(this.다시시작ToolStripMenuItem_Click);
      // 
      // 복기ToolStripMenuItem
      // 
      this.복기ToolStripMenuItem.Name = "복기ToolStripMenuItem";
      this.복기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.복기ToolStripMenuItem.Text = "복기";
      this.복기ToolStripMenuItem.Click += new System.EventHandler(this.복기ToolStripMenuItem_Click);
      // 
      // 끝내기ToolStripMenuItem
      // 
      this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
      this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.끝내기ToolStripMenuItem.Text = "끝내기";
      this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
      // 
      // 보기ToolStripMenuItem
      // 
      this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그리기ToolStripMenuItem,
            this.이미지ToolStripMenuItem});
      this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
      this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.보기ToolStripMenuItem.Text = "보기";
      // 
      // 그리기ToolStripMenuItem
      // 
      this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
      this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.그리기ToolStripMenuItem.Text = "그리기";
      this.그리기ToolStripMenuItem.Click += new System.EventHandler(this.그리기ToolStripMenuItem_Click);
      // 
      // 이미지ToolStripMenuItem
      // 
      this.이미지ToolStripMenuItem.Name = "이미지ToolStripMenuItem";
      this.이미지ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.이미지ToolStripMenuItem.Text = "이미지";
      this.이미지ToolStripMenuItem.Click += new System.EventHandler(this.이미지ToolStripMenuItem_Click);
      // 
      // 수순ToolStripMenuItem
      // 
      this.수순ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수순표시ToolStripMenuItem,
            this.수순표시안함ToolStripMenuItem});
      this.수순ToolStripMenuItem.Name = "수순ToolStripMenuItem";
      this.수순ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.수순ToolStripMenuItem.Text = "수순";
      // 
      // 수순표시ToolStripMenuItem
      // 
      this.수순표시ToolStripMenuItem.Name = "수순표시ToolStripMenuItem";
      this.수순표시ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.수순표시ToolStripMenuItem.Text = "수순표시";
      this.수순표시ToolStripMenuItem.Click += new System.EventHandler(this.수순표시ToolStripMenuItem_Click);
      // 
      // 수순표시안함ToolStripMenuItem
      // 
      this.수순표시안함ToolStripMenuItem.Name = "수순표시안함ToolStripMenuItem";
      this.수순표시안함ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
      this.수순표시안함ToolStripMenuItem.Text = "수순표시 안함";
      this.수순표시안함ToolStripMenuItem.Click += new System.EventHandler(this.수순표시안함ToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(479, 418);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(479, 442);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "오목";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 이미지ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 수순ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 수순표시ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 수순표시안함ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 다시시작ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 복기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
  }
}

