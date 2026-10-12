using System;

namespace _14042480040

{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; }

        public Rectangle(double width, double height, string color)
        {
            Width = width;
            Height = height;
            Color = color;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
