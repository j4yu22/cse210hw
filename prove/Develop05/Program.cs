using System;

class Program
{
    static void Main(string[] args)
    {
        Quest quest = new Quest();

        // Sample goals
        quest.CreateGoal(new SimpleGoal(1000, "Run a marathon"));
        quest.CreateGoal(new EternalGoal(100, "Read scriptures"));
        quest.CreateGoal(new ChecklistGoal(50, "Attend the temple", 10, 500));

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Display Goals");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Score");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        quest.DisplayGoals();
                        break;
                    case 2:
                        Console.Write("Enter the name of the goal you completed: ");
                        string goalName = Console.ReadLine();
                        quest.RecordEvent(goalName);
                        break;
                    case 3:
                        quest.DisplayScore();
                        break;
                    case 4:
                        Console.Write("Enter file path to save goals (default is goals.json): ");
                        string savePath = Console.ReadLine();
                        quest.SaveGoals(string.IsNullOrEmpty(savePath) ? "goals.json" : savePath);
                        break;
                    case 5:
                        Console.Write("Enter file path to load goals (default is goals.json): ");
                        string loadPath = Console.ReadLine();
                        quest = Quest.LoadGoals(string.IsNullOrEmpty(loadPath) ? "goals.json" : loadPath);
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
            }
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}