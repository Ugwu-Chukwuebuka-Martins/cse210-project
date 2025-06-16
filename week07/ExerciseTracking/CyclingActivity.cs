public class CyclingActivity : Activity
{
    private int _distance;
    public CyclingActivity(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public int CalculateSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min) - Speed: {CalculateSpeed()} mph, Distance: {_distance} miles , Pace: {GetLength()/_distance} min per mile";
    }
}