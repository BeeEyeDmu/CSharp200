namespace A161_WinFormCalc
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
      this.btnEqual = new System.Windows.Forms.Button();
      this.btnDot = new System.Windows.Forms.Button();
      this.btn0 = new System.Windows.Forms.Button();
      this.btnPlusMinus = new System.Windows.Forms.Button();
      this.btnPlus = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn1 = new System.Windows.Forms.Button();
      this.btnMinus = new System.Windows.Forms.Button();
      this.btn6 = new System.Windows.Forms.Button();
      this.btn5 = new System.Windows.Forms.Button();
      this.btn4 = new System.Windows.Forms.Button();
      this.btnTimes = new System.Windows.Forms.Button();
      this.btn9 = new System.Windows.Forms.Button();
      this.btn8 = new System.Windows.Forms.Button();
      this.btn7 = new System.Windows.Forms.Button();
      this.btnDivide = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnC = new System.Windows.Forms.Button();
      this.btnCE = new System.Windows.Forms.Button();
      this.btnRecip = new System.Windows.Forms.Button();
      this.btnSqr = new System.Windows.Forms.Button();
      this.btnSqrt = new System.Windows.Forms.Button();
      this.txtExp = new System.Windows.Forms.TextBox();
      this.btnPercent = new System.Windows.Forms.Button();
      this.btnMS = new System.Windows.Forms.Button();
      this.btnMMinus = new System.Windows.Forms.Button();
      this.btnMPlus = new System.Windows.Forms.Button();
      this.btnMR = new System.Windows.Forms.Button();
      this.btnMC = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnEqual
      // 
      this.btnEqual.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnEqual.FlatAppearance.BorderSize = 0;
      this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEqual.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnEqual.Location = new System.Drawing.Point(193, 330);
      this.btnEqual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnEqual.Name = "btnEqual";
      this.btnEqual.Size = new System.Drawing.Size(69, 50);
      this.btnEqual.TabIndex = 61;
      this.btnEqual.Text = "=";
      this.btnEqual.UseVisualStyleBackColor = false;
      this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
      // 
      // btnDot
      // 
      this.btnDot.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnDot.FlatAppearance.BorderSize = 0;
      this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDot.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDot.Location = new System.Drawing.Point(128, 330);
      this.btnDot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDot.Name = "btnDot";
      this.btnDot.Size = new System.Drawing.Size(69, 50);
      this.btnDot.TabIndex = 60;
      this.btnDot.Text = ".";
      this.btnDot.UseVisualStyleBackColor = false;
      this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
      // 
      // btn0
      // 
      this.btn0.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn0.FlatAppearance.BorderSize = 0;
      this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn0.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn0.Location = new System.Drawing.Point(62, 330);
      this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn0.Name = "btn0";
      this.btn0.Size = new System.Drawing.Size(69, 50);
      this.btn0.TabIndex = 59;
      this.btn0.Text = "0";
      this.btn0.UseVisualStyleBackColor = false;
      this.btn0.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnPlusMinus
      // 
      this.btnPlusMinus.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnPlusMinus.FlatAppearance.BorderSize = 0;
      this.btnPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPlusMinus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnPlusMinus.Location = new System.Drawing.Point(0, 330);
      this.btnPlusMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnPlusMinus.Name = "btnPlusMinus";
      this.btnPlusMinus.Size = new System.Drawing.Size(69, 50);
      this.btnPlusMinus.TabIndex = 58;
      this.btnPlusMinus.Text = "±";
      this.btnPlusMinus.UseVisualStyleBackColor = false;
      this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
      // 
      // btnPlus
      // 
      this.btnPlus.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnPlus.FlatAppearance.BorderSize = 0;
      this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnPlus.Location = new System.Drawing.Point(193, 284);
      this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(69, 50);
      this.btnPlus.TabIndex = 57;
      this.btnPlus.Text = "＋";
      this.btnPlus.UseVisualStyleBackColor = false;
      this.btnPlus.Click += new System.EventHandler(this.btnOP_Click);
      // 
      // btn3
      // 
      this.btn3.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn3.FlatAppearance.BorderSize = 0;
      this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn3.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn3.Location = new System.Drawing.Point(128, 284);
      this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(69, 50);
      this.btn3.TabIndex = 56;
      this.btn3.Text = "3";
      this.btn3.UseVisualStyleBackColor = false;
      this.btn3.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn2
      // 
      this.btn2.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn2.FlatAppearance.BorderSize = 0;
      this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn2.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn2.Location = new System.Drawing.Point(62, 284);
      this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(69, 50);
      this.btn2.TabIndex = 55;
      this.btn2.Text = "2";
      this.btn2.UseVisualStyleBackColor = false;
      this.btn2.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn1
      // 
      this.btn1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn1.FlatAppearance.BorderSize = 0;
      this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn1.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn1.Location = new System.Drawing.Point(0, 284);
      this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(69, 50);
      this.btn1.TabIndex = 54;
      this.btn1.Text = "1";
      this.btn1.UseVisualStyleBackColor = false;
      this.btn1.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnMinus
      // 
      this.btnMinus.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnMinus.FlatAppearance.BorderSize = 0;
      this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnMinus.Location = new System.Drawing.Point(193, 238);
      this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(69, 50);
      this.btnMinus.TabIndex = 53;
      this.btnMinus.Text = "－";
      this.btnMinus.UseVisualStyleBackColor = false;
      this.btnMinus.Click += new System.EventHandler(this.btnOP_Click);
      // 
      // btn6
      // 
      this.btn6.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn6.FlatAppearance.BorderSize = 0;
      this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn6.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn6.Location = new System.Drawing.Point(128, 238);
      this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn6.Name = "btn6";
      this.btn6.Size = new System.Drawing.Size(69, 50);
      this.btn6.TabIndex = 52;
      this.btn6.Text = "6";
      this.btn6.UseVisualStyleBackColor = false;
      this.btn6.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn5
      // 
      this.btn5.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn5.FlatAppearance.BorderSize = 0;
      this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn5.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn5.Location = new System.Drawing.Point(62, 238);
      this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn5.Name = "btn5";
      this.btn5.Size = new System.Drawing.Size(69, 50);
      this.btn5.TabIndex = 51;
      this.btn5.Text = "5";
      this.btn5.UseVisualStyleBackColor = false;
      this.btn5.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn4
      // 
      this.btn4.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn4.FlatAppearance.BorderSize = 0;
      this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn4.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn4.Location = new System.Drawing.Point(0, 238);
      this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn4.Name = "btn4";
      this.btn4.Size = new System.Drawing.Size(69, 50);
      this.btn4.TabIndex = 50;
      this.btn4.Text = "4";
      this.btn4.UseVisualStyleBackColor = false;
      this.btn4.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnTimes
      // 
      this.btnTimes.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnTimes.FlatAppearance.BorderSize = 0;
      this.btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTimes.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnTimes.Location = new System.Drawing.Point(193, 191);
      this.btnTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnTimes.Name = "btnTimes";
      this.btnTimes.Size = new System.Drawing.Size(69, 50);
      this.btnTimes.TabIndex = 49;
      this.btnTimes.Text = "×";
      this.btnTimes.UseVisualStyleBackColor = false;
      this.btnTimes.Click += new System.EventHandler(this.btnOP_Click);
      // 
      // btn9
      // 
      this.btn9.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn9.FlatAppearance.BorderSize = 0;
      this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn9.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn9.Location = new System.Drawing.Point(128, 191);
      this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn9.Name = "btn9";
      this.btn9.Size = new System.Drawing.Size(69, 50);
      this.btn9.TabIndex = 48;
      this.btn9.Text = "9";
      this.btn9.UseVisualStyleBackColor = false;
      this.btn9.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn8
      // 
      this.btn8.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn8.FlatAppearance.BorderSize = 0;
      this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn8.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn8.Location = new System.Drawing.Point(62, 191);
      this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn8.Name = "btn8";
      this.btn8.Size = new System.Drawing.Size(69, 50);
      this.btn8.TabIndex = 47;
      this.btn8.Text = "8";
      this.btn8.UseVisualStyleBackColor = false;
      this.btn8.Click += new System.EventHandler(this.btn_Click);
      // 
      // btn7
      // 
      this.btn7.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btn7.FlatAppearance.BorderSize = 0;
      this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btn7.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn7.Location = new System.Drawing.Point(0, 191);
      this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn7.Name = "btn7";
      this.btn7.Size = new System.Drawing.Size(69, 50);
      this.btn7.TabIndex = 46;
      this.btn7.Text = "7";
      this.btn7.UseVisualStyleBackColor = false;
      this.btn7.Click += new System.EventHandler(this.btn_Click);
      // 
      // btnDivide
      // 
      this.btnDivide.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnDivide.FlatAppearance.BorderSize = 0;
      this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDivide.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDivide.Location = new System.Drawing.Point(193, 145);
      this.btnDivide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDivide.Name = "btnDivide";
      this.btnDivide.Size = new System.Drawing.Size(69, 50);
      this.btnDivide.TabIndex = 45;
      this.btnDivide.Text = "÷";
      this.btnDivide.UseVisualStyleBackColor = false;
      this.btnDivide.Click += new System.EventHandler(this.btnOP_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnDelete.FlatAppearance.BorderSize = 0;
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnDelete.Location = new System.Drawing.Point(128, 145);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(69, 50);
      this.btnDelete.TabIndex = 44;
      this.btnDelete.Text = "⌫";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnC
      // 
      this.btnC.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnC.FlatAppearance.BorderSize = 0;
      this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnC.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnC.Location = new System.Drawing.Point(62, 145);
      this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnC.Name = "btnC";
      this.btnC.Size = new System.Drawing.Size(69, 50);
      this.btnC.TabIndex = 43;
      this.btnC.Text = "C";
      this.btnC.UseVisualStyleBackColor = false;
      this.btnC.Click += new System.EventHandler(this.btnC_Click);
      // 
      // btnCE
      // 
      this.btnCE.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnCE.FlatAppearance.BorderSize = 0;
      this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCE.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnCE.Location = new System.Drawing.Point(0, 145);
      this.btnCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnCE.Name = "btnCE";
      this.btnCE.Size = new System.Drawing.Size(69, 50);
      this.btnCE.TabIndex = 42;
      this.btnCE.Text = "CE";
      this.btnCE.UseVisualStyleBackColor = false;
      this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
      // 
      // btnRecip
      // 
      this.btnRecip.BackColor = System.Drawing.Color.White;
      this.btnRecip.FlatAppearance.BorderSize = 0;
      this.btnRecip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRecip.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnRecip.Location = new System.Drawing.Point(195, 94);
      this.btnRecip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnRecip.Name = "btnRecip";
      this.btnRecip.Size = new System.Drawing.Size(69, 50);
      this.btnRecip.TabIndex = 41;
      this.btnRecip.Text = "1/x";
      this.btnRecip.UseVisualStyleBackColor = false;
      this.btnRecip.Click += new System.EventHandler(this.btnRecip_Click);
      // 
      // btnSqr
      // 
      this.btnSqr.BackColor = System.Drawing.Color.White;
      this.btnSqr.FlatAppearance.BorderSize = 0;
      this.btnSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSqr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnSqr.Location = new System.Drawing.Point(128, 94);
      this.btnSqr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnSqr.Name = "btnSqr";
      this.btnSqr.Size = new System.Drawing.Size(69, 50);
      this.btnSqr.TabIndex = 40;
      this.btnSqr.Text = "x²";
      this.btnSqr.UseVisualStyleBackColor = false;
      this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
      // 
      // btnSqrt
      // 
      this.btnSqrt.BackColor = System.Drawing.Color.White;
      this.btnSqrt.FlatAppearance.BorderSize = 0;
      this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSqrt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnSqrt.Location = new System.Drawing.Point(62, 94);
      this.btnSqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnSqrt.Name = "btnSqrt";
      this.btnSqrt.Size = new System.Drawing.Size(69, 50);
      this.btnSqrt.TabIndex = 39;
      this.btnSqrt.Text = "√";
      this.btnSqrt.UseVisualStyleBackColor = false;
      this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
      // 
      // txtExp
      // 
      this.txtExp.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.txtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtExp.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtExp.Location = new System.Drawing.Point(0, 7);
      this.txtExp.Margin = new System.Windows.Forms.Padding(3, 24, 3, 2);
      this.txtExp.Name = "txtExp";
      this.txtExp.Size = new System.Drawing.Size(253, 20);
      this.txtExp.TabIndex = 38;
      this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnPercent
      // 
      this.btnPercent.BackColor = System.Drawing.Color.White;
      this.btnPercent.FlatAppearance.BorderSize = 0;
      this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPercent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnPercent.Location = new System.Drawing.Point(0, 94);
      this.btnPercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnPercent.Name = "btnPercent";
      this.btnPercent.Size = new System.Drawing.Size(69, 50);
      this.btnPercent.TabIndex = 37;
      this.btnPercent.Text = "%";
      this.btnPercent.UseVisualStyleBackColor = false;
      this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
      // 
      // btnMS
      // 
      this.btnMS.BackColor = System.Drawing.Color.White;
      this.btnMS.FlatAppearance.BorderSize = 0;
      this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMS.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnMS.Location = new System.Drawing.Point(206, 59);
      this.btnMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnMS.Name = "btnMS";
      this.btnMS.Size = new System.Drawing.Size(57, 35);
      this.btnMS.TabIndex = 36;
      this.btnMS.Text = "MS";
      this.btnMS.UseVisualStyleBackColor = false;
      this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
      // 
      // btnMMinus
      // 
      this.btnMMinus.BackColor = System.Drawing.Color.White;
      this.btnMMinus.FlatAppearance.BorderSize = 0;
      this.btnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMMinus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnMMinus.Location = new System.Drawing.Point(156, 59);
      this.btnMMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnMMinus.Name = "btnMMinus";
      this.btnMMinus.Size = new System.Drawing.Size(57, 35);
      this.btnMMinus.TabIndex = 35;
      this.btnMMinus.Text = "M-";
      this.btnMMinus.UseVisualStyleBackColor = false;
      this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
      // 
      // btnMPlus
      // 
      this.btnMPlus.BackColor = System.Drawing.Color.White;
      this.btnMPlus.FlatAppearance.BorderSize = 0;
      this.btnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMPlus.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnMPlus.Location = new System.Drawing.Point(107, 59);
      this.btnMPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnMPlus.Name = "btnMPlus";
      this.btnMPlus.Size = new System.Drawing.Size(57, 35);
      this.btnMPlus.TabIndex = 34;
      this.btnMPlus.Text = "M+";
      this.btnMPlus.UseVisualStyleBackColor = false;
      this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
      // 
      // btnMR
      // 
      this.btnMR.BackColor = System.Drawing.Color.White;
      this.btnMR.FlatAppearance.BorderSize = 0;
      this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMR.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnMR.Location = new System.Drawing.Point(54, 59);
      this.btnMR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnMR.Name = "btnMR";
      this.btnMR.Size = new System.Drawing.Size(57, 35);
      this.btnMR.TabIndex = 33;
      this.btnMR.Text = "MR";
      this.btnMR.UseVisualStyleBackColor = false;
      this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
      // 
      // btnMC
      // 
      this.btnMC.BackColor = System.Drawing.Color.White;
      this.btnMC.FlatAppearance.BorderSize = 0;
      this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btnMC.Location = new System.Drawing.Point(0, 59);
      this.btnMC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnMC.Name = "btnMC";
      this.btnMC.Size = new System.Drawing.Size(57, 35);
      this.btnMC.TabIndex = 32;
      this.btnMC.Text = "MC";
      this.btnMC.UseVisualStyleBackColor = false;
      this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
      // 
      // txtResult
      // 
      this.txtResult.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.txtResult.Location = new System.Drawing.Point(-1, 25);
      this.txtResult.Margin = new System.Windows.Forms.Padding(3, 80, 26, 0);
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(253, 32);
      this.txtResult.TabIndex = 31;
      this.txtResult.Text = "0";
      this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(260, 380);
      this.Controls.Add(this.btnEqual);
      this.Controls.Add(this.btnDot);
      this.Controls.Add(this.btn0);
      this.Controls.Add(this.btnPlusMinus);
      this.Controls.Add(this.btnPlus);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn1);
      this.Controls.Add(this.btnMinus);
      this.Controls.Add(this.btn6);
      this.Controls.Add(this.btn5);
      this.Controls.Add(this.btn4);
      this.Controls.Add(this.btnTimes);
      this.Controls.Add(this.btn9);
      this.Controls.Add(this.btn8);
      this.Controls.Add(this.btn7);
      this.Controls.Add(this.btnDivide);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnC);
      this.Controls.Add(this.btnCE);
      this.Controls.Add(this.btnRecip);
      this.Controls.Add(this.btnSqr);
      this.Controls.Add(this.btnSqrt);
      this.Controls.Add(this.txtExp);
      this.Controls.Add(this.btnPercent);
      this.Controls.Add(this.btnMS);
      this.Controls.Add(this.btnMMinus);
      this.Controls.Add(this.btnMPlus);
      this.Controls.Add(this.btnMR);
      this.Controls.Add(this.btnMC);
      this.Controls.Add(this.txtResult);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "윈도우 표준 계산기";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnEqual;
    private System.Windows.Forms.Button btnDot;
    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btnPlusMinus;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btnTimes;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btnDivide;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnC;
    private System.Windows.Forms.Button btnCE;
    private System.Windows.Forms.Button btnRecip;
    private System.Windows.Forms.Button btnSqr;
    private System.Windows.Forms.Button btnSqrt;
    private System.Windows.Forms.TextBox txtExp;
    private System.Windows.Forms.Button btnPercent;
    private System.Windows.Forms.Button btnMS;
    private System.Windows.Forms.Button btnMMinus;
    private System.Windows.Forms.Button btnMPlus;
    private System.Windows.Forms.Button btnMR;
    private System.Windows.Forms.Button btnMC;
    private System.Windows.Forms.TextBox txtResult;
  }
}

