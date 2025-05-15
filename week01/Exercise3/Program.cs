using System;

class Program
{
    static void Main(string[] args)
    {
        Random generateRandom = new Random();
        int magic = generateRandom.Next(1, 100);
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        int count = 1;
        do
        {
            count += 1;
            if (guess < magic)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess > magic)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                  Console.WriteLine("You guessed it right !");
                  Console.WriteLine($"You guuessed {count} times");
                  Console.Write("Do you want to play again? ");
                  string playAgain = Console.ReadLine();
                  if (playAgain == "YES" || playAgain == "yes")
                  {
                    magic = generateRandom.Next(1, 100);
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                  }
                  else if (playAgain == "NO" || playAgain == "no")
                  {
                    Console.WriteLine("cSharp I am tired of guessing a number");
                    break;
                  }
            }
        } while (true);
    }
}