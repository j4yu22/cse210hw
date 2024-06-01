using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();

        Console.WriteLine($"You have ${bank.GetAccountBalance()}.");
        bank.Withdraw();
        Console.WriteLine($"You have ${bank.GetAccountBalance()}.");
        // for(int i = 0; i < 4; i++)
        // {
        //     int number = GetRandomNumber(1, 11);
        //     Console.WriteLine(number);
        // }

    }

    // static int GetRandomNumber(int min, int max)
    // {
    //     Random rand = new Random();
    //     return rand.Next(min, max);
    // }
}