using System;

namespace fatemehzare
{
    internal class Customer
    {
    }
}

Customer.cs
public class Customer
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public void Buy()
    {
        Console.WriteLine("Customer bought a product.");
    }

    public void ShowInfo()
    {
        Console.WriteLine(Name + " - " + PhoneNumber);
    }
}