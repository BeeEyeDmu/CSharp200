using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace A140_ListBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      listBox2.Items.Add("오스트리아, 빈");
      listBox2.Items.Add("호주, 멜버른");
      listBox2.Items.Add("일본, 오사카");
      listBox2.Items.Add("캐나다, 캘거리");
      listBox2.Items.Add("호주, 시드니");
      listBox2.Items.Add("캐나다, 밴쿠버");
      listBox2.Items.Add("일본, 도쿄");
      listBox2.Items.Add("캐나다, 토론토");
      listBox2.Items.Add("덴마크, 코펜하겐");
      listBox2.Items.Add("호주, 애들레이드");

      List<String> lstGDP = new List<String> { "미국", "러시아", "중국", "영국",
        "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE"};
      listBox3.DataSource = lstGDP;

      //listBox1.SelectedIndex = 0;
      //listBox2.SelectedIndex = 0;
      //listBox3.SelectedIndex = 0;
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lst = sender as ListBox;
      txtSIndex1.Text = lst.SelectedIndex.ToString();
      txtSItem1.Text = lst.SelectedItem.ToString();
    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lst = sender as ListBox;
      txtSIndex2.Text = lst.SelectedIndex.ToString();
      txtSItem2.Text = lst.SelectedItem.ToString();
    }

    private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lst = sender as ListBox;
      txtSIndex3.Text = lst.SelectedIndex.ToString();
      txtSItem3.Text = lst.SelectedItem.ToString();
    }
  }
}
