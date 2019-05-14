using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A143_GradeCalc
{
  public partial class Form1 : Form
  {
    TextBox[] titles;
    ComboBox[] crds;
    ComboBox[] grds;    
   
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txt1.Text = "인체의 구조와 기능I";
      txt2.Text = "일반수학I";
      txt3.Text = "디지털공학및실험";
      txt4.Text = "자료구조";
      txt5.Text = "비주얼프로그래밍";
      txt6.Text = "기업가정신";

      crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7};
      grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7};
      titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
      int[] arrCredit = { 1, 2, 3, 4, 5 };
      List<String> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };
      
      foreach (var combo in crds)
      {
        foreach (var i in arrCredit)
          combo.Items.Add(i);
        combo.SelectedItem = 3;
      }
      
      foreach (var cb in grds)
      {
        foreach (var gr in lstGrade)
          cb.Items.Add(gr);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double totalScore = 0;
      int totalCredits = 0;

      for (int i = 0; i < crds.Length; i++)
      {
        if (titles[i].Text != "")
        {
          int crd = int.Parse(crds[i].SelectedItem.ToString());
          totalCredits += crd;
          totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
        }
      }
      txtGrade.Text = (totalScore / totalCredits).ToString("0.00");
    }

    private double GetGrade(string text)
    {
      double grade = 0;

      if (text == "A+")  grade = 4.5;
      else if (text == "A0")  grade = 4.0;
      else if (text == "B+")  grade = 3.5;
      else if (text == "B0")  grade = 3.0;
      else if (text == "C+")  grade = 2.5;
      else if (text == "C0")  grade = 2.0;
      else if (text == "D+")  grade = 1.5;
      else if (text == "D0")  grade = 1.0;
      else grade = 0;
      return grade;
    }
  }
}
