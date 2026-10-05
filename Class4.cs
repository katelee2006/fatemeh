using System;

namespace fatemehzare
{
    internal class Employee
    {
    }
}
Employee.cs
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public void Work()
    {
        Console.WriteLine("Employee is working.");
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + " - " + Salary);
    }
}