using System;
using System.Runtime;

class Activity{
    static int GetTime() {
        while (true) {
        Console.Write("How many seconds would you like to do this activity for? ");
        string input = Console.ReadLine();
            try
            {
                int duration = int.Parse(input);
                if (duration > 0)
                {
                    return duration;
                }
                else
                {
                    Console.WriteLine("Please enter a positive number.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    static void Run() {
        Console.WriteLine("Running...");
    }
   public static void Load(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerLength = spinner.Length;
        int totalIterations = seconds * 10;

        for (int i = 0; i < totalIterations; i++)
        {
            Console.Write(spinner[i % spinnerLength]);
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }
    static void Congratulate() {
        Console.WriteLine("Congratulations on finishing your activity!");
    }
}