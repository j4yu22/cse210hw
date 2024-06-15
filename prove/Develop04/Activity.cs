using System;
using System.Diagnostics;
using System.Threading;

public abstract class Activity
{
    protected int time;
    protected string message;

    public void StartActivity()
    {
        Console.Clear();
        this.Load(4);
        Console.Clear();
        PrintDescription();
        time = GetDuration();
        Console.WriteLine("Get ready to begin...");
        Load(3);

        RunActivity();

        CongratulateUser();
    }

    protected abstract void PrintDescription();
    protected abstract void RunActivity();

    protected void DelayAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void CongratulateUser()
    {
        Console.Clear();
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"Activity duration: {time} seconds");
        DelayAnimation(3);
    }

    protected void TrackTime(Action activityAction)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.Elapsed.TotalSeconds < time)
        {
            activityAction();
        }
        stopwatch.Stop();
    }

    protected int GetDuration()
    {
        while (true)
        {
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

    protected void Load(int seconds)
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
}
