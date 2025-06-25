using System;
using System.Drawing;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _points = points;
        _description = description;
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetPoints()
    {
        return _points;
    }
    public string GetDetails()
    {
        return _description;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string GetStringRepresentation();
    




}
