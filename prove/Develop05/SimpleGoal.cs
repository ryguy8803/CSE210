using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    //new simple goal
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }
    //load from save
    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDetails()},{GetPoints()},{GetStatus()}";
    }


}