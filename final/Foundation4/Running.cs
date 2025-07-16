public class Running : Activity
{
    private double _distance;


    public Running(string date, double minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (minutes == 0) return 0;
        return (GetDistance() / minutes) * 60; 
    }

    public override double GetPace()
    {
        if (GetDistance() == 0) return 0;
        return minutes / GetDistance(); 
    }

    public override string GetSummary()
    {
        
        return $"{date} Running ({minutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}