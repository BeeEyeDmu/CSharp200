namespace A181_StudentPhoneBook
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
      this.btnEnd = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnInsert = new System.Windows.Forms.Button();
      this.btnViewAll = new System.Windows.Forms.Button();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtSName = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtSId = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtID = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnEnd
      // 
      this.btnEnd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnEnd.Location = new System.Drawing.Point(305, 292);
      this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnEnd.Name = "btnEnd";
      this.btnEnd.Size = new System.Drawing.Size(75, 33);
      this.btnEnd.TabIndex = 31;
      this.btnEnd.Text = "끝";
      this.btnEnd.UseVisualStyleBackColor = true;
      this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnUpdate.Location = new System.Drawing.Point(305, 254);
      this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 33);
      this.btnUpdate.TabIndex = 30;
      this.btnUpdate.Text = "수정";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDelete.Location = new System.Drawing.Point(305, 216);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 33);
      this.btnDelete.TabIndex = 29;
      this.btnDelete.Text = "삭제";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnClear
      // 
      this.btnClear.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnClear.Location = new System.Drawing.Point(223, 292);
      this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 33);
      this.btnClear.TabIndex = 28;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnSearch.Location = new System.Drawing.Point(223, 255);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 33);
      this.btnSearch.TabIndex = 27;
      this.btnSearch.Text = "검색";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnInsert
      // 
      this.btnInsert.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnInsert.Location = new System.Drawing.Point(224, 215);
      this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnInsert.Name = "btnInsert";
      this.btnInsert.Size = new System.Drawing.Size(75, 33);
      this.btnInsert.TabIndex = 26;
      this.btnInsert.Text = "추가";
      this.btnInsert.UseVisualStyleBackColor = true;
      this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
      // 
      // btnViewAll
      // 
      this.btnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnViewAll.Location = new System.Drawing.Point(224, 178);
      this.btnViewAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnViewAll.Name = "btnViewAll";
      this.btnViewAll.Size = new System.Drawing.Size(75, 33);
      this.btnViewAll.TabIndex = 25;
      this.btnViewAll.Text = "View All";
      this.btnViewAll.UseVisualStyleBackColor = true;
      this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
      // 
      // txtPhone
      // 
      this.txtPhone.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtPhone.Location = new System.Drawing.Point(83, 297);
      this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(125, 25);
      this.txtPhone.TabIndex = 24;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label4.Location = new System.Drawing.Point(25, 301);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 17);
      this.label4.TabIndex = 23;
      this.label4.Text = "전화번호";
      // 
      // txtSName
      // 
      this.txtSName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSName.Location = new System.Drawing.Point(83, 258);
      this.txtSName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtSName.Name = "txtSName";
      this.txtSName.Size = new System.Drawing.Size(125, 25);
      this.txtSName.TabIndex = 22;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label3.Location = new System.Drawing.Point(25, 263);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(34, 17);
      this.label3.TabIndex = 21;
      this.label3.Text = "이름";
      // 
      // txtSId
      // 
      this.txtSId.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtSId.Location = new System.Drawing.Point(83, 220);
      this.txtSId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtSId.Name = "txtSId";
      this.txtSId.Size = new System.Drawing.Size(125, 25);
      this.txtSId.TabIndex = 20;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label2.Location = new System.Drawing.Point(25, 224);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 17);
      this.label2.TabIndex = 19;
      this.label2.Text = "학번";
      // 
      // txtID
      // 
      this.txtID.BackColor = System.Drawing.Color.White;
      this.txtID.Enabled = false;
      this.txtID.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtID.Location = new System.Drawing.Point(83, 182);
      this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(125, 25);
      this.txtID.TabIndex = 18;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(25, 186);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(21, 17);
      this.label1.TabIndex = 17;
      this.label1.Text = "ID";
      // 
      // listBox1
      // 
      this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 17;
      this.listBox1.Location = new System.Drawing.Point(21, 25);
      this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(359, 140);
      this.listBox1.TabIndex = 16;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(396, 341);
      this.Controls.Add(this.btnEnd);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnInsert);
      this.Controls.Add(this.btnViewAll);
      this.Controls.Add(this.txtPhone);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtSName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSId);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtID);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "StudentPhoneBook";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnEnd;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnInsert;
    private System.Windows.Forms.Button btnViewAll;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtSName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtSId;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox listBox1;
  }
}

