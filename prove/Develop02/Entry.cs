class Entry
{
    static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string randomPrompt = prompts[index];
        return randomPrompt;
    }

    static void GetResponse(string[] args)
    {
        string randomPrompt = GetPrompt();
        Console.WriteLine($"Please record your response to this prompt: {randomPrompt}.");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("MM-dd-yyyy");
    }
}