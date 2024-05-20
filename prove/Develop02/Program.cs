using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the journal program! Pick one of the below by typing the number (1 / 2 / 3 / 4 / 5).");
        List<string> menu = new List<string> { "Write", "Display", "Load", "Save", "Quit" };

        while (true)
        {
            for (int i = 0; i < menu.Count; i++)
            {
                Console.WriteLine($"{i+1}. {menu[i]}");
            }

            int choice;
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();
                try
                {
                    choice = int.Parse(input);
                    if (choice >= 1 && choice <= 5)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                Console.WriteLine($"You chose {menu[choice - 1]}");
                switch (choice)
                {
                    case 1:
                        journal.NewEntry();
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        journal.LoadJournal();
                        break;
                    case 4:
                        journal.SaveJournal();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
