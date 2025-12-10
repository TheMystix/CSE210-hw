using System;

public abstract class Activity
{
    public DateTime Date { get; }
    public double Minutes { get; }

    protected Activity(DateTime date, double minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}
