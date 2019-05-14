using System;

namespace A069_Property
{
  class Rectangle
  {
    private double width;
    private double height;

    public double Area()
    {
      return width*height;
    }

    //public Rectangle(double width, double height) // 생성자
    //{
    //  this.width = width;
    //  this.height = height;
    //}

    // Getter
    public double GetWidth()
    {
      return width;
    }

    public double GetHeight()
    {
      return height;
    }

    // Setter
    public void SetWidth(double width)
    {
      this.width = width;
    }

    public void SetHeight(double height)
    {
      this.height = height;
    }
  }

  class RectWithProp
  {
    //private double width;
    //private double height;

    //public RectWithProp(double width, double height) // 생성자
    //{
    //  this.width = width;
    //  this.height = height;
    //}

    public double Area()
    {
      return Width * Height;
    }

    public double Width { get; set; } // Width 속성
    public double Height { get; set; } // Height 속성
  }

  class RectWithPropFull
  {
    private double width;

    public double Width
    {
      get { return width; }
      set { if(value > 0 ) width = value; }
    }

    private double height;
    public double Height
    {
      get { return height; }
      set { if (value >= 0) height = value; }
    }
  }

  class Rect
  {
    public int Width { get; set; }
    public int Height { get; set; }
    public int Area()
    {
      return Width * Height;
    }
  }

  // expression-bodied members
  class RectWithExpressionBodiedMembers
  {
    private double width;
    public double Width
    {
      get => width;
      set => width = value;
   }

    private double height;
    public double Height
    {
      get => height;
      set => height = value;
    }
  }

  class PropertyTest
  {    
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle();
      r.SetWidth(10.0);
      r.SetHeight(10.0);
      Console.WriteLine("r의 면적은 {0}", r.GetWidth() * r.GetHeight());

      RectWithProp r1 = new RectWithProp();
      r1.Width = 10.0;
      r1.Height = 10.0;
      Console.WriteLine("r1의 면적은 {0}", r1.Width * r1.Height);

      RectWithPropFull r2 = new RectWithPropFull();
      r2.Width = 10.0;
      r2.Height = 10.0;
      Console.WriteLine("r2의 면적은 {0}", r2.Width * r2.Height);

      RectWithPropFull r3 = new RectWithPropFull();
      r2.Width = 10.0;
      r2.Height = -10.0;
      Console.WriteLine("r3의 면적은 {0}", r3.Width * r3.Height);
    }
  }
}
