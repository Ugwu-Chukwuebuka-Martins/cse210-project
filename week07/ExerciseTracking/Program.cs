using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];
        RunningActivity run = new RunningActivity("16 Jun 2025", 30, 6);
        CyclingActivity cycle = new CyclingActivity("17 Jun 2025", 30, 3);
        SwimmingActivity swim = new SwimmingActivity("18 Jun 2025", 30, 3);
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        foreach (Activity act in activities)
        {
            Console.WriteLine("---");
            Console.WriteLine(act.GetSummary());
            Console.WriteLine("---");
        }
    }
}