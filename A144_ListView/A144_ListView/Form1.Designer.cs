namespace A116_ListView
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
      this.myListView = new System.Windows.Forms.ListView();
      this.rbDetail = new System.Windows.Forms.RadioButton();
      this.rbList = new System.Windows.Forms.RadioButton();
      this.rbSmall = new System.Windows.Forms.RadioButton();
      this.rbLarge = new System.Windows.Forms.RadioButton();
      this.txtSelected = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // myListView
      // 
      this.myListView.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.myListView.Location = new System.Drawing.Point(12, 32);
      this.myListView.Name = "myListView";
      this.myListView.Size = new System.Drawing.Size(430, 163);
      this.myListView.TabIndex = 0;
      this.myListView.UseCompatibleStateImageBehavior = false;
      this.myListView.View = System.Windows.Forms.View.Details;
      this.myListView.SelectedIndexChanged += new System.EventHandler(this.myListView_SelectedIndexChanged);
      // 
      // rbDetail
      // 
      this.rbDetail.AutoSize = true;
      this.rbDetail.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.rbDetail.Location = new System.Drawing.Point(41, 7);
      this.rbDetail.Name = "rbDetail";
      this.rbDetail.Size = new System.Drawing.Size(61, 19);
      this.rbDetail.TabIndex = 1;
      this.rbDetail.TabStop = true;
      this.rbDetail.Text = "자세히";
      this.rbDetail.UseVisualStyleBackColor = true;
      this.rbDetail.CheckedChanged += new System.EventHandler(this.rbDetail_CheckedChanged);
      // 
      // rbList
      // 
      this.rbList.AutoSize = true;
      this.rbList.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.rbList.Location = new System.Drawing.Point(123, 7);
      this.rbList.Name = "rbList";
      this.rbList.Size = new System.Drawing.Size(61, 19);
      this.rbList.TabIndex = 2;
      this.rbList.TabStop = true;
      this.rbList.Text = "리스트";
      this.rbList.UseVisualStyleBackColor = true;
      this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
      // 
      // rbSmall
      // 
      this.rbSmall.AutoSize = true;
      this.rbSmall.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.rbSmall.Location = new System.Drawing.Point(211, 7);
      this.rbSmall.Name = "rbSmall";
      this.rbSmall.Size = new System.Drawing.Size(89, 19);
      this.rbSmall.TabIndex = 3;
      this.rbSmall.TabStop = true;
      this.rbSmall.Text = "작은 아이콘";
      this.rbSmall.UseVisualStyleBackColor = true;
      this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
      // 
      // rbLarge
      // 
      this.rbLarge.AutoSize = true;
      this.rbLarge.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.rbLarge.Location = new System.Drawing.Point(325, 7);
      this.rbLarge.Name = "rbLarge";
      this.rbLarge.Size = new System.Drawing.Size(77, 19);
      this.rbLarge.TabIndex = 4;
      this.rbLarge.TabStop = true;
      this.rbLarge.Text = "큰 아이콘";
      this.rbLarge.UseVisualStyleBackColor = true;
      this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
      // 
      // txtSelected
      // 
      this.txtSelected.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSelected.Location = new System.Drawing.Point(189, 201);
      this.txtSelected.Name = "txtSelected";
      this.txtSelected.Size = new System.Drawing.Size(253, 23);
      this.txtSelected.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(121, 204);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 15);
      this.label1.TabIndex = 6;
      this.label1.Text = "Selected: ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(461, 238);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSelected);
      this.Controls.Add(this.rbLarge);
      this.Controls.Add(this.rbSmall);
      this.Controls.Add(this.rbList);
      this.Controls.Add(this.rbDetail);
      this.Controls.Add(this.myListView);
      this.Name = "Form1";
      this.Text = "ListView";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView myListView;
    private System.Windows.Forms.RadioButton rbDetail;
    private System.Windows.Forms.RadioButton rbList;
    private System.Windows.Forms.RadioButton rbSmall;
    private System.Windows.Forms.RadioButton rbLarge;
    private System.Windows.Forms.TextBox txtSelected;
    private System.Windows.Forms.Label label1;
  }
}

