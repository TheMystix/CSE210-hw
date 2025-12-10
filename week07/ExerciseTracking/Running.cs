using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / Minutes) * 60;

    public override double GetPace() => Minutes / _distance;

    public override string GetSummary()
    {
        return $"{Date:yyyy MM dd} Running ({Minutes} min): Distance {_distance} miles, Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}
