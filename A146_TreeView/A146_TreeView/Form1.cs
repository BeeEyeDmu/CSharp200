using System;
using System.Drawing;
using System.Windows.Forms;

namespace A146_TreeView
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      TreeNode root = new TreeNode("영국의 왕");

      TreeNode stuart = new TreeNode("스튜어트 왕가");
      TreeNode hanover = new TreeNode("하노버 왕가");
      TreeNode sachsen = new TreeNode("작센코브르트고타 왕가");
      TreeNode windsor = new TreeNode("윈저 왕가");

      stuart.Nodes.Add("앤(1707~1714)");

      hanover.Nodes.Add("조지 1세(1714~1727)");
      hanover.Nodes.Add("조지 2세(1727~1760)");
      hanover.Nodes.Add("조지 3세(1760~1820)");
      hanover.Nodes.Add("조지 4세(1820~1830)");
      hanover.Nodes.Add("윌리엄 4세(1830~1837)");
      hanover.Nodes.Add("빅토리아(1837~1901)");

      sachsen.Nodes.Add("에드워드 7세(1901~1910)");

      windsor.Nodes.Add("조지 5세(1910~1936)");
      windsor.Nodes.Add("에드워드 8세(1936~1936)");
      windsor.Nodes.Add("조지 6세(1936~1952)");
      windsor.Nodes.Add("엘리자베스 2세(1952~현재)");

      root.Nodes.Add(stuart);
      root.Nodes.Add(hanover);
      root.Nodes.Add(sachsen);
      root.Nodes.Add(windsor);

      treeView1.Nodes.Add(root);
      treeView1.ExpandAll();
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (e.Node.Text == "앤(1707~1714)")
      {
        pictureBox1.Image = Bitmap.FromFile("../../Images/Anne.jpg");
        txtMemo.Text = "앤 여왕은 1702년 3월 8일 잉글랜드와 스코틀랜드, 아일랜드의 여왕으로 즉위하였으며, "
          + "1707년 연합법이 제정됨에 따라, 잉글랜드 왕국과 스코틀랜드 왕국이 통합된 그레이트브리튼 왕국, "
          + "즉 영국의 첫 번째 군주가 되었다.";
      }
      else if (e.Node.Text == "조지 1세(1714~1727)")
      {
        pictureBox1.Image = Bitmap.FromFile("../../Images/King_George_I.jpg");
        txtMemo.Text = "잉글랜드 의회에서 1701년 왕위 결정 법이 통과되면서, 하노버 왕가가 왕위 계승권을 "
          + "갖게 되었지만, 가톨릭 신자는 왕위 계승권에서 제외되었다. 1707년 스코틀랜드 의회에서도 "
          + "하노버 왕가의 왕위 계승권을 비준하였다. 앤 여왕이 후사를 남기지 못하고 서거하자, "
          + "그와 가장 가까운 친척이자 제임스 1세(6세)의 증손녀인 팔츠의 조피의 아들인 데다가, "
          + "가톨릭 신자가 아니었던 조지 1세가 왕위를 이어받게 되었다.";
      }
    }
  }
}
