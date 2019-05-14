namespace A138_MaskedTextBox
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
      this.txtDate = new System.Windows.Forms.MaskedTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtZip = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtAddr = new System.Windows.Forms.MaskedTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtPhone = new System.Windows.Forms.MaskedTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtId = new System.Windows.Forms.MaskedTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.MaskedTextBox();
      this.btnRegister = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtDate
      // 
      this.txtDate.Location = new System.Drawing.Point(111, 20);
      this.txtDate.Mask = "0000-00-00";
      this.txtDate.Name = "txtDate";
      this.txtDate.Size = new System.Drawing.Size(100, 21);
      this.txtDate.TabIndex = 0;
      this.txtDate.ValidatingType = typeof(System.DateTime);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "입사일";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 50);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "우편번호";
      // 
      // txtZip
      // 
      this.txtZip.Location = new System.Drawing.Point(111, 47);
      this.txtZip.Mask = "99999";
      this.txtZip.Name = "txtZip";
      this.txtZip.Size = new System.Drawing.Size(100, 21);
      this.txtZip.TabIndex = 2;
      this.txtZip.ValidatingType = typeof(int);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 77);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "주소";
      // 
      // txtAddr
      // 
      this.txtAddr.Location = new System.Drawing.Point(111, 74);
      this.txtAddr.Name = "txtAddr";
      this.txtAddr.Size = new System.Drawing.Size(335, 21);
      this.txtAddr.TabIndex = 4;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(26, 105);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(69, 12);
      this.label5.TabIndex = 9;
      this.label5.Text = "휴대폰 번호";
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(111, 102);
      this.txtPhone.Mask = "000-9000-0000";
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(100, 21);
      this.txtPhone.TabIndex = 8;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(26, 132);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(77, 12);
      this.label6.TabIndex = 11;
      this.label6.Text = "주민등록번호";
      // 
      // txtId
      // 
      this.txtId.Location = new System.Drawing.Point(111, 129);
      this.txtId.Mask = "000000-0000000";
      this.txtId.Name = "txtId";
      this.txtId.Size = new System.Drawing.Size(100, 21);
      this.txtId.TabIndex = 10;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(26, 159);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(41, 12);
      this.label7.TabIndex = 13;
      this.label7.Text = "이메일";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(111, 156);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(182, 21);
      this.txtEmail.TabIndex = 12;
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(111, 183);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(75, 27);
      this.btnRegister.TabIndex = 14;
      this.btnRegister.Text = "등록";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 228);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtId);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtAddr);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtZip);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtDate);
      this.Name = "Form1";
      this.Text = "사원정보 등록";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox txtDate;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MaskedTextBox txtZip;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.MaskedTextBox txtAddr;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.MaskedTextBox txtPhone;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.MaskedTextBox txtId;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.MaskedTextBox txtEmail;
    private System.Windows.Forms.Button btnRegister;
  }
}

