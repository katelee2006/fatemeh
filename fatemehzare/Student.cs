using System;

Student.cs
public class Student
{
    public string Name { get; set; }
    public int StudentNumber { get; set; }

    public void Study()
    {
        Console.WriteLine("Student is studying.");
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + " - " + StudentNumber);
    }
}

