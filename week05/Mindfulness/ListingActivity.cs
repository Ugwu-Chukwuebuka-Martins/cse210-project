public class ListingActivity
{
    private int _count = 0;
    private List<string> _prompts = ["Who are people that you appreciate?","What are personal strengths of yours?",
    "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"];

    Activity activity = new Activity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

    public void ListingActivity_()
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
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompts: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        activity.ShowCountDown(6);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(activity.GetDuration());

        while (DateTime.Now < futureTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        Console.WriteLine("Well Done !!!");
        activity.DisplayEndingMessage();
        activity.ShowSpinner(6);
    }

    public void GetRandomPrompt()
    {
        Random generateRand = new Random();
        int rand = generateRand.Next(0, _prompts.Count);
        Console.WriteLine($"----{_prompts[rand]}----");
    }

    public void GetListFromUser()
    {
        List<string> list = [];
        Console.Write("> ");
        string input = Console.ReadLine();
        list.Add(input);
        _count += list.Count;
    }
}