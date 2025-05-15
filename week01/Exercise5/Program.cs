using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string uName = PromptTheUserName();
        int fNumber = PromptTheUsersFavoriteNumber();
        int squaredN = SquareNumber(fNumber);
        DisplayTheResult(uName,squaredN);
    }
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to this Program!!!");
        }
        static string PromptTheUserName()
        {
            Console.Write("Enter your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptTheUsersFavoriteNumber()
        {
            Console.Write("Enter your favourite number? ");
            int favouriteNumber = int.Parse(Console.ReadLine());
            return favouriteNumber;
        }
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayTheResult(string userN,int squareN)
        {
            Console.WriteLine($"{userN} the square of your number is {squareN}");
        }
}