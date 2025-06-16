public class SwimmingActivity : Activity
{
    private int _distance;
    public SwimmingActivity(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public double CalculateSwimminglabs()
    {
        return _distance / 0.8;
    }

    public int CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min) - Number of Labs: {CalculateSwimminglabs()} miles, Distance: {_distance} miles, Speed: {CalculateSpeed()} mph, \nPace: {GetLength()/_distance} min per mile";
    }
}