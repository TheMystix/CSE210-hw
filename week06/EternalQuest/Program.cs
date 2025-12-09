using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Display Score");
            Console.WriteLine("  7. Quit");

            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case "5":
                    RecordEvent(manager);
                    break;

                case "6":
                    manager.DisplayScore();
                    break;

                case "7":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.\n");
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Select a goal type: ");
        string typeChoice = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points for completing this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, description, points));
                break;

            case "2":
                manager.AddGoal(new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("How many times does this need to be accomplished? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for completing it? ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;

            default:
                Console.WriteLine("Invalid goal type.\n");
                return;
        }

        Console.WriteLine("Goal created!\n");
    }

    static void RecordEvent(GoalManager manager)
    {
        manager.DisplayGoals();

        Console.Write("Enter the number of the goal you accomplished: ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber))
        {
            manager.RecordEvent(goalNumber - 1);
        }
        else
        {
            Console.WriteLine("Invalid input.\n");
        }
    }
}
