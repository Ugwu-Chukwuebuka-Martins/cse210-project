using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your grade percentage? ");
        int gradePercent = int.Parse(Console.ReadLine());
        int gp = gradePercent % 10;
        string letter = "";
        string sign = "";

        if (gradePercent >= 90)
        {
            if (gp >= 7 )
            {
                letter = "A";
            }
            else if (gp < 3)
            {
                letter = "A";
                sign = "-";
            }
            else
            {
                letter = "A";
            }
        }

        else if (gradePercent >= 80)
        {
            if (gp >= 7 )
            {
                letter = "B";
                sign = "+";
            }
            else if (gp < 3)
            {
                letter = "B";
                sign = "-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (gradePercent >= 70)
        {
            if (gp >= 7 )
            {
                letter = "C";
                sign = "+";
            }
            else if (gp < 3)
            {
                letter = "C";
                sign = "-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (gradePercent >= 60)
        {
            if (gp >= 7 )
            {
                letter = "D";
                sign = "+";
            }
            else if (gp < 3)
            {
                letter = "D";
                sign = "-";
            }
            else
            {
                letter = "D";
            }
        }
        else if (gradePercent < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations You Passed!");
        }
        else
        {
            Console.WriteLine("Why this grade, try and upgrade next time");
        }
    }
}