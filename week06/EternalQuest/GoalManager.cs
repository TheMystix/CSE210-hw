using System;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created.\n");
            return;
        }

        Console.WriteLine("Your Goals:");
        int index = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
        Console.WriteLine();
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.\n");
            return;
        }

        Goal goal = _goals[index];

        goal.RecordEvent();
        _score += goal.GetPoints();

        // Bonus for checklist goals
        if (goal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
            {
                _score += checklist.GetBonus();
            }
        }

        Console.WriteLine("Event recorded!\n");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.\n");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal goal = ParseGoal(lines[i]);
            _goals.Add(goal);
        }

        Console.WriteLine("Goals loaded.\n");
    }

    private Goal ParseGoal(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];

        switch (type)
        {
            case "SimpleGoal":
                SimpleGoal sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                sg.SetComplete(bool.Parse(parts[4]));
                return sg;

            case "EternalGoal":
                return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

            case "ChecklistGoal":
                ChecklistGoal cg = new ChecklistGoal(
                    parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[5]), int.Parse(parts[4])
                );

                cg.SetAmountCompleted(int.Parse(parts[6]));
                return cg;

            default:
                throw new Exception($"Unknown goal type: {type}");
        }
    }
}
