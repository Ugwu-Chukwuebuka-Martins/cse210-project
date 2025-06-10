// UC Martins Mindfulness
using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start Breathing Activity");
            Console.WriteLine("   2. Start Reflecting Activity");
            Console.WriteLine("   3. Start Listing Activity");
            Console.WriteLine("   4. Quit");

            Console.Write("Select a choice from the menu: ");
            int chose = int.Parse(Console.ReadLine());
            
            if (chose == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.BreathingActivity_();
                breathingActivity.Run();
            }
            
            else if (chose == 2)
            {
                ReflectingActivity reflectAct = new ReflectingActivity();
                reflectAct.ReflectingActivity_();
                reflectAct.Run();
            }

            else if (chose == 3)
            {
                ListingActivity listActivity = new ListingActivity();
                listActivity.ListingActivity_();
                listActivity.Run();
            }

            else if (chose == 4)
            {
                Console.Clear();
                break;
            }
        }
    }
}