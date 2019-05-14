namespace A146_TreeView
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
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.txtMemo = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // treeView1
      // 
      this.treeView1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.treeView1.Location = new System.Drawing.Point(12, 12);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(213, 302);
      this.treeView1.TabIndex = 0;
      this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(245, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(174, 179);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // txtMemo
      // 
      this.txtMemo.AcceptsReturn = true;
      this.txtMemo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtMemo.Location = new System.Drawing.Point(245, 198);
      this.txtMemo.Multiline = true;
      this.txtMemo.Name = "txtMemo";
      this.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtMemo.Size = new System.Drawing.Size(174, 116);
      this.txtMemo.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(444, 328);
      this.Controls.Add(this.txtMemo);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.treeView1);
      this.Name = "Form1";
      this.Text = "영국의 군주";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox txtMemo;
  }
}

