using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Activity run = new Running(
            new DateTime(2022, 11, 03),
            30,
            3.0
        );

        Activity cycle = new Cycling(
            new DateTime(2022, 11, 03),
            30,
            6.0 
        );

        Activity swim = new Swimming(
            new DateTime(2022, 11, 03),
            30,
            20
        );

        List<Activity> activities = new List<Activity>()
        {
            run, cycle, swim
        };

        Console.WriteLine("\n--- Activity Report ---\n");

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
