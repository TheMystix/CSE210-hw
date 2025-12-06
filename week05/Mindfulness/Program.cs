using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Activities ===");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
            }

            Console.Clear();
            activity.DisplayStartMessage();

            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                activity.Duration = duration;
            }
            else
            {
                Console.WriteLine("Invalid duration. Defaulting to 30 seconds.");
                activity.Duration = 30;
            }

            Console.Clear();

            activity.PerformActivity();

            activity.DisplayEndMessage();

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }

        Console.WriteLine("\nGoodbye!");
    }
}
