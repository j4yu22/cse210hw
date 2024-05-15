using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program! Pick one of the below by typing the number (1 / 2 / 3 / 4 / 5).");
        List<string> menu = ["Write", "Display", "Load", "Save","Quit"];
        while (true)
        {
            for (int i = 0; i < menu.Count; i++){
                Console.WriteLine($"{i+1}. {menu[i]}");
            }
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine($"You chose {menu[choice - 1]}");
            switch (choice)
            {
                case 1:
                    journal.NewEntry();
                    break;
                case 2:
                    Journal.displayentries();
                    break;
                case 3:
                    Console.WriteLine("Save Journal");
                    break;
                case 4:
                    Console.WriteLine("Load Journal");
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