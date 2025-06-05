public class BreathingActivity
{
    Activity activity = new Activity("Breathing Activity",
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    );
    public void BreathingActivity_()
    {
        Console.Clear();
        activity.DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int durate = int.Parse(Console.ReadLine());
        activity.SetDuration(durate);
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        activity.ShowSpinner(8);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(activity.GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breath In...");
            activity.ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Now Breath Out...");
            activity.ShowCountDown(5);
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Well Done, Breathing Continues!!!");
        activity.DisplayEndingMessage();
        activity.ShowSpinner(8);
    }
}