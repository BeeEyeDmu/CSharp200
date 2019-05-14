using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace A151_MP3AlarmClock
{
  public partial class Form1 : Form
  {
    Timer myTimer = new Timer();
    DateTime dDay;
    DateTime tTime;
    private bool setAlarm;
    WindowsMediaPlayer myPlayer = new WindowsMediaPlayer();

    public Form1()
    {
      InitializeComponent();

      lblAlarm.ForeColor = Color.Gray;
      lblAlarmSet.ForeColor = Color.Gray;

      timePicker.Format = DateTimePickerFormat.Custom;
      timePicker.CustomFormat = "tt hh:mm";

      myTimer.Interval = 1000;
      myTimer.Tick += MyTimer_Tick;
      myTimer.Start();

      tabControl1.SelectedTab = tabPage2;
    }

    private void MyTimer_Tick(object sender, EventArgs e)
    {
      DateTime cTime = DateTime.Now;
      lblDate.Text = cTime.ToShortDateString();
      lblTime.Text = cTime.ToLongTimeString();

      if(setAlarm == true)
      {
        if (dDay == DateTime.Today &&
          cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
        {
          setAlarm = false;
          myPlayer.URL = @"C:\Users\bikan\Dropbox\2018\InfoPub\Source\A151_MP3AlarmClock\A151_MP3AlarmClock\Music\preview.mp3";
          myPlayer.controls.play();
          //MessageBox.Show("Alarm!!");          
        }
      }
    }

    private void btnSet_Click(object sender, EventArgs e)
    {
      dDay = DateTime.Parse(datePicker.Text);
      tTime = DateTime.Parse(timePicker.Text);

      setAlarm = true;
      lblAlarmSet.ForeColor = Color.Red;
      lblAlarm.ForeColor = Color.Blue;
      lblAlarm.Text = "Alarm : " + dDay.ToShortDateString() + " "
        + tTime.ToLongTimeString();

      tabControl1.SelectedTab = tabPage2;
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      setAlarm = false;
      lblAlarmSet.ForeColor = Color.Gray;
      lblAlarm.ForeColor = Color.Gray;
      lblAlarm.Text = "Alarm : ";
      tabControl1.SelectedTab = tabPage2;
    }
  }
}
