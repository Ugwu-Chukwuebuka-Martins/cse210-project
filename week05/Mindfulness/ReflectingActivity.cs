public class ReflectingActivity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Who are people that you appreciate?","What are personal strengths of yours?",
    "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"];

    Activity activity = new Activity("Reflecting Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

    public void ReflectingActivity_()
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
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        activity.ShowCountDown(6);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(activity.GetDuration());

        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
        }
        Console.WriteLine();
        Console.WriteLine("Well Done !!");
        activity.DisplayEndingMessage();
        activity.ShowSpinner(6);
    }

    public string GetRandomPrompt()
    {
        Random generateRand = new Random();
        int rand = generateRand.Next(0, _prompts.Count);
        return _prompts[rand];
    }

    public string GetRandomQuestion()
    {
        Random generateRand = new Random();
        int rand = generateRand.Next(0, _questions.Count);
        return _questions[rand];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---- {GetRandomPrompt()} ----");
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        activity.ShowSpinner(8);
        Console.WriteLine();
    }
}