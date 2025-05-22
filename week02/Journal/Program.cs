using System;

class Program
{
    static void Main(string[] args)
    {
       Entry entry = new Entry();
       PromptGenerator prompt = new PromptGenerator();
       Journal journ = new Journal();

       DateTime theCurrentTime = DateTime.Now;
       string dateText = theCurrentTime.ToShortDateString();
       
       entry._date = dateText;
       
       prompt._prompts = ["What was the most interesting person I interacted with today? ","What was the best part of my day? ",
       "How did I see the hand of the Lord in my life today? ","What was the strongest emotion I felt today? ", 
       "If I had one thing I could do over today, what would it be? "];
       while (true)
       {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                entry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                journ.AddEntry(entry);
            }
            else if (select == 2)
            {
                 journ.DisplayAll();
            }
            else if (select == 3)
            {
                journ.SaveToFile("journal.txt");
            }
            else if (select == 4)
            {
                journ.LoadFromFile("journal.txt");
            }
            else if (select == 5)
            {
                break;
            }
       }
    }
}