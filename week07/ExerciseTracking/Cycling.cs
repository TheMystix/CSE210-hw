using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance() => (_speed * Minutes) / 60;

    public override double GetSpeed() => _speed;

    public override double GetPace() => 60 / _speed;

    public override string GetSummary()
    {
        return $"{Date:yyyy MM dd} Cycling ({Minutes} min): Speed {_speed} mph, Distance {GetDistance():0.0} miles, Pace {GetPace():0.0} min per mile";
    }
}
