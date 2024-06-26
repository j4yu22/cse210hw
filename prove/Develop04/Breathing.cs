using System;

public class BreathingActivity : Activity
{
    protected override void PrintDescription()
    {
        Console.Clear();
        Console.WriteLine("Breathing Activity");
        Console.WriteLine("This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    protected override void RunActivity()
    {
        TrackTime(() =>
        {
            Console.Clear();
            Console.WriteLine("Breathe in");
            DelayAnimation(5);
            Console.Clear();
            Console.WriteLine("Breathe out");
            DelayAnimation(5);
        });
    }
}
