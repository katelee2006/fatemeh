using System;

Dog.cs
public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }

    public void Run()
    {
        Console.WriteLine("Dog is running.");
    }
}
