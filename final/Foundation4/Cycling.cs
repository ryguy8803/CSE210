public class Cycling : Activity
{
    private double _speedcycling; 

    // Constructor
    public Cycling(string date, double minutes, double speedcycling)
        : base(date, minutes)
    {
        _speedcycling = speedcycling;
    }
    
    public override double GetDistance()
    {
        return (_speedcycling * minutes) / 60; 
    }
    
    public override double GetSpeed()
    {
        return _speedcycling;
    }
   
    public override double GetPace()
    {
        if (_speedcycling == 0) return 0;
        return 60 / _speedcycling; 
    }

    public override string GetSummary()
    {
        return $"{date} Cycling ({minutes} min) - Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}