using System;

namespace _14042480040

{
    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }

        public Customer(string name, string phone, decimal balance)
        {
            Name = name;
            Phone = phone;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(Name + " deposited " + amount + ". New balance: " + Balance);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Customer: " + Name + ", Phone: " + Phone + ", Balance: " + Balance);
        }
    }
}