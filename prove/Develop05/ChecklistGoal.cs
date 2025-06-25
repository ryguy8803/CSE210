public class ChecklistGoal : Goal
{
    private int _amountCompleted; 
    private int _targetAmount;    
    private int _bonusPoints;     

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints)
        : base(name, description, points) 
    {
        _amountCompleted = 0; 
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints, int amountCompleted)
        : base(name, description, points) 
    {
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted; 
    }

    public override int RecordEvent()
    {
        _amountCompleted++; 
        int pointsEarned = GetPoints(); 

        if (_amountCompleted == _targetAmount)
        {
            pointsEarned += _bonusPoints;
        }
        return pointsEarned;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;

    }
    public override string GetStatus()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} Completed {_amountCompleted}/{_targetAmount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDetails()},{GetPoints()},{_targetAmount},{_bonusPoints},{_amountCompleted}";
    }
}