using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Valve";
        job1._jobTitle = "Game Developer";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Epic Games";
        job2._jobTitle = "Senior Game Developer";
        job2._startYear = 2019;
        job2._endYear = 2025;

        Resume resume1 = new Resume();
        resume1._name = "Jedediah Rudy";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
        
    }
    
}