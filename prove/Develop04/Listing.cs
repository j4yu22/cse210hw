using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void PrintDescription()
    {
        Console.Clear();
        Console.WriteLine("Listing Activity");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.Clear();
        Console.WriteLine(prompt);
        DelayAnimation(3);

        Console.WriteLine("Start listing items now...");
        List<string> items = new List<string>();
        int elapsed = 0;
        while (elapsed < time)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
            elapsed += 3;
        }

        Console.Clear();
        Console.WriteLine($"You listed {items.Count} items.");
    }
}
