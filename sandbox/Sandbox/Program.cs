using System;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Console.WriteLine($"You have ${bank.GetAccountBalance()}.");
        bank.Withdraw();
        Console.WriteLine($"You have ${bank.GetAccountBalance()}.");
    }
}