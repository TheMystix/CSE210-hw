using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "y";
        while (response == "y")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guess = -1;  
            int guessCount = 0;

            while (guess != number)
            {
                Console.Write($"Please guess a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > number)
                    Console.WriteLine("Too high, guess again.");
                else if (guess < number)
                    Console.WriteLine("Too low, guess again.");
                else
                    Console.WriteLine($"Great job! You guessed the number in {guessCount} tries!");
            }

            Console.Write("Do you want to play again? (y/n) ");
            response = Console.ReadLine();
        }
    }
}