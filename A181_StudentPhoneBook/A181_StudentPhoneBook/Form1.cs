using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace A181_StudentPhoneBook
{
  public partial class Form1 : Form
  {
    OleDbConnection conn = null;
    OleDbCommand comm = null;
    OleDbDataReader reader = null;

    string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Students.accdb";

    public Form1()
    {
      InitializeComponent();
      DisplayStudents();
    }

    private void DisplayStudents()
    {
      ConnectionOpen();

      // SQL 명령어를 만든다
      string sql = "SELECT * FROM StudentTable";

      // 명령어를 실행
      comm = new OleDbCommand(sql, conn);      

      // DB에서 읽을 때는 여러개의 값이 나올 수 있다
      ReadAndAddToListBox();

      ConnectionClose();
    }

    private void ReadAndAddToListBox()
    {
      reader = comm.ExecuteReader();
      while (reader.Read())
      {
        string x = "";
        x += reader["ID"] + "\t";
        x += reader["SID"] + "\t";
        x += reader["SName"] + "\t";
        x += reader["Phone"];

        listBox1.Items.Add(x);
      }
      reader.Close();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      ListBox lb = sender as ListBox;

      if (lb.SelectedItem == null)
        return;

      string[] s = lb.SelectedItem.ToString().Split('\t');
      txtID.Text = s[0];
      txtSId.Text = s[1];
      txtSName.Text = s[2];
      txtPhone.Text = s[3];
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      if (txtSName.Text == "" || txtPhone.Text == "" || txtSId.Text == "")
        return;

      // 1. 데이터 연결
      // 2. SQL 작성
      // 3. comm 실행
      // 4. conn Close

      ConnectionOpen();

      string sql = string.Format("insert into StudentTable(SId, SName, Phone) " + "" +
        "VALUES({0}, '{1}', '{2}')", txtSId.Text, txtSName.Text, txtPhone.Text);
      MessageBox.Show(sql);

      // comm을 실행
      comm = new OleDbCommand(sql, conn);
      int x = comm.ExecuteNonQuery();
      if (x == 1)
        MessageBox.Show("삽입 성공!");

      ConnectionClose();

      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtID.Text = "";
      txtSName.Text = "";
      txtPhone.Text = "";
      txtSId.Text = "";
    }

    private void btnViewAll_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void btnEnd_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      // 4개의 텍스트박스 중 적어도 하나는 값이 있어야 한다
      if (txtID.Text == "" && txtSName.Text == ""
        && txtPhone.Text == "" && txtSId.Text == "")
        return;

      ConnectionOpen();

      string sql = "";

      if (txtSId.Text != "")
        sql = string.Format("SELECT * FROM StudentTable WHERE SId={0}", txtSId.Text);
      else if (txtSName.Text != "")
        sql = string.Format("SELECT * FROM StudentTable WHERE SName='{0}'", txtSName.Text);
      else if (txtPhone.Text != "")
        sql = string.Format("SELECT * FROM StudentTable WHERE Phone='{0}'", txtPhone.Text);

      MessageBox.Show(sql);
      listBox1.Items.Clear();

      // 명령어를 실행
      comm = new OleDbCommand(sql, conn);

      ReadAndAddToListBox();
      ConnectionClose();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      ConnectionOpen();

      string sql = string.Format("UPDATE StudentTable SET SID={0}, SName='{1}', Phone='{2}' WHERE ID={3}",
        txtSId.Text, txtSName.Text, txtPhone.Text, txtID.Text);
      MessageBox.Show(sql);

      // comm을 실행
      comm = new OleDbCommand(sql, conn);
      if (comm.ExecuteNonQuery() == 1)
        MessageBox.Show("수정 성공!");

      ConnectionClose();

      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      ConnectionOpen();

      string sql = string.Format("DELETE FROM StudentTable WHERE ID={0}", txtID.Text);
      MessageBox.Show(sql);

      // comm을 실행
      comm = new OleDbCommand(sql, conn);
      if (comm.ExecuteNonQuery() == 1)
        MessageBox.Show("삭제 성공!");

      ConnectionClose();
      listBox1.Items.Clear();
      DisplayStudents();
    }

    private void ConnectionOpen()
    {
      if (conn == null)
      {
        conn = new OleDbConnection(connStr);
        conn.Open();
      }
    }

    private void ConnectionClose()
    {
      conn.Close();
      conn = null;
    }
  }
}
