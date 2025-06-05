public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int second)
    {
        List<string> animateString = ["|", "/", "–", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(second);

        int init = 0;

        while (DateTime.Now < futureTime)
        {
            Console.Write(animateString[init]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            init++;

            if (init >= animateString.Count)
            {
                init = 0;
            }
        }
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}