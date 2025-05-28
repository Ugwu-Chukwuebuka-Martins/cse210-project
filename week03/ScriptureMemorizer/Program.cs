using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        do
        {
            Random generateRandom = new Random();
            int magic = generateRandom.Next(1, scripture._words.Count);
            scripture.GetDisplayText();
            scripture.Script();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to finish ");
            string press = Console.ReadLine();
            if (press == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();
                scripture.HideRandomWords(magic);
            }
        }
        while (true);

    }
}