using System;
using System.Collections.Generic;
namespace Develop04;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Breathing_Activity breathing_Activity = new Breathing_Activity();
                breathing_Activity.RunBreathingActivity();
            }
            else if (input == "2")
            {
                Reflection_Activity reflection_Activity = new Reflection_Activity();
                reflection_Activity.RunReflectionActivity();
            }
            else if (input == "3")
            {
                Listing_Activity listing_Activity = new Listing_Activity();
                listing_Activity.RunListingActivity();
            }
            else if (input == "4")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}