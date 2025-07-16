public abstract class Activity
{
    private string _date;
    private double _minutes;

    public string date => _date;
    public double minutes => _minutes;
    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual string GetSummary()
    {
        return $"{_date} ({_minutes} min)";
    }
    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed();    // in mph
    public abstract double GetPace();     // in min/mile

}