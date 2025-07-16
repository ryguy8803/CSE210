public class Swimming : Activity
{
    private int _laps;
    private const double LapLength = 50; 
     

    
    public Swimming(string date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    
    public override double GetDistance()
    {
        return _laps * LapLength;
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
        return $"{date} Swimming ({minutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile, Laps: {_laps}";
    }
}
