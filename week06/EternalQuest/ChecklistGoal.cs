public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name,description,points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted+=1;
        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        }
        else
        {
            return GetPoints();
        }
    }

    public override bool isComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
            return $"{GetName()} ({GetDescription()}) -- Currently Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }
    
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}