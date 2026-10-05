using System;

namespace fatemehzare
{
    internal class Teacher
    {
    }
}
Teacher.cs
public class Teacher
{
    public string Name { get; set; }
    public string Subject { get; set; }

    public void Teach()
    {
        Console.WriteLine("Teacher is teaching.");
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + " - " + Subject);
    }
}