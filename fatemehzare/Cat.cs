using System;


namespace fatemehzare
{
    internal class Cat
    {
    }
}
Cat.cs
public class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }

    public void Run()
    {
        Console.WriteLine("Cat is running.");
    }
}