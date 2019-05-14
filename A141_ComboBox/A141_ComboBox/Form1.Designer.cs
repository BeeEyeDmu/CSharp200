namespace A141_ComboBox
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.lblRestaurant = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "수타우동 겐",
            "동경 오이시",
            "베아투스",
            "겐지 스시",
            "스시 유이",
            "1314",
            "STAGE 28"});
      this.comboBox1.Location = new System.Drawing.Point(34, 55);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 20);
      this.comboBox1.TabIndex = 0;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(121, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "좋아하는 식당 리스트";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(199, 55);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "추가";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(199, 89);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "삭제";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // lblRestaurant
      // 
      this.lblRestaurant.AutoSize = true;
      this.lblRestaurant.Location = new System.Drawing.Point(34, 165);
      this.lblRestaurant.Name = "lblRestaurant";
      this.lblRestaurant.Size = new System.Drawing.Size(121, 12);
      this.lblRestaurant.TabIndex = 4;
      this.lblRestaurant.Text = "이번 주 모임장소는 : ";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 215);
      this.Controls.Add(this.lblRestaurant);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox1);
      this.Name = "Form1";
      this.Text = "ComboBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label lblRestaurant;
  }
}

