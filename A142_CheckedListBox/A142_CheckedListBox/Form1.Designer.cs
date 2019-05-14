namespace A142_CheckedListBox
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
      this.cLstBox = new System.Windows.Forms.CheckedListBox();
      this.btnTo = new System.Windows.Forms.Button();
      this.btnAll = new System.Windows.Forms.Button();
      this.lstBox = new System.Windows.Forms.ListBox();
      this.btnDelAll = new System.Windows.Forms.Button();
      this.btnBack = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cLstBox
      // 
      this.cLstBox.FormattingEnabled = true;
      this.cLstBox.Location = new System.Drawing.Point(12, 12);
      this.cLstBox.Name = "cLstBox";
      this.cLstBox.Size = new System.Drawing.Size(174, 196);
      this.cLstBox.TabIndex = 0;
      // 
      // btnTo
      // 
      this.btnTo.Location = new System.Drawing.Point(212, 66);
      this.btnTo.Name = "btnTo";
      this.btnTo.Size = new System.Drawing.Size(75, 23);
      this.btnTo.TabIndex = 1;
      this.btnTo.Text = ">";
      this.btnTo.UseVisualStyleBackColor = true;
      this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
      // 
      // btnAll
      // 
      this.btnAll.Location = new System.Drawing.Point(212, 95);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(75, 23);
      this.btnAll.TabIndex = 2;
      this.btnAll.Text = ">>";
      this.btnAll.UseVisualStyleBackColor = true;
      this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // lstBox
      // 
      this.lstBox.FormattingEnabled = true;
      this.lstBox.ItemHeight = 12;
      this.lstBox.Location = new System.Drawing.Point(310, 12);
      this.lstBox.Name = "lstBox";
      this.lstBox.Size = new System.Drawing.Size(156, 160);
      this.lstBox.TabIndex = 3;
      // 
      // btnDelAll
      // 
      this.btnDelAll.Location = new System.Drawing.Point(359, 185);
      this.btnDelAll.Name = "btnDelAll";
      this.btnDelAll.Size = new System.Drawing.Size(107, 23);
      this.btnDelAll.TabIndex = 4;
      this.btnDelAll.Text = "모두 삭제";
      this.btnDelAll.UseVisualStyleBackColor = true;
      this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
      // 
      // btnBack
      // 
      this.btnBack.Location = new System.Drawing.Point(212, 125);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(75, 23);
      this.btnBack.TabIndex = 5;
      this.btnBack.Text = "<";
      this.btnBack.UseVisualStyleBackColor = true;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(487, 221);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.btnDelAll);
      this.Controls.Add(this.lstBox);
      this.Controls.Add(this.btnAll);
      this.Controls.Add(this.btnTo);
      this.Controls.Add(this.cLstBox);
      this.Name = "Form1";
      this.Text = "Travel Wish List";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.CheckedListBox cLstBox;
    private System.Windows.Forms.Button btnTo;
    private System.Windows.Forms.Button btnAll;
    private System.Windows.Forms.ListBox lstBox;
    private System.Windows.Forms.Button btnDelAll;
    private System.Windows.Forms.Button btnBack;
  }
}

