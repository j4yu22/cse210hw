using System;

class Program
{
    static void Main()
    {
        menu();
    }
    static void menu() {
        while (true) {
            Console.WriteLine("1. BreathingActivity");
            Console.WriteLine("2. ListingActivity");
            Console.WriteLine("3. ReflectActivity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    Console.WriteLine($"You chose option {choice}.");
                    break;
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    Console.WriteLine($"You chose option {choice}.");
                    break;
                case 3:
                    ReflectActivity reflectionActivity = new ReflectActivity();
                    reflectionActivity.Run();
                    Console.WriteLine($"You chose option {choice}.");
                    break;
                case 4:
                    Console.WriteLine($"You chose option {choice}.");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}