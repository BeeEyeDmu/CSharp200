namespace A175_ImageViewer
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.이미지선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sizeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stretchImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.autoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 24);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(393, 317);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이미지선택ToolStripMenuItem,
            this.sizeModeToolStripMenuItem,
            this.종료ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(393, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 이미지선택ToolStripMenuItem
      // 
      this.이미지선택ToolStripMenuItem.Name = "이미지선택ToolStripMenuItem";
      this.이미지선택ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
      this.이미지선택ToolStripMenuItem.Text = "이미지 선택";
      this.이미지선택ToolStripMenuItem.Click += new System.EventHandler(this.이미지선택ToolStripMenuItem_Click);
      // 
      // sizeModeToolStripMenuItem
      // 
      this.sizeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stretchImageToolStripMenuItem,
            this.autoSizeToolStripMenuItem,
            this.centerImageToolStripMenuItem,
            this.zoomToolStripMenuItem});
      this.sizeModeToolStripMenuItem.Name = "sizeModeToolStripMenuItem";
      this.sizeModeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
      this.sizeModeToolStripMenuItem.Text = "SizeMode";
      // 
      // normalToolStripMenuItem
      // 
      this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
      this.normalToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
      this.normalToolStripMenuItem.Text = "Normal";
      this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
      // 
      // stretchImageToolStripMenuItem
      // 
      this.stretchImageToolStripMenuItem.Name = "stretchImageToolStripMenuItem";
      this.stretchImageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
      this.stretchImageToolStripMenuItem.Text = "StretchImage";
      this.stretchImageToolStripMenuItem.Click += new System.EventHandler(this.stretchImageToolStripMenuItem_Click);
      // 
      // autoSizeToolStripMenuItem
      // 
      this.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
      this.autoSizeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
      this.autoSizeToolStripMenuItem.Text = "AutoSize";
      this.autoSizeToolStripMenuItem.Click += new System.EventHandler(this.autoSizeToolStripMenuItem_Click);
      // 
      // centerImageToolStripMenuItem
      // 
      this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
      this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
      this.centerImageToolStripMenuItem.Text = "CenterImage";
      this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
      // 
      // zoomToolStripMenuItem
      // 
      this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
      this.zoomToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
      this.zoomToolStripMenuItem.Text = "Zoom";
      this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.종료ToolStripMenuItem.Text = "종료";
      this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(393, 341);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 이미지선택ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sizeModeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem stretchImageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem autoSizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
  }
}

