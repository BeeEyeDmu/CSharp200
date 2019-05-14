namespace A187_Omok
{
  class Revive
  {
    public int X { get; set; }
    public int Y { get; set; }
    public STONE Stone { get; set; }
    public int Seq { get; set; }

    public Revive(int x, int y, STONE s, int seq)
    {
      this.X = x;
      this.Y = y;
      this.Stone = s;
      this.Seq = seq;
    }
  }
}
