using System;

class Program
{
    static void Main()
    {
        do
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guess;
            int numberOfGuesses = 0;

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            } while (guess != magicNumber);

            Console.WriteLine($"You guessed it in {numberOfGuesses} guesses!");

            Console.Write("Do you want to play again? (yes/no): ");
        } while (Console.ReadLine().Trim().ToLower() == "yes");
    }
}
