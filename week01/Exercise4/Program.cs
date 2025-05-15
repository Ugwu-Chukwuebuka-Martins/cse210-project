using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numInput = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (numInput != 0)
        {
            Console.Write("Enter a number: ");
            numInput = int.Parse(Console.ReadLine());
            if (numInput != 0)
            {
                numbers.Add(numInput);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int largestNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        int smallestNum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (number < smallestNum)
                    {
                        smallestNum = number;
                    }
            }
        }

        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestNum}");
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}