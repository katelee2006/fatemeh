using System;

namespace fatemehzare
{
    internal class Rectangle
    {
    }
}
Rectangle.cs
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area()
    {
        return Width * Height;
    }

    public int Perimeter()
    {
        return 2 * (Width + Height);
    }
}