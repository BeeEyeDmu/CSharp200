using System;
using System.IO;
using System.Windows.Forms;

namespace A173_MyNotePad
{
  public partial class Form1 : Form
  {
    private bool modifyFlag = false;
    private string fileName = "noname.txt";

    public Form1()
    {
      InitializeComponent();
      this.Text = fileName + " - myNotePad";
    }

    // RichTextBox의 TextChanged Event 처리 메서드
    private void txtMemo_TextChanged(object sender, EventArgs e)
    {
      modifyFlag = true;
    }

    private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 작업중 파일 처리
      FileProcessBeforeClose();

      txtMemo.Text = "";
      modifyFlag = false;
      fileName = "noname.txt";
    }

    private void FileProcessBeforeClose()
    {
      if (modifyFlag == true)
      {
        DialogResult ans = MessageBox.Show("변경된 내용을 저장하시겠습니까?",
            "저장", MessageBoxButtons.YesNo);
        if (ans == DialogResult.Yes)
        {
          if (fileName == "noname.txt")  // 파일 이름을 지정하지 않았다면
          {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
              StreamWriter sw = File.CreateText(saveFileDialog1.FileName);
              sw.WriteLine(txtMemo.Text);
              sw.Close();
            }
          }
          else  // 파일 이름이 지정되어 있다면
          {
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(txtMemo.Text);
            sw.Close();
          }
        }
      }
    }

    private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 현재 열려있는 파일이 수정되었다면 저장할 필요가 있다
      FileProcessBeforeClose();

      // 새로 파일을 열 수 있도록 다이얼로그를 띄운다
      openFileDialog1.ShowDialog();
      fileName = openFileDialog1.FileName;
      this.Text = fileName + " - myNotePad";
      try
      {
        StreamReader r = File.OpenText(fileName);
        txtMemo.Text = r.ReadToEnd();

        modifyFlag = false;
        r.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (fileName == "noname.txt")
      {
        saveFileDialog1.ShowDialog();
        fileName = saveFileDialog1.FileName;
      }
      StreamWriter sw = File.CreateText(fileName);
      sw.WriteLine(txtMemo.Text);

      modifyFlag = false;
      sw.Close();
    }

    private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // 작업중 파일 처리
      FileProcessBeforeClose();
      Close();
    }

    private void 복사하기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RichTextBox contents = (RichTextBox)ActiveControl;
      if (contents != null)
      {
        Clipboard.SetDataObject(contents.SelectedText);
        MessageBox.Show(contents.SelectedText);
      }
    }

    private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RichTextBox contents = (RichTextBox)ActiveControl;
      if (contents != null)
      {
        IDataObject data = Clipboard.GetDataObject();
        contents.SelectedText = data.GetData(DataFormats.Text).ToString();
        modifyFlag = true;
      }
    }
  }
}
