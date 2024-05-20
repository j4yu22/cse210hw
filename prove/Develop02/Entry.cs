using System;
using System.Collections.Generic;

public class Entry
{
    public string Response { get; private set; }
    public string Date { get; private set; }
    public string Prompt { get; private set; }

    private static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "What did I learn today?",
        "What was the most challenging part of my day?",
        "What did I accomplish today?",
        "What made me laugh today?",
        "Who did I help today and how?",
        "What did I do for myself today?",
        "What did I do to stay healthy today?",
        "What goals did I work towards today?",
        "How did I manage my stress today?",
        "What new experiences did I have today?",
        "What did I do to relax today?",
        "What was the highlight of my day?",
        "What acts of kindness did I perform today?",
        "What was a moment of beauty I noticed today?",
        "What is something I wish I had done differently today?",
        "How did I show love to others today?",
        "What did I read or watch today that inspired me?",
        "What was a small victory I had today?",
        "How did I challenge myself today?",
        "What was a moment of peace I had today?"
    };

    private static Random random = new Random();

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now.ToString("MM-dd-yyyy");
    }

    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date}: {Prompt}\n{Response}\n";
    }

    public string GetCurrentPrompt()
    {
        return Prompt;
    }

    public static string GetPrompt()
    {
        return prompts[random.Next(prompts.Count)];
    }
}
