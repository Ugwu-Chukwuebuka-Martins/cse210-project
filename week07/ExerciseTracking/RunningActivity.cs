public class RunningActivity : Activity
{
    private int _speed;
    public RunningActivity(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public int CalculateDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLength()} min) - Distance: {CalculateDistance()} miles, Speed: {_speed} mph, Pace: {60/_speed} min per mile";
    }
}