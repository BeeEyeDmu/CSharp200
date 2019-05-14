using System;
using System.Drawing;
using System.Windows.Forms;

namespace A116_ListView
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      myListView.GridLines = true;
      myListView.FullRowSelect = true;

      myListView.Columns.Add("제품명", 150);
      myListView.Columns.Add("단가", 100, HorizontalAlignment.Right);
      myListView.Columns.Add("수량", 70, HorizontalAlignment.Right);
      myListView.Columns.Add("금액", 100, HorizontalAlignment.Right);

      ListViewItem item1 = new ListViewItem("Access", 0);
      ListViewItem item2 = new ListViewItem("Excel", 1);
      ListViewItem item3 = new ListViewItem("PowerPoint", 2);
      ListViewItem item4 = new ListViewItem("Word", 3);

      item1.SubItems.Add("22,000");
      item1.SubItems.Add("30");
      item1.SubItems.Add("660,000");

      item2.SubItems.Add("33,000");
      item2.SubItems.Add("50");
      item2.SubItems.Add("1,650,000");

      item3.SubItems.Add("11,000");
      item3.SubItems.Add("50");
      item3.SubItems.Add("550,000");

      item4.SubItems.Add("22,000");
      item4.SubItems.Add("30");
      item4.SubItems.Add("660,000");

      myListView.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });

      ImageList sImageList = new ImageList();
      sImageList.ImageSize = new Size(24, 24);
      ImageList lImageList = new ImageList();
      lImageList.ImageSize = new Size(64, 64);

      myListView.SmallImageList = sImageList;
      myListView.LargeImageList = lImageList;

      sImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.png"));
      sImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.png"));
      sImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.png"));
      sImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.png"));

      lImageList.Images.Add(Bitmap.FromFile(@"../../Image/access.png"));
      lImageList.Images.Add(Bitmap.FromFile(@"../../Image/excel.png"));
      lImageList.Images.Add(Bitmap.FromFile(@"../../Image/ppt.png"));
      lImageList.Images.Add(Bitmap.FromFile(@"../../Image/word.png"));
    }

    private void myListView_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtSelected.Text = "";
      ListView.SelectedListViewItemCollection selected = myListView.SelectedItems;

      foreach(ListViewItem item in selected)
      {
        for (int i = 0; i < 4; i++)
          txtSelected.Text += item.SubItems[i].Text + "\t";
      }
    }

    private void rbDetail_CheckedChanged(object sender, EventArgs e)
    {
      myListView.View = View.Details;
    }

    private void rbList_CheckedChanged(object sender, EventArgs e)
    {
      myListView.View = View.List;
    }

    private void rbSmall_CheckedChanged(object sender, EventArgs e)
    {
      myListView.View = View.SmallIcon;
    }

    private void rbLarge_CheckedChanged(object sender, EventArgs e)
    {
      myListView.View = View.LargeIcon;
    }
  }
}
