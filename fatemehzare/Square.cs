using System;

namespace fatemehzare
{
    internal class Square
    {
    }
}
Square.cs
public class Square
{
    public int Side { get; set; }

    public int Area()
    {
        return Side * Side;
    }

    public int Perimeter()
    {
        return 4 * Side;
    }
}