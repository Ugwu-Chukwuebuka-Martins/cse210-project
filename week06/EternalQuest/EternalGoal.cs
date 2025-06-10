public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
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
        return $"Eternal Goal:{GetName()},{GetDescription()},{GetPoints()}";
    }

    public void SetIsComplete(bool complete)
    {
       _isComplete = complete;
    }
}