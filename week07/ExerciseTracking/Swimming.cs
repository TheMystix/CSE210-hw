using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50;
    private const double MetersToMiles = 0.000621371;

    public Swimming(DateTime date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date:yyyy MM dd} Swimming ({Minutes} min): Laps {_laps}, Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}
