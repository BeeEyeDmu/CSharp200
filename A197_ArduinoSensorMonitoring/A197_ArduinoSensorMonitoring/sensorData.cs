using System;

namespace A197_ArduinoSensorMonitoring
{
  internal class SensorData
  {
    public string Date { get; set; }
    public string Time { get; set; }
    public int Value { get; set; }

    public SensorData(string date, string time, int value)
    {
      this.Date = date;
      this.Time = time;
      this.Value = value;
    }
  }
}