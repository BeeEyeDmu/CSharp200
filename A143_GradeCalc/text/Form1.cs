using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      int[] a = { 1, 2, 3, 4, 5 };
      ComboBox[] cbs = { comboBox1, comboBox2, comboBox3, comboBox4 };
      foreach (var cb in cbs)
        foreach(var i in a)
          cb.Items.Add(i);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      MessageBox.Show("ComboBox1 changed");
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {
      MessageBox.Show("ComboBox2 changed");
    }

    private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
    {
      MessageBox.Show("ComboBox3 changed");
    }

    private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
    {
      MessageBox.Show("ComboBox4 changed");
    }
  }
}
