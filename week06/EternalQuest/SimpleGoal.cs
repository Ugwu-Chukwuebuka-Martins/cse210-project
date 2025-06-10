public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points):base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"{GetName()} ({GetDescription()})";
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    { 
        return $"Simple Goal:{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }

    public void SetIsComplete(bool complete)
    {
        _isComplete = complete;
    }
}